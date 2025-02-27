using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SanPhamNuocHoa
    {
        public int ID_NUOCHOA { get; set; }
        public string TENSANPHAM { get; set; }
        public int DUNGTICH { get; set; }
        public decimal DONGIA { get; set; }
        public decimal GIAMGIA { get; set; }
        public int SOLUONGTON { get; set; }
        public int DABAN { get; set; }
        public int ID_NHACC { get; set; }
        public int ID_LOAISP { get; set; }
    }

}
