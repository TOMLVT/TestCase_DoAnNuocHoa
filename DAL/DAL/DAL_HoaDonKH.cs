using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_HoaDonKH
    {
        private string connectionString;

        public DAL_HoaDonKH(string DBconnection)
        {
            connectionString = DBconnection;
        }
        public DataTable LoadDataHoaDon()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
        SELECT 
            hd.ID_HOADONKHACHHANG,
            hd.NGAYXUAT,
            kh.HOTEN,
            nv.HOTEN AS TEN_NHANVIEN,
            hd.TENSANPHAM,
            hd.SOLUONG,
            hd.TONGTIEN
        FROM HOADONKHACHHANG hd
        INNER JOIN KHACHHANG kh ON hd.ID_KHACHHANG = kh.ID_KHACHHANG
        INNER JOIN NHANVIEN nv ON hd.ID_NHANVIEN = nv.ID_NHANVIEN
        INNER JOIN SANPHAMNUOCHOA sp ON hd.ID_NUOCHOA = sp.ID_NUOCHOA";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}
