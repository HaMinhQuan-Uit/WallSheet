using Firebase_Project;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallSheet
{
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;



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
                string.IsNullOrWhiteSpace(txbEmail.Text))
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
                Email = txbEmail.Text
            };

            SetResponse set = client.Set(@"Users/" + txbUserrName.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txbUserrName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

