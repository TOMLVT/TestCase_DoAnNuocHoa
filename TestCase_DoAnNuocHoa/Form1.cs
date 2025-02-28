using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCase_DoAnNuocHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_manHinhChinh_Click(object sender, EventArgs e)
        {
            manHinhChinh1.Visible = true;
            hoaDonKhachHang1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hoaDonKhachHang1.Visible=true;
            manHinhChinh1.Visible = false;
        }
    }
}
