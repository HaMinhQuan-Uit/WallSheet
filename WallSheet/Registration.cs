using Firebase_Project;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace WallSheet
{

    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
            txbPhoneNumber.KeyPress += txbPhoneNumber_KeyPress;
            txbPhoneNumber.KeyPress += txbPhoneNumber_KeyPress;
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

        private void email(object sender, CancelEventArgs e)
        {
            // Regular expression for email validation
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";

            if (!Regex.IsMatch(txbEmail.Text, pattern))
            {
                MessageBox.Show("Vui lòng nhập đúng @gmail.com");
            }
        }
        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
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
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUserrName.Text) ||
                string.IsNullOrWhiteSpace(txbPassword.Text) ||
                string.IsNullOrWhiteSpace(txbEmail.Text) ||
                string.IsNullOrWhiteSpace(txbPhoneNumber.Text))

            {

                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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

            MyUser user = new MyUser()
            {
                Username = txbUserrName.Text,
                Password = txbPassword.Text,
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

