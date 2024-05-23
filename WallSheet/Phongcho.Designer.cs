
﻿namespace WallSheet
{
    partial class Phongcho
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
            this.btn_Option = new System.Windows.Forms.Button();
            this.btnRandom_click = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Option
            // 
            this.btn_Option.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Option.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Option.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Option.Location = new System.Drawing.Point(375, 250);
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.Size = new System.Drawing.Size(122, 46);
            this.btn_Option.TabIndex = 1;
            this.btn_Option.Text = "Option";
            this.btn_Option.UseVisualStyleBackColor = false;
            // 
            // btnRandom_click
            // 
            this.btnRandom_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandom_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom_click.Location = new System.Drawing.Point(547, 296);
            this.btnRandom_click.Name = "btnRandom_click";
            this.btnRandom_click.Size = new System.Drawing.Size(127, 46);
            this.btnRandom_click.TabIndex = 2;
            this.btnRandom_click.Text = "Random";
            this.btnRandom_click.UseVisualStyleBackColor = false;
            // 
            // BtnProfile
            // 
            this.BtnProfile.Location = new System.Drawing.Point(691, 26);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnProfile.TabIndex = 3;
            this.BtnProfile.Text = "Proflie";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // Phongcho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallSheet.Properties.Resources.cach_choi_ma_soi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.btnRandom_click);
            this.Controls.Add(this.btn_Option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Phongcho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Phongcho_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Option;
        private System.Windows.Forms.Button btnRandom_click;
        private System.Windows.Forms.Button BtnProfile;
    }

}