using DAL.Database;
using DAL.Model;
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
    public partial class FormDangNhap : Form
    {
        Database db = new Database();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            FormDangKy dangKy = new FormDangKy();
            dangKy.ShowDialog();    
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin để đăng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = db.GetDatabase();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectData = @"
                SELECT T.ID_PHANQUYEN, N.HOTEN 
                FROM TAIKHOAN T 
                JOIN NHANVIEN N ON T.ID_TAIKHOAN = N.ID_TAIKHOAN 
                WHERE T.EMAIL = @Email AND T.MATKHAU = @matkhau";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {
                            ThongTinCaNhan.Email = txtEmail.Text.Trim();
                            ThongTinCaNhan.TenNhanVien = table.Rows[0]["HOTEN"].ToString();
                            int maPQ = Convert.ToInt32(table.Rows[0]["ID_PHANQUYEN"]);
                          

                            if (maPQ == 1)
                            {
                                MessageBox.Show("Đăng nhập thành công màn hình - QUẢN LÝ !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 manHinhChinh = new Form1();
                                manHinhChinh.Show();
                                this.Hide();
                            }
                            else if (maPQ == 2)
                            {
                                MessageBox.Show("Đăng nhập thành công màn hình - NHÂN VIÊN !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                NhanVien manHinhNhanVien = new NhanVien();
                                manHinhNhanVien.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại: Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_XemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = check_XemMatKhau.Checked ? '\0' : '*';
        }

        private void lb_QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenPass = new QuenMatKhau();
            quenPass.ShowDialog();
        }
    }
}
