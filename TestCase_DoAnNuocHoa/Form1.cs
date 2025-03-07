using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCase_DoAnNuocHoa.UserForm;

namespace TestCase_DoAnNuocHoa
{
    public partial class Form1 : Form
    {
        Database db = new Database();

     

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
            manHinhChinh1.Visible = false;
            hoaDonKhachHang1.Visible = true;
        }

        private void hoaDonKhachHang1_Load(object sender, EventArgs e)
        {

        }
    }
}
