using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        private static string error1 = "Tài khoản không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {

            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (user1.Password != user1.ComfirnPassWord)
            {
                error1 = "Mật Khẩu Không Khớp!";

            }




            return true;
        }

        public static bool Search(MyUser user1, MyUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
