using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Client()
        {
            InitializeComponent();
        }
        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();
                AppendToChatLog("Connected to server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            ConnectToServer();
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
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
