﻿namespace TestCase_DoAnNuocHoa
{
    partial class NhanVien
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
            this.manHinhChinh1 = new TestCase_DoAnNuocHoa.UserForm.ManHinhChinh();
            this.SuspendLayout();
            // 
            // manHinhChinh1
            // 
            this.manHinhChinh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manHinhChinh1.Location = new System.Drawing.Point(0, 0);
            this.manHinhChinh1.Name = "manHinhChinh1";
            this.manHinhChinh1.Size = new System.Drawing.Size(1391, 932);
            this.manHinhChinh1.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 932);
            this.Controls.Add(this.manHinhChinh1);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private UserForm.ManHinhChinh manHinhChinh1;
    }
}