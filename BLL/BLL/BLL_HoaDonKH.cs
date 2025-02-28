using DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class BLL_HoaDonKH
    {
        public DAL_HoaDonKH hoaDonDAL;

        public BLL_HoaDonKH(string Dbconnection)
        {
            hoaDonDAL = new DAL_HoaDonKH(Dbconnection);
        }

        public DataTable GetDataHoaDon()
        {
            return hoaDonDAL.LoadDataHoaDon();
        }
    }
}
