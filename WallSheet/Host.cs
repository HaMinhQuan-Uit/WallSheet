using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class Host : Form
    {
        private TcpListener listener;
        private Thread listenThread;
        private Thread broadcastThread;
        private string serverId;
        private List<TcpClient> clients; // Danh sách các kết nối client

        public Host()
        {
            InitializeComponent();
            Instance = this;
            clients = new List<TcpClient>(); // Khởi tạo danh sách các kết nối client
        }

        public static Host Instance { get; private set; }

        private void StartServer()
        {
            listenThread = new Thread(new ThreadStart(StartListening));
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void StartListening()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                serverId = Guid.NewGuid().ToString();
                AppendToChatLog($"You started with ID: {serverId}. Waiting for connections...");

                // Tạo một thread riêng để lắng nghe thông điệp DISCOVER_SERVER qua UDP
                Thread udpThread = new Thread(HandleUdpBroadcast);
                udpThread.IsBackground = true;
                udpThread.Start();

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client); // Thêm client vào danh sách
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HandleUdpBroadcast()
        {
            UdpClient udpListener = new UdpClient(8889);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 8889);
            while (true)
            {
                byte[] bytes = udpListener.Receive(ref groupEP);
                string message = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                if (message == "DISCOVER_SERVER")
                {
                    byte[] responseBytes = Encoding.ASCII.GetBytes(GetLocalIPAddress());
                    udpListener.Send(responseBytes, responseBytes.Length, groupEP);
                }
            }
        }
        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();

            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    AppendToChatLog($"Player : {message}");

                    // Check for specific messages to re-enable the Show button
                    if (message == "ACTION_TAKEN")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            Show.Enabled = true; // Re-enable the Show button
                        });
                    }
                    // Existing code for WIN/LOSE handling...
                    else if (message == "WIN" || message == "LOSE")
                    {
                        HandleWinLoseMessage(message);
                    }
                }
            }
            catch (Exception ex)
            {
                AppendToChatLog($"Error handling client: {ex.Message}");
            }
            finally
            {
                clients.Remove(client); // Loại bỏ client khỏi danh sách khi ngắt kết nối
                client.Close();
            }
        }
        private void HandleWinLoseMessage(string message)
        {
            // Check the role of the host and the message to decide which form to show
            bool isGoodStockBroker = textBox4.Text == "Good Stock Broker";

            if (message == "WIN")
            {
                if (isGoodStockBroker)
                {
                    ShowWinForm();
                }
                else
                {
                    ShowLoseForm();
                }
            }
            else if (message == "LOSE")
            {
                if (isGoodStockBroker)
                {
                    ShowLoseForm();
                }
                else
                {
                    ShowWinForm();
                }
            }

            // Close the host form after showing the win or lose form
            this.Invoke(new Action(() => this.Close()));
        }

    

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void ShowWinForm()
        {
            this.Invoke(new Action(() =>
            {
                using (FormWin winForm = new FormWin())
                {
                    winForm.ShowDialog(); // Use ShowDialog to block the current thread until the form is closed
                }
            }));
        }

        private void ShowLoseForm()
        {
            this.Invoke(new Action(() =>
            {
                using (FormLose loseForm = new FormLose())
                {
                    loseForm.ShowDialog(); // Use ShowDialog to block the current thread until the form is closed
                }
            }));
        }

        private void AppendToChatLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendToChatLog), message);
                return;
            }

            textBox1.AppendText(message + Environment.NewLine);
        }

        private void Host_Load(object sender, EventArgs e)
        {
            listenThread = new Thread(new ThreadStart(StartServer));
            listenThread.Start();
            RandomizeHostJob();

        }

        private void Host_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null)
            {
                listener.Stop();
            }

            if (listenThread != null && listenThread.IsAlive)
            {
                listenThread.Abort();
            }

            if (broadcastThread != null && broadcastThread.IsAlive)
            {
                broadcastThread.Abort();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi button1 được nhấn để gửi tin nhắn
            string message = textBox2.Text.Trim(); // Lấy tin nhắn từ textBox2
            if (!string.IsNullOrEmpty(message))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                List<TcpClient> disconnectedClients = new List<TcpClient>();

                foreach (var client in clients)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    catch (Exception)
                    {
                        disconnectedClients.Add(client);
                    }
                }

                foreach (var client in disconnectedClients)
                {
                    clients.Remove(client);
                }

                AppendToChatLog($"You : {message}");
                textBox2.Clear(); // Xóa textBox sau khi gửi tin nhắn
            }
        }

        private void RandomizeHostJob()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // Tạo số ngẫu nhiên từ 0 đến 1

            if (randomNumber == 1)
            {
                textBox4.Text = "Good Stock Broker";
            }
            else
            {
                textBox4.Text = "Bad Stock Broker";
            }
        }

        // Các phương thức xử lý sự kiện cho các controls khác

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }


        public double textBox3
        {
            get { return double.Parse(nextPrice.Text); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void Show_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble() * (200 - 1) + 1;
            nextPrice.Text = x.ToString();
            SendPriceToClients(x);
            Show.Enabled = false; // Disable the Show button after sending the price
        }

        private void SendPriceToClients(double price)
        {
            string message = $"PRICE:{price}";
            byte[] buffer = Encoding.ASCII.GetBytes(message);

            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception)
                {
                    // Handle client disconnection if necessary
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendCommandToClients("SHOW_ENDTRAN");
            ShowEndTranForm();
            this.Close(); // Close the Host form
        }

        private void SendCommandToClients(string command)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(command);
            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception)
                {
                    // Handle client disconnection if necessary
                }
            }
        }

        private void ShowEndTranForm()
        {
            EndTran endTranForm = new EndTran();
            endTranForm.ShowDialog();
        }


    }
}


