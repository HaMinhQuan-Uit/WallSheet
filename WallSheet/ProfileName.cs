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
    public partial class ProfileName : Form
    {
        public ProfileName()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "UYaSCRpXgQFANuKeFHlhq5l6DZLMcmtNXkZjL1nJ",
            BasePath = "https://masoi-558cc-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void label2_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Users/" + txbName.Text);
            MyUser ResUser = res.ResultAs<MyUser>();

            MyUser CurUser = new MyUser()
            {
                Username = txbName.Text,

            };
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

            Phongcho phongcho = new Phongcho();
            this.Hide();
            phongcho.Show();
        }
    }
}

