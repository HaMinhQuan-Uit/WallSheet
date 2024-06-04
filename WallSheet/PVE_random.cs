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
    public partial class PVE_random : Form
    {
        private Random random = new Random();
        public PVE_random()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PVE_random_Load(object sender, EventArgs e)
        {

                // Generate random values
                int turn = random.Next(10, 31);
                decimal price = (decimal)(random.NextDouble() * (99999.99 - 0.09) + 0.09);
                decimal budget = (decimal)(random.NextDouble() * (1000000 - 0.1) + 0.1);
                decimal target = (decimal)(random.NextDouble() * (10000000 - 1000) + 1000);
                int quantity = random.Next(1, 10001);

            // Ensure target is always more than budget
            while (target <= budget)
                {
                    target = (decimal)(random.NextDouble() * (10000000 - 1000) + 1000);
                }

                // Set the values to the textboxes
                Turn.Text = turn.ToString();
                Price.Text = price.ToString("F2"); // F2 for 2 decimal places
                Budget.Text = budget.ToString("F2"); // F2 for 2 decimal places
                Target.Text = target.ToString("F2"); // F2 for 2 decimal places
                Quantity.Text = quantity.ToString(); // Set Quantity


        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
        }
        

        private void Turn_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int x = random.Next();
            int z = int.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);

            z = z + a * x;
            y = y - a;
            m--;

            Price.Text = x.ToString();
            Budget.Text = z.ToString();
            Quantity.Text = y.ToString();
            Turn.Text = m.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int x = random.Next();
            int z = int.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);

            z = z - a * x;
            y = y + a;
            m--;

            Price.Text = x.ToString();
            Budget.Text = z.ToString();
            Quantity.Text = y.ToString();
            Turn.Text = m.ToString();
        }

    }
}
