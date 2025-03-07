using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCase_DoAnNuocHoa
{
    public partial class FormDangKy : Form
    {
        Database db = new Database();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            DateTime ngaySinh = date_NgaySinh.Value;

          
            if (string.IsNullOrWhiteSpace(tenNhanVien) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = db.GetDatabase();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra xem email đã tồn tại chưa---------------------------------------
                    string checkEmailQuery = "SELECT COUNT(*) FROM TAIKHOAN WHERE EMAIL = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Email đã tồn tại. Vui lòng chọn email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                 
                    string insertTaiKhoanQuery = "INSERT INTO TAIKHOAN (EMAIL, MATKHAU, ID_PHANQUYEN) OUTPUT INSERTED.ID_TAIKHOAN VALUES (@Email, @MatKhau, @MaQuyen)";
                    int idTaiKhoan;

                    using (SqlCommand insertTaiKhoanCmd = new SqlCommand(insertTaiKhoanQuery, conn))
                    {
                        insertTaiKhoanCmd.Parameters.AddWithValue("@Email", email);
                        insertTaiKhoanCmd.Parameters.AddWithValue("@MatKhau", matKhau); 
                        insertTaiKhoanCmd.Parameters.AddWithValue("@MaQuyen", 2);

                        idTaiKhoan = (int)insertTaiKhoanCmd.ExecuteScalar();
                    }

                
                    string insertNhanVienQuery = "INSERT INTO NHANVIEN (HOTEN, SDT, TONGLUONG,NGAYSINH, ID_TAIKHOAN) VALUES (@TenNhanVien, @SDT, @TongLuong,@NgaySinh, @IdTaiKhoan)";
                    using (SqlCommand insertNhanVienCmd = new SqlCommand(insertNhanVienQuery, conn))
                    {
                        insertNhanVienCmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                        insertNhanVienCmd.Parameters.AddWithValue("@SDT", sdt);
                        insertNhanVienCmd.Parameters.AddWithValue("@TongLuong", 0);
                        insertNhanVienCmd.Parameters.AddWithValue("@IdTaiKhoan", idTaiKhoan);
                        insertNhanVienCmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                        int rowsAffected = insertNhanVienCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
