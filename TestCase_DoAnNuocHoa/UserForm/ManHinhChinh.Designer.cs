namespace TestCase_DoAnNuocHoa.UserForm
{
    partial class ManHinhChinh
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DiChuyenGioHang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_LoaiKH = new System.Windows.Forms.ComboBox();
            this.data_sanPham = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.listView_SanPham = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGiamGiaLoaiKH = new System.Windows.Forms.Label();
            this.lblGiamGiaSanPham = new System.Windows.Forms.Label();
            this.txtTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoTienGiam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_sanPham)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DiChuyenGioHang);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(43, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 473);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // btn_DiChuyenGioHang
            // 
            this.btn_DiChuyenGioHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_DiChuyenGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiChuyenGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiChuyenGioHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DiChuyenGioHang.Location = new System.Drawing.Point(421, 386);
            this.btn_DiChuyenGioHang.Name = "btn_DiChuyenGioHang";
            this.btn_DiChuyenGioHang.Size = new System.Drawing.Size(342, 64);
            this.btn_DiChuyenGioHang.TabIndex = 142;
            this.btn_DiChuyenGioHang.Text = "Chuyển sang giỏ hàng";
            this.btn_DiChuyenGioHang.UseVisualStyleBackColor = false;
            this.btn_DiChuyenGioHang.Click += new System.EventHandler(this.btn_DiChuyenGioHang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_LoaiKH);
            this.groupBox3.Controls.Add(this.data_sanPham);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_NhanVien);
            this.groupBox3.Controls.Add(this.txtSanPham);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(18, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1213, 359);
            this.groupBox3.TabIndex = 140;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm ";
            // 
            // cb_LoaiKH
            // 
            this.cb_LoaiKH.FormattingEnabled = true;
            this.cb_LoaiKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_LoaiKH.Location = new System.Drawing.Point(893, 308);
            this.cb_LoaiKH.Name = "cb_LoaiKH";
            this.cb_LoaiKH.Size = new System.Drawing.Size(245, 24);
            this.cb_LoaiKH.TabIndex = 31;
            // 
            // data_sanPham
            // 
            this.data_sanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_sanPham.BackgroundColor = System.Drawing.Color.White;
            this.data_sanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sanPham.Location = new System.Drawing.Point(19, 24);
            this.data_sanPham.Name = "data_sanPham";
            this.data_sanPham.RowHeadersWidth = 51;
            this.data_sanPham.RowTemplate.Height = 24;
            this.data_sanPham.Size = new System.Drawing.Size(836, 329);
            this.data_sanPham.TabIndex = 0;
            this.data_sanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_sanPham_CellClick);
            this.data_sanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_sanPham_CellFormatting);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(893, 142);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(245, 41);
            this.txtSoLuong.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(890, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sản phẩm đang chọn";
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.Enabled = false;
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(893, 237);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(245, 24);
            this.cb_NhanVien.TabIndex = 33;
            // 
            // txtSanPham
            // 
            this.txtSanPham.Location = new System.Drawing.Point(893, 56);
            this.txtSanPham.Multiline = true;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(245, 41);
            this.txtSanPham.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(890, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Chọn loại khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(890, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhập số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(890, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Chọn nhân viên";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Green;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ThanhToan.Location = new System.Drawing.Point(814, 303);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(417, 40);
            this.btn_ThanhToan.TabIndex = 139;
            this.btn_ThanhToan.Text = "Xác nhận thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Xoa);
            this.groupBox4.Controls.Add(this.listView_SanPham);
            this.groupBox4.Location = new System.Drawing.Point(402, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 262);
            this.groupBox4.TabIndex = 141;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giỏ hàng đã chọn";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.Location = new System.Drawing.Point(19, 220);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(342, 36);
            this.btn_Xoa.TabIndex = 143;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // listView_SanPham
            // 
            this.listView_SanPham.HideSelection = false;
            this.listView_SanPham.Location = new System.Drawing.Point(15, 33);
            this.listView_SanPham.Name = "listView_SanPham";
            this.listView_SanPham.Size = new System.Drawing.Size(346, 174);
            this.listView_SanPham.TabIndex = 0;
            this.listView_SanPham.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGiamGiaLoaiKH);
            this.groupBox1.Controls.Add(this.lblGiamGiaSanPham);
            this.groupBox1.Controls.Add(this.txtTongTienThanhToan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSoTienGiam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.date_NgaySinh);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_ThanhToan);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(43, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 365);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGiamGiaLoaiKH
            // 
            this.lblGiamGiaLoaiKH.AutoSize = true;
            this.lblGiamGiaLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGiaLoaiKH.Location = new System.Drawing.Point(811, 72);
            this.lblGiamGiaLoaiKH.Name = "lblGiamGiaLoaiKH";
            this.lblGiamGiaLoaiKH.Size = new System.Drawing.Size(72, 16);
            this.lblGiamGiaLoaiKH.TabIndex = 147;
            this.lblGiamGiaLoaiKH.Text = "Thông tin 2";
            // 
            // lblGiamGiaSanPham
            // 
            this.lblGiamGiaSanPham.AutoSize = true;
            this.lblGiamGiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGiaSanPham.Location = new System.Drawing.Point(811, 37);
            this.lblGiamGiaSanPham.Name = "lblGiamGiaSanPham";
            this.lblGiamGiaSanPham.Size = new System.Drawing.Size(72, 16);
            this.lblGiamGiaSanPham.TabIndex = 146;
            this.lblGiamGiaSanPham.Text = "Thông tin 1";
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(814, 236);
            this.txtTongTienThanhToan.Multiline = true;
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(417, 41);
            this.txtTongTienThanhToan.TabIndex = 145;
            this.txtTongTienThanhToan.TextChanged += new System.EventHandler(this.txtTongTienThanhToan_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(809, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 144;
            this.label10.Text = "Tổng tiền thanh toán";
            // 
            // txtSoTienGiam
            // 
            this.txtSoTienGiam.Location = new System.Drawing.Point(814, 146);
            this.txtSoTienGiam.Multiline = true;
            this.txtSoTienGiam.Name = "txtSoTienGiam";
            this.txtSoTienGiam.Size = new System.Drawing.Size(417, 41);
            this.txtSoTienGiam.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(811, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 142;
            this.label9.Text = "Số tiền giảm";
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(132, 277);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(245, 22);
            this.date_NgaySinh.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Chọn ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 209);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 41);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhập địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(132, 154);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 41);
            this.txtSDT.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập SDT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 100);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 41);
            this.txtHoTen.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập họ tên";
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "ManHinhChinh";
            this.Size = new System.Drawing.Size(1315, 929);
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_sanPham)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DiChuyenGioHang;
        private System.Windows.Forms.ListView listView_SanPham;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data_sanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_LoaiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTienGiam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTienThanhToan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGiamGiaLoaiKH;
        private System.Windows.Forms.Label lblGiamGiaSanPham;
    }
}
