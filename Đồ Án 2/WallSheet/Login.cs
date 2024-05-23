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
namespace WallSheet
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };


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

            MyUser CurUser = new MyUser()
            {
                Username = txbUserName.Text,
                Password = txbPassword.Text,

            };

            if (MyUser.IsEqual(ResUser, CurUser) == true)
            {
                Phongcho phongcho = new Phongcho();
                    phongcho.Hide();
                phongcho.Show();
            }
            else
            {
                MyUser.ShowError();

            }
        }

        private void btnResgiter_click_Click(object sender, EventArgs e)
        {
             formRegistration  reg = new formRegistration();
            reg.Hide();
            reg.Show();

        }   

       
       
    }
}
