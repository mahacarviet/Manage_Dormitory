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
    public partial class Frm_quanlythietbi : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_quanlythietbi()
        {
            InitializeComponent();
        }

        private void Btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (Rb_mathietbi.Checked == true)
            {
                sqltk = "Select * from QuanLyThietBi where MaThietBi like '" + Txt_mathietbi.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (RB_nhapmathietbi.Checked == true)
            {
                sqltk = "Select * from QuanLyThietBi where MaThietBi like '" + Cbo_mathietbi.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            DataGrid_quanlythietbi.DataSource = dta;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_quanlythietbi_Load(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select MaThietBi from QuanLyThietBi");
            Cbo_mathietbi.DataSource = dta;
            Cbo_mathietbi.DisplayMember = "MaThietBi";
            Cbo_mathietbi.ValueMember = "MaThietBi";
        }
    }
}
