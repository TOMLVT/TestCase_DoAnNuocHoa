using DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class BLL_NhanVien
    {
        public DAL_NhanVien nuocHoaDAL;

        public BLL_NhanVien(string Dbconnection)
        {
            nuocHoaDAL = new DAL_NhanVien(Dbconnection);
        }
        public DataTable getNhanVien()
        {
            return nuocHoaDAL.LoaddataNhanVien();
        }
    }
}
