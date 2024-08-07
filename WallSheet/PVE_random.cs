﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WallSheet
{
    public partial class PVE_random : Form
    {
        private Random random = new Random();
        private List<KeyValuePair<int, double>> dataPoints = new List<KeyValuePair<int, double>>(); // Add this line
        private int turn = 1; // Add this line

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
            double price = (double)(random.NextDouble() * (99.99 - 0.09) + 0.09);
            double budget = (double)(random.NextDouble() * (1000000 - 0.1) + 0.1);

            // Generate a target value that is up to 3 times more than the budget
            double target = budget * (random.NextDouble() * 2 + 1); // This will give a value between 1 and 3 times the budget

            int quantity = 0; // Set the starting value to 0

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
            Random random = new Random();
            double x = random.NextDouble() * (200 - 1) + 1; // This will give a value between 1% and 200%
            double z = double.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);
            if (y - a >= 0)
            {
                z = z + a * x;
                y = y - a;
                m--;

                Price.Text = x.ToString();
                Budget.Text = z.ToString();
                Quantity.Text = y.ToString();
                Turn.Text = m.ToString();
                dataPoints.Add(new KeyValuePair<int, double>(turn, z));
                UpdateChart(dataPoints);
                turn++;
                CheckWinLose(z, m);
            }
            else
            {
                MessageBox.Show("Cannot sell more than the current quantity.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            Random random = new Random();
            double x = random.NextDouble() * (200 - 1) + 1; //give a value between 1% and 200%

            double z = double.Parse(Budget.Text);
            int y = int.Parse(Quantity.Text);
            int m = int.Parse(Turn.Text);

                z = z - a * x;
                y = y + a;
                m--;

                Price.Text = x.ToString();
                Budget.Text = z.ToString();
                Quantity.Text = y.ToString();
                Turn.Text = m.ToString();
                dataPoints.Add(new KeyValuePair<int, double>(turn, z));
                UpdateChart(dataPoints);
                turn++;
                CheckWinLose(z, m);
            
            
        }
        private void UpdateChart(List<KeyValuePair<int, double>> dataPoints)
        {
            // Create a new series.
            var series = new Series("Budget")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            // Add each data point to the series.
            foreach (var dataPoint in dataPoints)
            {
                series.Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            // Clear any existing series.
            chart1.Series.Clear();

            // Add the new series.
            chart1.Series.Add(series);

            // Set the chart area's X and Y axis titles.
            chart1.ChartAreas[0].AxisX.Title = "Turn";
            chart1.ChartAreas[0].AxisY.Title = "Budget";

            // Set the maximum value of the Y axis to the target value.
            double target = double.Parse(Target.Text);
            chart1.ChartAreas[0].AxisY.Maximum = target;

            // Force the chart to redraw.
            chart1.Invalidate();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void CheckWinLose(double budget, int turn)
        {
            double target = double.Parse(Target.Text);

            if (budget >= target)
            {
                // Win condition
                FormWin winForm = new FormWin();
                winForm.Show();
                this.Close();
            }
            else if (turn == 0)
            {
                // Lose condition
                FormLose loseForm = new FormLose();
                loseForm.Show();
                this.Close();
            }
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            // func to show lose form
            FormLose loseForm = new FormLose();
            loseForm.Show();
            this.Close();
        }

        private void Budget_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
