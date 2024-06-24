// ResetPassword.cs
using Firebase_Project;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Kết nối Firebase thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo client Firebase: {ex.Message}", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            string newPassword = txbNewPassword.Text;
            string confirmPassword = txbConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FirebaseResponse response = await client.GetAsync("Users");
                var users = response.ResultAs<Dictionary<string, MyUser>>();
                bool passwordUpdated = false;

                foreach (var user in users)
                {
                    if (user.Value.Email == email)
                    {
                        string hashedNewPassword = ComputeSha256Hash(newPassword);
                        if (user.Value.Password == hashedNewPassword)
                        {
                            MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        user.Value.Password = hashedNewPassword;
                        await client.UpdateAsync($"Users/{user.Key}", user.Value);
                        passwordUpdated = true;
                    }
                }

                if (passwordUpdated)
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng với email này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đặt lại mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

