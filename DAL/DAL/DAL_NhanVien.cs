using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_NhanVien
    {
        private string connectionString;

        public DAL_NhanVien(string DBconnection)
        {
            connectionString = DBconnection;
        }

        public DataTable LoaddataNhanVien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string GetQuery = @"
                SELECT * From NHANVIEN                       
                 
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(GetQuery, connection);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
