﻿namespace WallSheet
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtChatLog = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.TextBox();
            this.Budget = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.hiddenPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChatLog
            // 
            this.txtChatLog.Location = new System.Drawing.Point(26, 334);
            this.txtChatLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChatLog.Multiline = true;
            this.txtChatLog.Name = "txtChatLog";
            this.txtChatLog.Size = new System.Drawing.Size(270, 155);
            this.txtChatLog.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(26, 493);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(217, 37);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(247, 493);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 37);
            this.btnSend.TabIndex = 3;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(158, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 24);
            this.button4.TabIndex = 31;
            this.button4.Text = "Forfeit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(300, 1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(508, 547);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Turn";
            // 
            // Turn
            // 
            this.Turn.Location = new System.Drawing.Point(53, 5);
            this.Turn.Name = "Turn";
            this.Turn.ReadOnly = true;
            this.Turn.Size = new System.Drawing.Size(100, 20);
            this.Turn.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 26;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 20);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Target
            // 
            this.Target.Location = new System.Drawing.Point(140, 93);
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            this.Target.Size = new System.Drawing.Size(100, 20);
            this.Target.TabIndex = 19;
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(24, 93);
            this.Budget.Name = "Budget";
            this.Budget.ReadOnly = true;
            this.Budget.Size = new System.Drawing.Size(100, 20);
            this.Budget.TabIndex = 18;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(140, 55);
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 17;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(24, 55);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 16;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // hiddenPrice
            // 
            this.hiddenPrice.Location = new System.Drawing.Point(26, 182);
            this.hiddenPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hiddenPrice.Name = "hiddenPrice";
            this.hiddenPrice.ReadOnly = true;
            this.hiddenPrice.Size = new System.Drawing.Size(76, 20);
            this.hiddenPrice.TabIndex = 32;
            this.hiddenPrice.Visible = false;
            this.hiddenPrice.TextChanged += new System.EventHandler(this.hiddenPrice_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 547);
            this.Controls.Add(this.hiddenPrice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtChatLog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChatLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Turn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Target;
        private System.Windows.Forms.TextBox Budget;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox hiddenPrice;
    }
}