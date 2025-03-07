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

namespace TestCase_DoAnNuocHoa
{
    public partial class QuenMatKhau : Form
    {
        Database db = new Database();
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string InputtenNhanVien = txtHoTen.Text.Trim();
            string InputEmail = txtEmail.Text.Trim();
            string InputMatKhauMoi = txtMatKhauMoi.Text.Trim();
            string InputXacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            // Kiểm tra thông tin nhập
            if (string.IsNullOrWhiteSpace(InputtenNhanVien) || string.IsNullOrWhiteSpace(InputEmail))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên và địa chỉ Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(InputMatKhauMoi) || string.IsNullOrWhiteSpace(InputXacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (InputMatKhauMoi != InputXacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = db.GetDatabase();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra nhân viên có tồn tại với HoTen và Email không
                        string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM TAIKHOAN T 
                    INNER JOIN NHANVIEN N ON T.ID_TAIKHOAN = N.ID_TAIKHOAN
                    WHERE T.EMAIL = @Email AND N.HOTEN = @HoTen";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Email", InputEmail);
                        checkCommand.Parameters.AddWithValue("@HoTen", InputtenNhanVien);

                        int count = (int)checkCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Không tìm thấy nhân viên với Email và Họ tên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Cập nhật mật khẩu nếu tìm thấy
                    string updateQuery = "UPDATE TAIKHOAN SET MATKHAU = @MatKhau WHERE EMAIL = @Email";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Email", InputEmail);
                        updateCommand.Parameters.AddWithValue("@MatKhau", InputMatKhauMoi); // Lưu mật khẩu đã mã hóa nếu cần

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể đổi mật khẩu! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
