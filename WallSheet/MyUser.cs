using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebase_Project
{
    class MyUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ComfirnPassWord { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }

        private static string error1 = "Tài khoản không tồn tại!";
        private static string error2 = "Cảnh báo";

        private static IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };

        private static IFirebaseClient client;

        static MyUser()
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
                MessageBox.Show($"Không thể kết nối tới Firebase client: {ex.Message}", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void ShowError()
        {
            MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error1 = "Tài khoản không tồn tại!";
                return false;
            }
            else if (user1.Password != user2.Password)
            {
                error1 = "Sai tài khoản hoặc mật khẩu!";
                return false;
            }
            else if (user1.Password != user1.Password)
            {
                error1 = "Mật khẩu không khớp!";
                return false;
            }

            return true;
        }

        public static bool Search(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static async Task<bool> IsEmailExistsAsync(string email)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Users");
                var users = response.ResultAs<Dictionary<string, MyUser>>();

                foreach (var user in users)
                {
                    if (user.Value.Email == email)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra email: {ex.Message}");
                return false;
            }
        }
    }
}