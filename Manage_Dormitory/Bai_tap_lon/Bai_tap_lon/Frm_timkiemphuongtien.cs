using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai_tap_lon
{
    public partial class Frm_timkiemphuongtien : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_timkiemphuongtien()
        {
            InitializeComponent();
        }

        private void Frm_timkiemphuongtien_Load(object sender, EventArgs e)
        {

        }

        private void Btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (Rb_masinhvien.Checked == true)
            {
                sqltk = "Select * from GuiXe where MaSV like '" + Txt_masinhvien.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (Rb_nhapbiensoxe.Checked == true)
            {
                sqltk = "Select * from GuiXe where BienSoXe like '" + Txt_nhapbiensoxe.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            DataGrid_timkiemphuongtien.DataSource = dta;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
