namespace TestCase_DoAnNuocHoa.UserForm
{
    partial class HoaDonKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.data_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN KHÁCH HÀNG";
            // 
            // data_HoaDon
            // 
            this.data_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HoaDon.Location = new System.Drawing.Point(29, 86);
            this.data_HoaDon.Name = "data_HoaDon";
            this.data_HoaDon.RowHeadersWidth = 51;
            this.data_HoaDon.RowTemplate.Height = 24;
            this.data_HoaDon.Size = new System.Drawing.Size(1221, 425);
            this.data_HoaDon.TabIndex = 2;
            this.data_HoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_HoaDon_CellFormatting);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_InHoaDon.Location = new System.Drawing.Point(464, 532);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(342, 64);
            this.btn_InHoaDon.TabIndex = 143;
            this.btn_InHoaDon.Text = "IN HÓA ĐƠN";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // HoaDonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.data_HoaDon);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonKhachHang";
            this.Size = new System.Drawing.Size(1278, 900);
            ((System.ComponentModel.ISupportInitialize)(this.data_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_HoaDon;
        private System.Windows.Forms.Button btn_InHoaDon;
    }
}
