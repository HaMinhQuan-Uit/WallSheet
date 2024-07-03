namespace WallSheet
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnResgiter_click = new System.Windows.Forms.Button();
            this.btnLogin_click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wall Street";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(58, 277);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(279, 27);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnResgiter_click
            // 
            this.btnResgiter_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResgiter_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResgiter_click.Location = new System.Drawing.Point(187, 356);
            this.btnResgiter_click.Name = "btnResgiter_click";
            this.btnResgiter_click.Size = new System.Drawing.Size(150, 43);
            this.btnResgiter_click.TabIndex = 4;
            this.btnResgiter_click.Text = "Đăng Ký";
            this.btnResgiter_click.UseVisualStyleBackColor = false;
            this.btnResgiter_click.Click += new System.EventHandler(this.btnResgiter_click_Click);
            // 
            // btnLogin_click
            // 
            this.btnLogin_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_click.Location = new System.Drawing.Point(25, 356);
            this.btnLogin_click.Name = "btnLogin_click";
            this.btnLogin_click.Size = new System.Drawing.Size(156, 43);
            this.btnLogin_click.TabIndex = 3;
            this.btnLogin_click.Text = "Đăng Nhập";
            this.btnLogin_click.UseVisualStyleBackColor = false;
            this.btnLogin_click.Click += new System.EventHandler(this.btnLogin_click_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(45, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 75);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(208, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quên Mật Khẩu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WallSheet.Properties.Resources.Screenshot_2024_06_15_0906591;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(12, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WallSheet.Properties.Resources.Screenshot_2024_06_15_091113;
            this.button2.Location = new System.Drawing.Point(12, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(58, 214);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(279, 27);
            this.txbUserName.TabIndex = 11;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin_click);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnResgiter_click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnResgiter_click;
        private System.Windows.Forms.Button btnLogin_click;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbUserName;
    }
}

