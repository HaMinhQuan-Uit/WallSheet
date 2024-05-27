using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class ResetPassword : Form
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public ResetPassword()
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

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = SendCode.to;
            string newPassword = textBox1.Text;

            // Update mật khẩu mới vào Firebase
            var update = new { password = newPassword };
            FirebaseResponse response = await Task.Run(() => client.Update($"users/{email}/password", update));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Password reset successful.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error resetting password.");
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

