// ResetPassword.cs
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class ResetPassword : Form
    {
        private string email;

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public ResetPassword(string email)
        {
            InitializeComponent();
            this.email = email;
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

        private async void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;

            if (!string.IsNullOrEmpty(newPassword))
            {
                try
                {
                    var data = new { password = newPassword };
                    FirebaseResponse response = await client.UpdateAsync($"users/{email}/password", data);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Password updated successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating password: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a new password");
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

