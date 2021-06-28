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
    public partial class Frm_chinhsuacanbo : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuacanbo()
        {
            InitializeComponent();
        }

        public void Load_dulieu_canbo()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select *  From NhanVien");
            DataGrid_chinhsuacanbo.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            Txt_manhanvien.DataBindings.Clear();
            Txt_manhanvien.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "MaNV");

            Txt_tennhanvien.DataBindings.Clear();
            Txt_tennhanvien.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "HoTen");

            Txt_sodienthoai.DataBindings.Clear();
            Txt_sodienthoai.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "SDT");

            Txt_quequan.DataBindings.Clear();
            Txt_quequan.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "QueQuan");

            Txt_chucvu.DataBindings.Clear();
            Txt_chucvu.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "ChucVu");

            Txt_luong.DataBindings.Clear();
            Txt_luong.DataBindings.Add("Text", DataGrid_chinhsuacanbo.DataSource, "Luong");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_manhanvien.Text = "";
            Txt_tennhanvien.Text = "";
            Txt_sodienthoai.Text = "";
            Txt_quequan.Text = "";
            Txt_chucvu.Text = "";
            Txt_luong.Text = "";
            Txt_manhanvien.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into NhanVien values ('" + Txt_manhanvien.Text + "', '" + Txt_tennhanvien.Text + "' , '" + Txt_sodienthoai.Text + "', '" + Txt_quequan.Text + "', '" + Txt_chucvu.Text + "', '" + Txt_luong.Text + "');";
            ketnoi.Execute(sqlchen);
            Load_dulieu_canbo();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Update NhanVien Set HoTen='" + Txt_tennhanvien.Text + "', SDT='" + Txt_sodienthoai.Text + "', QueQuan='" + Txt_quequan.Text + "', ChucVu='" + Txt_chucvu.Text + "', Luong='" + Txt_luong.Text + "' Where MaKhu ='" + Txt_manhanvien.Text + "'");
            Load_dulieu_canbo();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete NhanVien Where MaNV = '" + Txt_manhanvien.Text + "'");
            Load_dulieu_canbo();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_chinhsuacanbo_Load(object sender, EventArgs e)
        {
            Load_dulieu_canbo();
        }
    }
}
