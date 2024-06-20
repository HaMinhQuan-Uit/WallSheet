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

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSend_click_Click(object sender, EventArgs e)
        {

        }

        private void ProfileName_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += ProfileName_KeyDown;
        }
        private void ProfileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // btnSend_click.PerformClick();
            }
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {


        }
        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private bool check;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panel1.Width += 10;
               // if(panel1.Size = panel1.MaximumSize)
                {
                    pictureBox1.Left += 200;
                }
            }
        }

        private void btnPVE_click_Click(object sender, EventArgs e)
        {
            //func to open PVE_random
            PVE_random pve = new PVE_random();
            pve.Show();
            this.Hide();
        }

        private void btnPVP_Click_Click(object sender, EventArgs e)
        {
            //func to open PVP_select
            PVP_select pvp = new PVP_select();
            pvp.Show();
            this.Hide();
        }

        private void btnSetting_Click_Click(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Text = " LogOut ";
            btn.AutoSize = true;
            btn.Font = new Font("Arial", 12);
            btn.Location = new Point(panel4.Width - btn.Width - 10, panel4.Height - btn.Height - 10);
            btn.BackColor = Color.BlueViolet;
            btn.Click += Btn_LogOut_Click;
            panel4.Controls.Add(btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog.Title = "Chọn ảnh đại diện";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}

