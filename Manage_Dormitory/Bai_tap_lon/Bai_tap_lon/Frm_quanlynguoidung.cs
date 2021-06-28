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
    public partial class Frm_quanlynguoidung : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_quanlynguoidung()
        {
            InitializeComponent();
        }

        public void Load_dulieu_nguoidung()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select UserName, Pass, HoTen From TaiKhoan");
            DataGrid_quanlynguoidung.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            Txt_taikhoan.DataBindings.Clear();
            Txt_taikhoan.DataBindings.Add("Text", DataGrid_quanlynguoidung.DataSource, "UserName");

            Txt_matkhau.DataBindings.Clear();
            Txt_matkhau.DataBindings.Add("Text", DataGrid_quanlynguoidung.DataSource, "Pass");

            Txt_hoten.DataBindings.Clear();
            Txt_hoten.DataBindings.Add("Text", DataGrid_quanlynguoidung.DataSource, "HoTen");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_taikhoan.Text = "";
            Txt_matkhau.Text = "";
            Txt_hoten.Text = "";
            Txt_taikhoan.Focus();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete TaiKhoan Where UserName = '" + Txt_taikhoan.Text + "'");
            Load_dulieu_nguoidung();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_quanlynguoidung_Load(object sender, EventArgs e)
        {
            Load_dulieu_nguoidung();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            if (Rb_admin.Checked == true)
            {
                string sqlchen = "Insert into TaiKhoan values ('" + Txt_taikhoan.Text + "', '" + Txt_matkhau.Text + "' , '" + Txt_hoten.Text + "', 'admin');";
                ketnoi.Execute(sqlchen);
                Load_dulieu_nguoidung();
            }

            if (Rb_user.Checked == true)
            {
                string sqlchen = "Insert into TaiKhoan values ('" + Txt_taikhoan.Text + "', '" + Txt_matkhau.Text + "' , '" + Txt_hoten.Text + "', 'user');";
                ketnoi.Execute(sqlchen);
                Load_dulieu_nguoidung();
            }

        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Update TaiKhoan Set Pass ='" + Txt_matkhau.Text + "', HoTen='" + Txt_hoten + "' Where UserName ='" + Txt_taikhoan + "'");
            Load_dulieu_nguoidung();
        }

        private void DataGrid_quanlynguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
