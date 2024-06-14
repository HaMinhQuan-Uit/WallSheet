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
            try
            {
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                serverId = Guid.NewGuid().ToString();
                AppendToChatLog($"Server started with ID: {serverId}. Waiting for connections...");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client); // Thêm client vào danh sách
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    AppendToChatLog($"Client: {message}");

                    if (message == "WIN")
                    {
                        if (textBox4.Text == "Good Stock Broker")
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
                        if (textBox4.Text == "Good Stock Broker")
                        {
                            ShowLoseForm();
                        }
                        else
                        {
                            ShowWinForm();
                        }
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

        private void ShowWinForm()
        {
            // Hiển thị form chiến thắng
            FormWin winForm = new FormWin();
            winForm.Show();
        }

        private void ShowLoseForm()
        {
            // Hiển thị form thất bại
            FormLose loseForm = new FormLose();
            loseForm.Show();
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

                AppendToChatLog($"Server: {message}");
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

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi button2 được nhấn
            // (nếu có)
        }

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
            // Send the price to clients but they will display it only after receiving the DISPLAY_PRICE command
            SendPriceToClients(x);
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
        private void SendDisplayPriceCommand()
        {
            string message = "DISPLAY_PRICE";
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

        private void RevealPrice_Click(object sender, EventArgs e)
        {
            SendDisplayPriceCommand();
        }
    }
}


