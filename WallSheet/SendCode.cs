using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

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

        private async Task<bool> IsPhoneNumberExistsAsync(string phoneNumber)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"users/{phoneNumber}");
                Console.WriteLine(response.Body); // Debug: Print response body to console
                return response.Body != "null"; // Kiểm tra số điện thoại có tồn tại trong Firebase hay không
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking phone number: {ex.Message}");
                return false;
            }
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
                MessageBox.Show("Firebase connection established successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize Firebase client: {ex.Message}", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại tồn tại trong Firebase trước khi gửi mã
            if (await IsPhoneNumberExistsAsync(textBox2.Text))
            {
                Random rand = new Random();
                randomcode = rand.Next(999999).ToString();
                to = textBox2.Text;

                try
                {
                    // Thiết lập thông tin Twilio
                    const string accountSid = "AC38673cff4b323cdf25a2f402d5d52b11";
                    const string authToken = "ee10373a5082a0efebcac7ac2c8f850a";
                    TwilioClient.Init(accountSid, authToken);

                    // Gửi tin nhắn SMS chứa mã xác nhận
                    var message = MessageResource.Create(
                        body: $"Your Reset Code is {randomcode}",
                        from: new PhoneNumber("+14235152216"),
                        to: new PhoneNumber(to)
                    );

                    MessageBox.Show("Code Successfully Sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không tồn tại trong hệ thống!");
            }
        }

        // SendCode.cs
        private void button2_Click(object sender, EventArgs e)
        {
            // Thực hiện kiểm tra mã khi người dùng nhập mã và ấn nút "Xác nhận"
            if (randomcode == textBox1.Text)
            {
                to = textBox2.Text;
                ResetPassword rp = new ResetPassword(to); // Truyền số điện thoại cho form ResetPassword
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
