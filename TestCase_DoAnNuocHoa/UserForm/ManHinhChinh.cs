using BLL.BLL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCase_DoAnNuocHoa.UserForm
{
    public partial class ManHinhChinh : UserControl
    {
        Database db = new Database();

        private BLL_SanPhamNuocHoa nuocHoaBLL;

        private Timer LoaiKhachHangTimer, NhanVienTimer;

        public ManHinhChinh()
        {
            InitializeComponent();

            nuocHoaBLL = new BLL_SanPhamNuocHoa(new Database().GetDatabase());

            NhanVienTimer = new Timer();
            NhanVienTimer.Interval = 1000;
            NhanVienTimer.Tick += (s, e) => LoadDataChonNhanVien();
            NhanVienTimer.Start();


            // Load dữ liệu vào combobox 
            LoaiKhachHangTimer = new Timer();
            LoaiKhachHangTimer.Interval = 1000;
            LoaiKhachHangTimer.Tick += (s, e) => LoadDataLoaiKhachHang();
            LoaiKhachHangTimer.Start();

            LoadDataNuocHoa();


        }
        
        public void LoadDataNuocHoa()
        {
            data_sanPham.DataSource = nuocHoaBLL.GetDataNuocHoa();
        }
        public void LoadDataLoaiKhachHang()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT ID_LOAIKHACHHANG, TENLOAI FROM LOAIKHACHHANG";


            var selectedValue = cb_LoaiKH.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_LoaiKH.DisplayMember = "TENLOAI";
            cb_LoaiKH.ValueMember = "ID_LOAIKHACHHANG";
            cb_LoaiKH.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_LOAIKHACHHANG"].ToString() == selectedValue.ToString()))
            {
                cb_LoaiKH.SelectedValue = selectedValue;
            }
            else
            {

                cb_LoaiKH.SelectedIndex = 0;
            }
        }

        private void data_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || data_sanPham.Rows[e.RowIndex] == null)
            {
                MessageBox.Show("Vui lòng chọn mục thay đổi thông tin !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow rowst = data_sanPham.Rows[e.RowIndex];

                txtSanPham.Text = rowst.Cells["TENSANPHAM"]?.Value?.ToString() ?? string.Empty;

            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DiChuyenGioHang_Click(object sender, EventArgs e)
        {
            if (data_sanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dòng được chọn trong DataGridView
            DataGridViewRow selectedRow = data_sanPham.CurrentRow;

            // Lấy thông tin sản phẩm từ DataGridView
            string productName = selectedRow.Cells["TENSANPHAM"].Value.ToString();
            decimal donGia = Convert.ToDecimal(selectedRow.Cells["DONGIA"].Value);
            decimal giamGia = Convert.ToDecimal(selectedRow.Cells["GIAMGIA"].Value);

            // Kiểm tra số lượng hợp lệ
            if (!int.TryParse(txtSoLuong.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính toán giảm giá & tổng tiền sau giảm
            decimal soTienGiam = (donGia * giamGia / 100) * quantity;
            decimal thanhTien = (donGia - (donGia * giamGia / 100)) * quantity;

            // Kiểm tra xem sản phẩm đã có trong ListView chưa
            foreach (ListViewItem item in listView_SanPham.Items)
            {
                if (item.SubItems[0].Text == productName) // Nếu sản phẩm đã tồn tại
                {
                    int currentQuantity = int.Parse(item.SubItems[1].Text);
                    decimal currentSoTienGiam = Convert.ToDecimal(item.SubItems[4].Text.Replace(",", ""));
                    decimal currentThanhTien = Convert.ToDecimal(item.SubItems[5].Text.Replace(",", ""));

                    // Cập nhật số lượng, giảm giá và tổng tiền
                    item.SubItems[1].Text = (currentQuantity + quantity).ToString();
                    item.SubItems[4].Text = (currentSoTienGiam + soTienGiam).ToString("N0");
                    item.SubItems[5].Text = (currentThanhTien + thanhTien).ToString("N0");

                    // Cập nhật tổng tiền trong giỏ hàng
                    CapNhatTongTien();
                    return;
                }
            }

            // Nếu sản phẩm chưa có trong giỏ hàng, thêm mới vào ListView
            ListViewItem newItem = new ListViewItem(productName);
            newItem.SubItems.Add(quantity.ToString());        // Số lượng
            newItem.SubItems.Add(donGia.ToString("N0"));      // Giá gốc
            newItem.SubItems.Add(giamGia.ToString() + "%");   // Giảm giá %
            newItem.SubItems.Add(soTienGiam.ToString("N0"));  // Tiền giảm giá
            newItem.SubItems.Add(thanhTien.ToString("N0"));   // Thành tiền sau giảm

            listView_SanPham.Items.Add(newItem);

            // Cập nhật tổng tiền trong giỏ hàng
            CapNhatTongTien();
        }
        private void CapNhatTongTien()
        {
            decimal tongGiamGia = 0;
            decimal tongThanhTien = 0;

            foreach (ListViewItem item in listView_SanPham.Items)
            {
                tongGiamGia += Convert.ToDecimal(item.SubItems[4].Text.Replace(",", ""));
                tongThanhTien += Convert.ToDecimal(item.SubItems[5].Text.Replace(",", ""));
            }

            decimal phanTramGiamGia = LayGiamGiaTuLoaiKhachHang(Convert.ToInt32(cb_LoaiKH.SelectedValue));

            // 📌 Tính tổng tiền giảm giá theo loại khách hàng
            decimal tienGiamGiaLoaiKH = tongThanhTien * (phanTramGiamGia / 100);


            tongGiamGia += tienGiamGiaLoaiKH;
            txtSoTienGiam.Text = tongGiamGia.ToString("N0");
            txtTongTienThanhToan.Text = tongThanhTien.ToString("N0");
        }
        private decimal LayGiamGiaTuLoaiKhachHang(int idLoaiKH)
        {
            decimal giamGia = 0;

            using (SqlConnection conn = new SqlConnection(db.GetDatabase()))
            {
                conn.Open();
                string query = "SELECT GIAMGIA FROM LOAIKHACHHANG WHERE ID_LOAIKHACHHANG = @IDLoaiKH";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDLoaiKH", idLoaiKH);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    giamGia = Convert.ToDecimal(result);
                }
            }

            return giamGia;
        }


        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            listView_SanPham.View = View.Details; // Hiển thị dạng bảng
            listView_SanPham.FullRowSelect = true; // Chọn toàn bộ hàng
            listView_SanPham.GridLines = true; // Hiển thị đường kẻ
            listView_SanPham.Columns.Add("Tên sản phẩm", 200);
            listView_SanPham.Columns.Add("Số lượng", 100);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listView_SanPham.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView_SanPham.SelectedItems)
                {
                    listView_SanPham.Items.Remove(item);
                }
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTongTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            string input = txtTongTienThanhToan.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (decimal.TryParse(input, out decimal mucLuong))
            {

                txtTongTienThanhToan.Text = string.Format("{0:N0} VND", mucLuong);
                txtTongTienThanhToan.SelectionStart = txtTongTienThanhToan.Text.Length;
            }
        }

        private void data_sanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_sanPham.Columns[e.ColumnIndex].Name == "DONGIA" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.GetDatabase()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1️⃣ Thêm khách hàng vào bảng KHACHHANG nếu chưa có
                    string insertKhachHangQuery = @"
                INSERT INTO KHACHHANG (HOTEN, NGAYSINH, DIACHI, SDT, ID_LOAIKHACHHANG) 
                VALUES (@HoTen, @NgaySinh, @DiaChi, @SDT, @LoaiKH);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdKhachHang = new SqlCommand(insertKhachHangQuery, conn, transaction);
                    cmdKhachHang.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmdKhachHang.Parameters.AddWithValue("@NgaySinh", date_NgaySinh.Value);
                    cmdKhachHang.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    cmdKhachHang.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmdKhachHang.Parameters.AddWithValue("@LoaiKH", Convert.ToInt32(cb_LoaiKH.SelectedValue));

                    int idKhachHang = Convert.ToInt32(cmdKhachHang.ExecuteScalar());

                    // 2️⃣ Tổng hợp dữ liệu từ giỏ hàng
                    string danhSachSanPham = "";
                    int tongSoLuong = 0;
                    decimal tongTien = 0;

                    foreach (ListViewItem item in listView_SanPham.Items)
                    {
                        string tenSanPham = item.SubItems[0].Text;
                        int soLuong = int.Parse(item.SubItems[1].Text);
                        decimal thanhTien = Convert.ToDecimal(item.SubItems[5].Text.Replace(",", ""));

                        danhSachSanPham += tenSanPham + ", ";
                        tongSoLuong += soLuong;
                        tongTien += thanhTien;



                        // 3️⃣ Lưu từng sản phẩm vào HOADONKHACHHANG
                        string insertHoaDonQuery = @"
                    INSERT INTO HOADONKHACHHANG (NGAYXUAT, ID_KHACHHANG, ID_NHANVIEN, ID_NUOCHOA, TENSANPHAM, SOLUONG, TONGTIEN) 
                    VALUES (@NgayXuat, @IDKhachHang, @IDNhanVien, @IDNuocHoa, @TenSanPham, @SoLuong, @TongTien);";

                        SqlCommand cmdHoaDon = new SqlCommand(insertHoaDonQuery, conn, transaction);
                        cmdHoaDon.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
                        cmdHoaDon.Parameters.AddWithValue("@IDKhachHang", idKhachHang);
                        cmdHoaDon.Parameters.AddWithValue("@IDNhanVien", Convert.ToInt32(cb_NhanVien.SelectedValue)); // Chọn nhân viên
                        cmdHoaDon.Parameters.AddWithValue("@IDNuocHoa", 1); // Tạm đặt ID_NUOCHOA là 1, bạn có thể sửa
                        cmdHoaDon.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                        cmdHoaDon.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdHoaDon.Parameters.AddWithValue("@TongTien", thanhTien);

                        cmdHoaDon.ExecuteNonQuery();
                    }

                    // Xóa dấu ", " ở cuối danh sách sản phẩm
                    if (danhSachSanPham.Length > 2)
                        danhSachSanPham = danhSachSanPham.Substring(0, danhSachSanPham.Length - 2);

                    // 4️⃣ Hiển thị thông tin thanh toán
                    MessageBox.Show($"Đã lưu hóa đơn!\nKhách hàng: {txtHoTen.Text}\nSản phẩm: {danhSachSanPham}\nTổng số lượng: {tongSoLuong}\nTổng tiền: {tongTien:N0} VND",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadDataChonNhanVien()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT ID_NHANVIEN, HOTEN FROM NHANVIEN";


            var selectedValue = cb_NhanVien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_NhanVien.DisplayMember = "HOTEN";
            cb_NhanVien.ValueMember = "ID_NHANVIEN";
            cb_NhanVien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_NHANVIEN"].ToString() == selectedValue.ToString()))
            {
                cb_NhanVien.SelectedValue = selectedValue;
            }
            else
            {

                cb_NhanVien.SelectedIndex = 0;
            }
        }



    }
}
