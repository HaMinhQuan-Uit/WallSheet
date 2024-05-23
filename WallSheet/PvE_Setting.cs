using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PvE_Setting : Form
    {
        public  string name;
        public  double x, z, m;
        public  int y, n, a;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public PvE_Setting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
            this.x = double.Parse(textBox2.Text);
            this.y = int.Parse(textBox3.Text);
            this.z = double.Parse(textBox4.Text);
            this.m = double.Parse(textBox5.Text);
            this.n = int.Parse(textBox6.Text);

            // Chuyển sang Form2 với thông tin hiện tại
            PvE pvE = new PvE(name, x, y, z, m, a, n);
            pvE.Show();
            this.Hide();
        }
    }
}
