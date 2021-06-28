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
    public partial class Frm_timkiemsinhhoat : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_timkiemsinhhoat()
        {
            InitializeComponent();
        }

        private void Btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (Rb_maphong.Checked == true)
            {
                sqltk = "Select * from Phong where MaPhong like '" + Txt_maphong.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (RB_nhapmaphong.Checked == true)
            {
                sqltk = "Select * from Phong where MaPhong like '" + Cbo_maphong.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            DataGrid_timkiemsinhhoat.DataSource = dta;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_timkiemsinhhoat_Load(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.Lay_Dulieu("Select MaPhong from SinhHoat ");
            Cbo_maphong.DataSource = dta;
            Cbo_maphong.DisplayMember = "MaPhong";
            Cbo_maphong.ValueMember = "MaPhong";
        }
    }
}
