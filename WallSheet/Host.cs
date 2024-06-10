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

        public Host()
        {
            InitializeComponent();
        }
        private void StartServer()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                AppendToChatLog("Server started. Waiting for connections...");

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
            }

            client.Close();
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
        }
        private void Host_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }
}
