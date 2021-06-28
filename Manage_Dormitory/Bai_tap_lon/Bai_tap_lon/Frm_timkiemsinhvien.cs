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
    public partial class Frm_timkiemsinhvien : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_timkiemsinhvien()
        {
            InitializeComponent();
        }

        private void Btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (Rb_masinhvien.Checked == true)
            {
                sqltk = "Select * from SinhVien where MaSV like '" + Txt_masinhvien.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (Rb_nhaptensinhvien.Checked == true)
            {
                sqltk = "Select * from SinhVien where HoTen like '%" + Txt_tensinhvien.Text + "%'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (Rb_nhapsocmnd.Checked == true)
            {
                sqltk = "Select * from SinhVien where CMND like '%" + Txt_socmnd.Text + "%'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (Rb_nhapsodienthoai.Checked == true)
            {
                sqltk = "Select * from SinhVien where SDT like '%" + Txt_sodienthoai.Text + "%'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            if (RB_nhapmasinhvien1.Checked == true)
            {
                sqltk = "Select * from SinhVien where MaSV like '" + Cbo_masinhvien.Text + "'";
                dta = ketnoi.Lay_Dulieu(sqltk);
            }

            DataGrid_timkiemsinhvien.DataSource = dta;
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_timkiemsinhvien_Load(object sender, EventArgs e)
        {
            ketnoi.KetNoi_Dulieu();
            DataTable dta = ketnoi.Lay_Dulieu("Select * from SinhVien");
            Cbo_masinhvien.DataSource = dta;
            Cbo_masinhvien.DisplayMember = "MaSV";
            Cbo_masinhvien.ValueMember = "MaSV";
        }
    }
}
