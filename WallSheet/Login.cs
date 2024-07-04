using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using Firebase_Project;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
namespace WallSheet
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txbUserName.KeyDown += Txb_KeyDown;
            txbPassword.KeyDown += Txb_KeyDown;
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash. This returns the hash as a byte array.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        IFirebaseClient client;

        



        private void FormLogin_Load(object sender, EventArgs e)
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
        private void btnLogin_click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUserName.Text) ||
                string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txbUserName.Text);
            MyUser ResUser = res.ResultAs<MyUser>();

            // Mã hóa mật khẩu nhập vào
            string hashedPassword = ComputeSha256Hash(txbPassword.Text);

            if (ResUser != null && ResUser.Password == hashedPassword)
            {
                ProfileName profileName = new ProfileName();
                this.Hide();
                profileName.Show();
            }
            else
            {
                MyUser.ShowError();
            }
        }
        private void btnResgiter_click_Click(object sender, EventArgs e)
        {
            this.Hide();
             formRegistration  reg = new formRegistration();
            reg.Hide();
            reg.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           this.Hide();
            SendCode sendCode = new SendCode();
            sendCode.Show();
        }
        private void Txb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_click_Click(sender, e);
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            txbUserName.Text = "";
        }
    }
}
