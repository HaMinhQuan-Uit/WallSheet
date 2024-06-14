namespace WallSheet
{
    partial class formRegistration
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUserrName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LabelPhone = new System.Windows.Forms.Label();
            this.txbConfirmPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // txbUserrName
            // 
            this.txbUserrName.CausesValidation = false;
            this.txbUserrName.Location = new System.Drawing.Point(27, 203);
            this.txbUserrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserrName.Name = "txbUserrName";
            this.txbUserrName.Size = new System.Drawing.Size(284, 22);
            this.txbUserrName.TabIndex = 5;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(29, 281);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(281, 22);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(33, 417);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(281, 22);
            this.txbEmail.TabIndex = 8;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(362, 374);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(140, 39);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(521, 374);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 39);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 75);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wall Sheet";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(27, 479);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(281, 22);
            this.txbPhoneNumber.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPhone.Location = new System.Drawing.Point(24, 457);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(120, 18);
            this.LabelPhone.TabIndex = 15;
            this.LabelPhone.Text = "PhoneNumber:";
            // 
            // txbConfirmPass
            // 
            this.txbConfirmPass.Location = new System.Drawing.Point(27, 347);
            this.txbConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbConfirmPass.Name = "txbConfirmPass";
            this.txbConfirmPass.PasswordChar = '*';
            this.txbConfirmPass.Size = new System.Drawing.Size(281, 22);
            this.txbConfirmPass.TabIndex = 16;
            this.txbConfirmPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(30, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "ConfirmPassWord";
            // 
            // formRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbConfirmPass);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserrName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUserrName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox txbConfirmPass;
        private System.Windows.Forms.Label label6;
    }
}