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
    public partial class Frm_chinhsuaphong : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuaphong()
        {
            InitializeComponent();
        }

        private void Lbl_matkhau_Click(object sender, EventArgs e)
        {

        }

        public void Load_dulieu_phong()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Phong");
            DataGrid_chinhsuaphong.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_dulieu_khu()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Khu");
            Cbo_makhu.DataSource = dta;
            Cbo_makhu.DisplayMember = "MaKhu";
            Cbo_makhu.ValueMember = "MaKhu";
        }

        private void Hienthi_Dulieu()
        {
            Txt_maphong.DataBindings.Clear();
            Txt_maphong.DataBindings.Add("Text", DataGrid_chinhsuaphong.DataSource, "MaPhong");

            Txt_tenphong.DataBindings.Clear();
            Txt_tenphong.DataBindings.Add("Text", DataGrid_chinhsuaphong.DataSource, "TenPhong");

            Txt_loaiphong.DataBindings.Clear();
            Txt_loaiphong.DataBindings.Add("Text", DataGrid_chinhsuaphong.DataSource, "LoaiPhong");

            Nud_songuoihientai.DataBindings.Clear();
            Nud_songuoihientai.DataBindings.Add("Text", DataGrid_chinhsuaphong.DataSource, "SoNguoiHienTai");

            Nud_songuoitoida.DataBindings.Clear();
            Nud_songuoitoida.DataBindings.Add("Text", DataGrid_chinhsuaphong.DataSource, "SoNguoiToiDa");
        }

        private void Frm_chinhsuaphong_Load(object sender, EventArgs e)
        {
            Load_dulieu_khu();
            Load_dulieu_phong();
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_maphong.Text = "";
            Txt_tenphong.Text = "";
            Txt_loaiphong.Text = "";
            Nud_songuoihientai.Value = 0;
            Nud_songuoitoida.Value = 0;
            Txt_maphong.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into Phong values ('" + Txt_maphong.Text + "', '" + Cbo_makhu.Text + "' , '" + Txt_tenphong.Text + "', '" + Txt_loaiphong.Text + "', '" + Nud_songuoihientai.Value + "', '" + Nud_songuoitoida.Value + "');";
            ketnoi.Execute(sqlchen);
            Load_dulieu_phong();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Update Phong Set TenPhong='" + Txt_tenphong.Text + "', LoaiPhong='" + Txt_loaiphong.Text + "', SoNguoiHienTai='" + Nud_songuoihientai.Value + "', SoNguoiToiDa='" + Nud_songuoitoida.Value + "', MaKhu='" + Cbo_makhu.Text + "' Where MaPhong ='" + Txt_maphong.Text + "'");
            Load_dulieu_phong();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Phong Where MaPhong = '" + Txt_maphong.Text + "'");
            Load_dulieu_phong();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
