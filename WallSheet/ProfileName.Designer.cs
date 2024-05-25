namespace WallSheet
{
    partial class ProfileName
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
            System.Windows.Forms.Button btn_Home;
            System.Windows.Forms.Button btn_Chat;
            System.Windows.Forms.Button btnSetting_Click;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend_click = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            btn_Home = new System.Windows.Forms.Button();
            btn_Chat = new System.Windows.Forms.Button();
            btnSetting_Click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            btn_Home.BackColor = System.Drawing.Color.Teal;
            btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_Home.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Home.Image = global::WallSheet.Properties.Resources.Screenshot_2024_05_23_234007;
            btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Home.Location = new System.Drawing.Point(11, 28);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new System.Drawing.Size(342, 57);
            btn_Home.TabIndex = 0;
            btn_Home.Text = "HOME";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Chat
            // 
            btn_Chat.BackColor = System.Drawing.Color.Teal;
            btn_Chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_Chat.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            btn_Chat.Image = global::WallSheet.Properties.Resources.Screenshot_2024_05_23_2344321;
            btn_Chat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Chat.Location = new System.Drawing.Point(3, 107);
            btn_Chat.Name = "btn_Chat";
            btn_Chat.Size = new System.Drawing.Size(342, 57);
            btn_Chat.TabIndex = 4;
            btn_Chat.Text = "Chat";
            btn_Chat.UseVisualStyleBackColor = false;
            // 
            // btnSetting_Click
            // 
            btnSetting_Click.BackColor = System.Drawing.Color.Teal;
            btnSetting_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnSetting_Click.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            btnSetting_Click.Image = global::WallSheet.Properties.Resources.Screenshot_2024_05_23_2344321;
            btnSetting_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting_Click.Location = new System.Drawing.Point(7, 179);
            btnSetting_Click.Name = "btnSetting_Click";
            btnSetting_Click.Size = new System.Drawing.Size(342, 57);
            btnSetting_Click.TabIndex = 5;
            btnSetting_Click.Text = "Setting";
            btnSetting_Click.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(btnSetting_Click);
            this.panel2.Controls.Add(btn_Chat);
            this.panel2.Controls.Add(btn_Home);
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 312);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WallSheet.Properties.Resources.tải_xuống__1_;
            this.pictureBox1.Location = new System.Drawing.Point(204, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnSend_click);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(929, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 574);
            this.panel3.TabIndex = 1;
            // 
            // btnSend_click
            // 
            this.btnSend_click.Image = global::WallSheet.Properties.Resources.Screenshot_2024_05_24_223448;
            this.btnSend_click.Location = new System.Drawing.Point(322, 498);
            this.btnSend_click.Name = "btnSend_click";
            this.btnSend_click.Size = new System.Drawing.Size(65, 41);
            this.btnSend_click.TabIndex = 0;
            this.btnSend_click.Click += new System.EventHandler(this.btnSend_click_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 498);
            this.textBox1.MaxLength = 327678;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 41);
            this.textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 466);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ProfileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.ClientSize = new System.Drawing.Size(1318, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileName";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ProfileName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend_click;
    }
}