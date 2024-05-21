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
    public partial class PvE : Form
    {
        public string name;
        public double x, z, m;
        public int y, n, a;

        public PvE(string name, double x, int y, double z, double m, int a, int n)
        {
            InitializeComponent();
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
            this.m = m;
            this.a = a;
            this.n = n;
            textBox1.Text = this.x.ToString();
            textBox2.Text = this.y.ToString();
            textBox3.Text = this.z.ToString();
            textBox4.Text = this.m.ToString();
            textBox5.Text = this.a.ToString();
            textBox6.Text = this.n.ToString();
            textBox7.Text = this.name;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Tạo một series mới
        chart1.Series.Add("Giá trị cổ phiếu");
        chart1.Series.Add("Số dư");

        // Đặt kiểu biểu đồ là dạng đường
        chart1.Series["Giá trị cổ phiếu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        chart1.Series["Số dư"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        // Thêm dữ liệu vào biểu đồ
        for (int i = 0; i < this.n; i++)
        {
            // Thêm điểm dữ liệu vào biểu đồ
            chart1.Series["Giá trị cổ phiếu"].Points.AddXY(i, this.x);
            chart1.Series["Số dư"].Points.AddXY(i, this.z);
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Thực hiện các thao tác khi nhấn button1
            this.a = int.Parse(textBox5.Text);
            Random random = new Random();
            this.x = random.NextDouble() * (999.99 - 0.00) + 0.00;  // Thay đổi giá trị x một cách ngẫu nhiên
            this.z = this.z - this.a * this.x;
            this.y = this.y + (int)this.a;
            this.n -= 1;
            updateUI();
            CheckWinLossCondition();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Thực hiện các thao tác khi nhấn button2
            this.a = int.Parse(textBox5.Text);
            Random random = new Random();
            this.x = random.NextDouble() * (999.99 - 0.00) + 0.00;  // Thay đổi giá trị x một cách ngẫu nhiên
            this.z = this.z + this.a * this.x;
            this.y = this.y - this.a;
            this.n -= 1;
            updateUI();
            CheckWinLossCondition();
        }
        private void updateUI()
        {
            textBox1.Text = this.x.ToString();
            textBox2.Text = this.y.ToString();
            textBox3.Text = this.z.ToString();
            textBox4.Text = this.m.ToString();
            textBox5.Text = this.a.ToString();
            textBox6.Text = this.n.ToString();
            textBox7.Text = this.name;
        }
        private void CheckWinLossCondition()
        {
            if (this.z >= this.m)
            {
                MessageBox.Show("Victory! Z is greater than or equal to M.");
            }
            else if (this.n == 0)
            {
                MessageBox.Show("Defeat! N is zero.");
            }
        }

        private void checkWinLose()
        {
            if (this.z >= this.m)
            {
                MessageBox.Show("Victory");
            }
            else if (this.y <= 0 && this.z <= 0)
            {
                MessageBox.Show("Defeat");
            }
            else if (this.n == 0)
            {
                MessageBox.Show("Defeat");
            }
        }
   
    }
}
