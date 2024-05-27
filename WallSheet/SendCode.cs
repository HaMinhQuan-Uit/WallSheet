using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class SendCode : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private async Task<bool> IsEmailExistsAsync(string Email)
        {
            FirebaseResponse response = await Task.Run(() => client.Get($"users/{Email}"));
            return response.Body != "null"; // Kiểm tra email có tồn tại trong Firebase hay không
        }


        string randomcode;
        public static string to;

        private async void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra email tồn tại trong Firebase trước khi gửi mã
            if (await IsEmailExistsAsync(textBox2.Text))
            {
                string from, pass, messagebody;
                Random rand = new Random();
                string randomcode = rand.Next(999999).ToString();
                MailMessage message = new MailMessage();
                string to = textBox2.Text;

                from = "tamuitk17@gmail.com";
                pass = "ljxm ojff ouhb qkiz";
                messagebody = $"Your Reset Code is {randomcode}";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password Reset Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Successfully Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!");
            }
        }

        public SendCode()
        {
            InitializeComponent();
            InitializeFirebase();
        }

        private void InitializeFirebase()
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện kiểm tra mã khi người dùng nhập mã và ấn nút "Xác nhận"
            if (randomcode == textBox1.Text)
            {
                ResetPassword rp = new ResetPassword();
                to = textBox2.Text;
                Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Mã không đúng");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
        private void SendCode_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
