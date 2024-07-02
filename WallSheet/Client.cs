using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WallSheet
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Random random = new Random();
        private List<KeyValuePair<int, double>> dataPoints = new List<KeyValuePair<int, double>>();
        private int turn = 1;
        private Thread receiveThread;

        public Client()
        {
            InitializeComponent();
        }


        private void ConnectToServer()
        {
            try
            {
                string serverIp = DiscoverServer();
                if (serverIp != null)
                {
                    client = new TcpClient(serverIp, 8888);
                    stream = client.GetStream();
                    AppendToChatLog("Đã kết nối tới server.");

                    receiveThread = new Thread(ReceiveMessages);
                    receiveThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string DiscoverServer()
        {
            UdpClient udpClient = new UdpClient();
            udpClient.EnableBroadcast = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 8889);

            byte[] sendBytes = Encoding.ASCII.GetBytes("DISCOVER_SERVER");
            udpClient.Send(sendBytes, sendBytes.Length, endPoint);

            udpClient.Client.ReceiveTimeout = 5000;
            try
            {
                byte[] receiveBytes = udpClient.Receive(ref endPoint);
                string serverIp = Encoding.ASCII.GetString(receiveBytes);
                return serverIp;
            }
            catch (SocketException)
            {
                MessageBox.Show("Không thể tìm thấy server. Vui lòng kiểm tra kết nối mạng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void DisplayPriceIfNeeded()
        {
            if (shouldDisplayPrice)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Price.Text = hiddenPrice.Text; // Now update the Price TextBox
                    shouldDisplayPrice = false; // Reset the flag
                });
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            ConnectToServer();
            turn = random.Next(10, 31);
            double price = random.NextDouble() * (99.99 - 0.09) + 0.09;
            double budget = random.NextDouble() * (1000000 - 0.1) + 0.1;
            double target = budget * (random.NextDouble() * 2 + 1);
            int quantity = 0;

            Turn.Text = turn.ToString();
            Price.Text = price.ToString("F2");
            Budget.Text = budget.ToString("F2");
            Target.Text = target.ToString("F2");
            Quantity.Text = quantity.ToString();
        }
        private bool shouldDisplayPrice = false;
        private void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (message.StartsWith("PRICE:"))
                    {
                        string priceStr = message.Substring("PRICE:".Length);
                        double price;
                        if (double.TryParse(priceStr, out price))
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                hiddenPrice.Text = price.ToString("F2");
                                shouldDisplayPrice = true; // Set the flag to true
                                // Re-enable buttons when a new price is received
                                button1.Enabled = true;
                                button2.Enabled = true;
                            });
                        }
                    }
                    string message1 = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (message1 == "END_SESSION")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Hide(); // Hide the Client form
                            EndTran endTranForm = new EndTran();
                            endTranForm.Show(); // Show the EndTran form for the client
                        });
                        return; // Exit the loop since the session is ending
                    }
                    else
                    {
                        AppendToChatLog($"Server: {message}");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendToChatLog($"Error receiving data: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                AppendToChatLog($"You: {message}");
                txtMessage.Clear();
            }
        }

        private void AppendToChatLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendToChatLog), message);
                return;
            }

            txtChatLog.AppendText(message + Environment.NewLine);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }

            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Price_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleSell();
            button1.Enabled = false; // Disable button 1
            button2.Enabled = false; // Disable button 2
            SendMessageToServer("Tôi đã bán");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleBuy();
            button1.Enabled = false; // Disable button 1
            button2.Enabled = false; // Disable button 2
            SendMessageToServer("Tôi đã mua");
        }

        private void HandleSell()
        {
            int a = int.Parse(textBox5.Text);
            double x = double.Parse(hiddenPrice.Text); // Use hiddenPrice value
            double z = double.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);

            if (y - a >= 0)
            {
                z = z + a * x;
                y = y - a;
                m--;

                UpdateUI(x, z, y, m);
                turn++;
                CheckWinLose(z, m);
            }
            else
            {
                MessageBox.Show("Cannot sell more than the current quantity.");
            }
        }

        private void HandleBuy()
        {
            int a = int.Parse(textBox5.Text);
            double x = double.Parse(hiddenPrice.Text); // Use hiddenPrice value
            double z = double.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);

            z = z - a * x;
            y = y + a;
            m--;

            UpdateUI(x, z, y, m);
            turn++;
            CheckWinLose(z, m);
        }

        private void UpdateUI(double price, double budget, int quantity, int turn)
        {
            Price.Text = price.ToString();
            Budget.Text = budget.ToString();
            Quantity.Text = quantity.ToString();
            Turn.Text = turn.ToString();

            dataPoints.Add(new KeyValuePair<int, double>(this.turn, budget));
            UpdateChart(dataPoints);
        }

        private void UpdateChart(List<KeyValuePair<int, double>> dataPoints)
        {
            var series = new Series("Budget")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            foreach (var dataPoint in dataPoints)
            {
                series.Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Turn";
            chart1.ChartAreas[0].AxisY.Title = "Budget";
            double target = double.Parse(Target.Text);
            chart1.ChartAreas[0].AxisY.Maximum = target;
            chart1.Invalidate();
        }

        private void CheckWinLose(double budget, int turn)
        {
            double target = double.Parse(Target.Text);

            if (budget >= target)
            {
                FormWin winForm = new FormWin();
                winForm.Show();
                SendMessageToServer("WIN");
                this.Close();
            }
            else if (turn == 0)
            {
                FormLose loseForm = new FormLose();
                loseForm.Show();
                SendMessageToServer("LOSE");
                this.Close();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            FormLose loseForm = new FormLose();
            loseForm.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void SendMessageToServer(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        private void hiddenPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



