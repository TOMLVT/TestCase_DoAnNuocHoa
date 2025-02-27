using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_SanPhamNuocHoa
    {
        private string connectionString;

        public DAL_SanPhamNuocHoa(string DBconnection)
        {
            connectionString = DBconnection;    
        }

        public DataTable LoadDataNuocHoa()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string GetQuery = @"
                SELECT                        
                   sp.ID_NUOCHOA,
                   sp.TENSANPHAM,
                    sp.DONGIA,
                    sp.GIAMGIA,
                    lsp.TENLOAISP,
                    ncc.TENNCC
                FROM SANPHAMNUOCHOA sp
                INNER JOIN NHACUNGCAP ncc ON sp.ID_NHACC = ncc.ID_NHACC
                INNER JOIN LOAISANPHAM lsp ON sp.ID_LOAISP = lsp.ID_LOAISP
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(GetQuery, connection);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
