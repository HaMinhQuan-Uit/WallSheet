using Firebase_Project;
using System.Security.Cryptography;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;
namespace WallSheet
{
  
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
            txbPhoneNumber.KeyPress += txbPhoneNumber_KeyPress;
            txbPhoneNumber.KeyPress += txbPhoneNumber_KeyPress;
            txbConfirmPass.KeyDown += txbcConfirmPass_KeyDown;
            txbUserrName.KeyDown += txbUserrName_KeyDown;
            txbPassword.KeyDown += txbPassword_KeyDown;
            txbEmail.KeyDown += txbEmail_KeyDown;
            txbPhoneNumber.KeyDown += txbPhoneNumber_KeyDown;
      
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private string ComputeSha256Hash(string rawData)
        {
            // tao doi tuong SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // tinh toan ma bam - Hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // chuyen mang byte sang string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        { 
          // khong cho phep nhap ki tu khac ngoai so vao textbox
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
            if (txbPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại.");
            }

        }
       
        private void formRegistration_Load(object sender, EventArgs e)
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
        private async void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUserrName.Text) ||
                string.IsNullOrWhiteSpace(txbPassword.Text) ||
                string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txbConfirmPass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ding dang format email
            string emailPattern = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            if (!Regex.IsMatch(txbEmail.Text, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng. Vui lòng nhập lại.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                // ket noi firebase và kiem tra xem phonenumber da duoc su dung chua va in ra thong bao
            FirebaseResponse ress = await client.GetAsync("Users");
            Dictionary<string, MyUser> data = ress.ResultAs<Dictionary<string, MyUser>>();
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (item.Value.Phonenumber == txbPhoneNumber.Text)
                    {
                        MessageBox.Show("Số điện thoại đã được sử dụng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

           // ket noi firebase nhung ma  doi ten bien
            FirebaseResponse res = client.Get(@"Users/" + txbUserrName.Text);
            MyUser ResUser = res.ResultAs<MyUser>();
            MyUser CurUser = new MyUser()
            {
                Username = txbUserrName.Text
            };

            if (MyUser.Search(ResUser, CurUser))
            {
                MyUser.ShowError_2();
                return;
            }
            if (txbPassword.Text != txbConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MyUser user = new MyUser()
            {
                Username = txbUserrName.Text,
                Password = ComputeSha256Hash(txbPassword.Text),
                Email = txbEmail.Text,
                Phonenumber = txbPhoneNumber.Text
            };

            SetResponse set = client.Set(@"Users/" + txbUserrName.Text, user);
            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txbUserrName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbUserrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txbcConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txbPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }




    }
}

