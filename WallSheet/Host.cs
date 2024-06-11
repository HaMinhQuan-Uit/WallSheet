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

        public Host()
        {
            InitializeComponent();
            Instance = this;
        }

        public static Host Instance { get; private set; }

        private void StartServer()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                serverId = Guid.NewGuid().ToString(); // Generate a unique ID for the server
                AppendToChatLog($"Server started with ID: {serverId}. Waiting for connections...");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
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

            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                AppendToChatLog($"Client: {message}");

                if (message == "WIN")
                {
                    // Client won
                    if (textBox4.Text == "Good Stock Broker")
                    {
                        // Host is Good, so host wins
                        ShowWinForm();
                    }
                    else
                    {
                        // Host is Bad, so host loses
                        ShowLoseForm();
                    }
                }
                else if (message == "LOSE")
                {
                    // Client lost
                    if (textBox4.Text == "Good Stock Broker")
                    {
                        // Host is Good, so host loses
                        ShowLoseForm();
                    }
                    else
                    {
                        // Host is Bad, so host wins
                        ShowWinForm();
                    }
                }
            }

            client.Close();
        }

        private void ShowWinForm()
        {
            // Show the win form
            FormWin winForm = new FormWin();
            winForm.Show();
        }

        private void ShowLoseForm()
        {
            // Show the lose form
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RandomizeHostJob()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // Generates 0 or 1

            if (randomNumber == 1)
            {
                textBox4.Text = "Good Stock Broker";
            }
            else
            {
                textBox4.Text = "Bad Stock Broker";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public double textBox3
        {
            get { return double.Parse(nextPrice.Text); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            double x = random.NextDouble() * (200 - 1) + 1; // This will give a value between 1% and 200%
            nextPrice.Text = x.ToString();
        }
    }
}
