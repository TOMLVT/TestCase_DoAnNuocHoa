using DAL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class BLL_SanPhamNuocHoa
    {
        public DAL_SanPhamNuocHoa nuocHoaDAL;

        public BLL_SanPhamNuocHoa(string Dbconnection)
        {
            nuocHoaDAL = new DAL_SanPhamNuocHoa(Dbconnection);
        }
        public DataTable GetDataNuocHoa()
        {
            return nuocHoaDAL.LoadDataNuocHoa();
        }
    }
}
