using Firebase_Project;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Net.Mail;
using System.Net;
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

        private async Task<bool> IsEmailExistsAsync(string email)
        {
            return await MyUser.IsEmailExistsAsync(email);
        }


        string randomcode;
        public static string to;

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
                if (client == null)
                {
                    throw new Exception("Client is null, failed to create FireSharp client.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize Firebase client: {ex.Message}", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra email tồn tại trong Firebase trước khi gửi mã
            if (await IsEmailExistsAsync(textBox2.Text))
            {
                // Tạo mã OTP và lưu vào biến randomcode của lớp SendCode
                randomcode = new Random().Next(100000, 999999).ToString();
                to = textBox2.Text;
                string from = "tamuitk17@gmail.com";
                string pass = "ljxm ojff ouhb qkiz";
                string messagebody = $"Your Reset Code is {randomcode}";

                MailMessage message = new MailMessage();
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
                    MessageBox.Show("Mã xác nhận đươc gửi thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể gửi mã xác nhận. Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!");
            }
        }



        // SendCode.cs
        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện kiểm tra mã khi người dùng nhập mã và ấn nút "Xác nhận"
            if (!string.IsNullOrEmpty(randomcode) && !string.IsNullOrEmpty(textBox1.Text) &&
    randomcode.Trim() == textBox1.Text.Trim())
            {
                to = textBox2.Text;
                ResetPassword rp = new ResetPassword(to); // Truyền email cho form ResetPassword
                Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Mã không đúng");
            }
        }


      

        private void SendCode_Load(object sender, EventArgs e)
        {
            InitializeFirebase();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}
