using BLL.BLL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCase_DoAnNuocHoa.UserForm
{
    public partial class HoaDonKhachHang : UserControl
    {
        Database db = new Database();

        private BLL_HoaDonKH hoaDonBLL;
        public HoaDonKhachHang()
        {
            InitializeComponent();

            hoaDonBLL = new BLL_HoaDonKH(new Database().GetDatabase());

            LoadHD();

        }
        public void LoadHD()
        {
            data_HoaDon.DataSource = hoaDonBLL.GetDataHoaDon();
        }

        private void data_HoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_HoaDon.Columns[e.ColumnIndex].Name == "TONGTIEN" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_HoaDon.CurrentRow != null)
                {
                    DataGridViewRow selectedRow = data_HoaDon.CurrentRow;

                    string maHD = selectedRow.Cells["ID_HOADONKHACHHANG"].Value?.ToString() ?? string.Empty;
                    string tenKhachHang = selectedRow.Cells["HOTEN"].Value?.ToString() ?? "Khách lẻ";
                    string ngayXuat = selectedRow.Cells["NGAYXUAT"].Value?.ToString() ?? string.Empty;

                    // Lấy thông tin chi tiết hóa đơn
                    string tenSanPham = selectedRow.Cells["TENSANPHAM"].Value?.ToString() ?? "N/A";
                    int soLuong = Convert.ToInt32(selectedRow.Cells["SOLUONG"].Value ?? 0);
                                
                    decimal tongTien = Convert.ToDecimal(selectedRow.Cells["TONGTIEN"].Value ?? 0);

                  

                    // Chia tên sản phẩm thành dòng ngắn để dễ đọc trên hóa đơn
                    string WrapText(string text, int maxLength)
                    {
                        var words = text.Split(' ');
                        var wrappedText = "";
                        var currentLine = "";

                        foreach (var word in words)
                        {
                            if ((currentLine + word).Length > maxLength)
                            {
                                wrappedText += currentLine.TrimEnd() + "\n";
                                currentLine = word + " ";
                            }
                            else
                            {
                                currentLine += word + " ";
                            }
                        }
                        wrappedText += currentLine.TrimEnd();
                        return wrappedText;
                    }

                    string tenSanPhamWrapped = WrapText(tenSanPham, 50);

                    // Tạo nội dung hóa đơn
                    string invoiceContent = $@"
HÓA ĐƠN THANH TOÁN
--------------------------------------
Mã Hóa Đơn   : {maHD}
Khách Hàng   : {tenKhachHang}
Ngày Xuất    : {ngayXuat}
        
Thông tin sản phẩm mua:
{"Tên sản phẩm:",-15}  {tenSanPhamWrapped}
{"Số lượng:",-15}       {soLuong}
{"Tổng cộng:",-15}      {tongTien.ToString("N0")} VNĐ
        
--------------------------------------
Cảm ơn quý khách đã mua hàng!";

                    // In hóa đơn
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += (s, ev) =>
                    {
                        System.Drawing.Font printFont = new System.Drawing.Font("Arial", 12);
                        ev.Graphics.DrawString(invoiceContent, printFont, Brushes.Black, new Point(50, 50));
                    };

                    PrintPreviewDialog previewDialog = new PrintPreviewDialog
                    {
                        Document = printDocument
                    };
                    previewDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
