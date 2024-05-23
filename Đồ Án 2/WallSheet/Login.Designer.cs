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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin_click = new System.Windows.Forms.Button();
            this.btnResgiter_click = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wall Sheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // btnLogin_click
            // 
            this.btnLogin_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_click.Location = new System.Drawing.Point(25, 338);
            this.btnLogin_click.Name = "btnLogin_click";
            this.btnLogin_click.Size = new System.Drawing.Size(99, 43);
            this.btnLogin_click.TabIndex = 3;
            this.btnLogin_click.Text = "Login";
            this.btnLogin_click.UseVisualStyleBackColor = true;
            this.btnLogin_click.Click += new System.EventHandler(this.btnLogin_click_Click);
            // 
            // btnResgiter_click
            // 
            this.btnResgiter_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResgiter_click.Location = new System.Drawing.Point(162, 338);
            this.btnResgiter_click.Name = "btnResgiter_click";
            this.btnResgiter_click.Size = new System.Drawing.Size(99, 43);
            this.btnResgiter_click.TabIndex = 4;
            this.btnResgiter_click.Text = "Register";
            this.btnResgiter_click.UseVisualStyleBackColor = true;
            this.btnResgiter_click.Click += new System.EventHandler(this.btnResgiter_click_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(36, 202);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(225, 22);
            this.txbUserName.TabIndex = 5;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(36, 274);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(225, 22);
            this.txbPassword.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.btnResgiter_click);
            this.Controls.Add(this.btnLogin_click);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin_click;
        private System.Windows.Forms.Button btnResgiter_click;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
    }
}

