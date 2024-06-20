namespace WallSheet
{
    // ResetPassword.Designer.cs (mã này sẽ được sinh tự động nếu bạn thêm điều khiển qua Designer)
    partial class ResetPassword
    {
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonUpdatePassword;

        private void InitializeComponent()
        {
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(178, 15);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(183, 22);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(13, 47);
            this.buttonUpdatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(350, 28);
            this.buttonUpdatePassword.TabIndex = 1;
            this.buttonUpdatePassword.Text = "Update Password";
            this.buttonUpdatePassword.UseVisualStyleBackColor = false;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NEW PASSWORD";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.ClientSize = new System.Drawing.Size(379, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }

}