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
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(16, 15);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(345, 22);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Location = new System.Drawing.Point(263, 47);
            this.buttonUpdatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdatePassword.TabIndex = 1;
            this.buttonUpdatePassword.Text = "Update Password";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 75);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

}