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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnSetting_Click;
            this.btnPVE_click = new System.Windows.Forms.Button();
            this.btnPVP_Click = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            btnSetting_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetting_Click
            // 
            btnSetting_Click.BackColor = System.Drawing.Color.Transparent;
            btnSetting_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnSetting_Click.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSetting_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSetting_Click.Location = new System.Drawing.Point(-2, 466);
            btnSetting_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSetting_Click.Name = "btnSetting_Click";
            btnSetting_Click.Size = new System.Drawing.Size(217, 31);
            btnSetting_Click.TabIndex = 5;
            btnSetting_Click.Text = "ĐĂNG XUẤT";
            btnSetting_Click.UseVisualStyleBackColor = false;
            btnSetting_Click.Click += new System.EventHandler(this.btnSetting_Click_Click);
            // 
            // btnPVE_click
            // 
            this.btnPVE_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPVE_click.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVE_click.Location = new System.Drawing.Point(224, 216);
            this.btnPVE_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPVE_click.Name = "btnPVE_click";
            this.btnPVE_click.Size = new System.Drawing.Size(278, 120);
            this.btnPVE_click.TabIndex = 2;
            this.btnPVE_click.Text = "Chơi Với Máy";
            this.btnPVE_click.UseVisualStyleBackColor = false;
            this.btnPVE_click.Click += new System.EventHandler(this.btnPVE_click_Click);
            // 
            // btnPVP_Click
            // 
            this.btnPVP_Click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPVP_Click.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPVP_Click.Location = new System.Drawing.Point(553, 216);
            this.btnPVP_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPVP_Click.Name = "btnPVP_Click";
            this.btnPVP_Click.Size = new System.Drawing.Size(278, 120);
            this.btnPVP_Click.TabIndex = 3;
            this.btnPVP_Click.Text = "Chơi với người";
            this.btnPVP_Click.UseVisualStyleBackColor = false;
            this.btnPVP_Click.Click += new System.EventHandler(this.btnPVP_Click_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(867, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.màn_đêm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPVP_Click);
            this.Controls.Add(this.btnPVE_click);
            this.Controls.Add(btnSetting_Click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ProfileName_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPVE_click;
        private System.Windows.Forms.Button btnPVP_Click;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}