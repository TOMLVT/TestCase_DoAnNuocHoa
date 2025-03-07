namespace TestCase_DoAnNuocHoa
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_manHinhChinh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hoaDonKhachHang1 = new TestCase_DoAnNuocHoa.UserForm.HoaDonKhachHang();
            this.manHinhChinh2 = new TestCase_DoAnNuocHoa.UserForm.ManHinhChinh();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_manHinhChinh);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 890);
            this.panel1.TabIndex = 0;
            // 
            // btn_manHinhChinh
            // 
            this.btn_manHinhChinh.Location = new System.Drawing.Point(43, 227);
            this.btn_manHinhChinh.Name = "btn_manHinhChinh";
            this.btn_manHinhChinh.Size = new System.Drawing.Size(249, 55);
            this.btn_manHinhChinh.TabIndex = 2;
            this.btn_manHinhChinh.Text = "Màn hình chính";
            this.btn_manHinhChinh.UseVisualStyleBackColor = true;
            this.btn_manHinhChinh.Click += new System.EventHandler(this.btn_manHinhChinh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "Xem hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hoaDonKhachHang1
            // 
            this.hoaDonKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoaDonKhachHang1.Location = new System.Drawing.Point(336, 0);
            this.hoaDonKhachHang1.Name = "hoaDonKhachHang1";
            this.hoaDonKhachHang1.Size = new System.Drawing.Size(1105, 890);
            this.hoaDonKhachHang1.TabIndex = 1;
            // 
            // manHinhChinh2
            // 
            this.manHinhChinh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manHinhChinh2.Location = new System.Drawing.Point(336, 0);
            this.manHinhChinh2.Name = "manHinhChinh2";
            this.manHinhChinh2.Size = new System.Drawing.Size(1105, 890);
            this.manHinhChinh2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1441, 890);
            this.Controls.Add(this.manHinhChinh2);
            this.Controls.Add(this.hoaDonKhachHang1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_manHinhChinh;
        private System.Windows.Forms.Button button2;
        private UserForm.ManHinhChinh manHinhChinh1;
        private UserForm.HoaDonKhachHang hoaDonKhachHang1;
        private UserForm.ManHinhChinh manHinhChinh2;
    }
}

