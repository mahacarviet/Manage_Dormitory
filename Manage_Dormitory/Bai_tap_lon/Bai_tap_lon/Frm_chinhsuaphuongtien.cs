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
    public partial class Frm_chinhsuaphuongtien : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuaphuongtien()
        {
            InitializeComponent();
        }

        private void Lbl_gioitinh_Click(object sender, EventArgs e)
        {

        }

        public void Load_dulieu_phuongtien()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From GuiXe");
            DataGrid_chinhsuaphuongtien.DataSource = dta;
            Hienthi_Dulieu();
        }
        public void Load_dulieu_sinhvien()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From SinhVien");
            Cbo_masinhvien.DataSource = dta;
            Cbo_masinhvien.DisplayMember = "MaSV";
            Cbo_masinhvien.ValueMember = "MaSV";
        }
        public void Load_dulieu_khu()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Khu");
            Cbo_makhu.DataSource = dta;
            Cbo_makhu.DisplayMember = "MaKhu";
            Cbo_makhu.ValueMember = "MaKhu";
        }
        public void Load_dulieu_phong()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Phong");
            Cbo_maphong.DataSource = dta;
            Cbo_maphong.DisplayMember = "MaPhong";
            Cbo_maphong.ValueMember = "MaPhong";
        }

        private void Hienthi_Dulieu()
        {
            Txt_bienso.DataBindings.Clear();
            Txt_bienso.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "BienSoXe");

            Txt_tenchuxe.DataBindings.Clear();
            Txt_tenchuxe.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "TenChuXe");

            Txt_giagui.DataBindings.Clear();
            Txt_giagui.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "GiaGui");

            Txt_mota.DataBindings.Clear();
            Txt_mota.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "MoTa");

            Txt_ghichu.DataBindings.Clear();
            Txt_ghichu.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "GhiChu");

            Cbo_makhu.DataBindings.Clear();
            Cbo_makhu.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "MaKhu");

            Cbo_maphong.DataBindings.Clear();
            Cbo_maphong.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "MaPhong");

            Cbo_masinhvien.DataBindings.Clear();
            Cbo_masinhvien.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "MaSV");

            Dtp_ngayhethan.DataBindings.Clear();
            Dtp_ngayhethan.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "NgayHetHan");

            Dtp_ngaydangky.DataBindings.Clear();
            Dtp_ngaydangky.DataBindings.Add("Text", DataGrid_chinhsuaphuongtien.DataSource, "NgayHetHan");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_bienso.Text = "";
            Txt_tenchuxe.Text = "";
            Txt_giagui.Text = "";
            Txt_ghichu.Text = "";
            Txt_mota.Text = "";
            Cbo_maphong.Text = "";
            Cbo_makhu.Text = "";
            Cbo_masinhvien.Text = "";
            Dtp_ngaydangky.Text = "";
            Dtp_ngayhethan.Text = "";
            Txt_bienso.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into GuiXe Values('" + Txt_bienso.Text + "' , '" + Txt_tenchuxe.Text + "', '" + Txt_giagui.Text + "', '" + Txt_ghichu.Text + "','" + Txt_mota.Text + "','" + Dtp_ngaydangky.Value.ToString("dd/MM/yyyy") + "', '" + Dtp_ngayhethan.Value.ToString("dd/MM/yyyy") + "', '" + Cbo_maphong.Text + "', '" + Cbo_makhu.Text + "','" + Cbo_masinhvien.Text + "')";
            ketnoi.Execute(sqlchen);
            Load_dulieu_phuongtien();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            string sqlsua = "Update GuiXe Set TenChuXe ='" + Txt_tenchuxe.Text + "'";
            sqlsua = sqlsua + ", GiaGui ='" + Txt_giagui.Text + "', MoTa ='" + Txt_mota.Text + "', GhiChu ='" + Txt_ghichu.Text + "', NgayDangKy ='" + Dtp_ngaydangky.Text + "', NgayLapDat ='" + Dtp_ngayhethan.Text + "', MaKhu ='" + Cbo_makhu.Text + "', MaPhong ='" + Cbo_maphong.Text + "', MaSV ='" + Cbo_masinhvien.Text + "' where BienSoXe = '" + Txt_bienso.Text + "'";
            ketnoi.Execute(sqlsua);
            Load_dulieu_phuongtien();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete GuiXe Where BienSoXe = '" + Txt_bienso.Text + "'");
            Load_dulieu_phuongtien();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_chinhsuaphuongtien_Load(object sender, EventArgs e)
        {
            Load_dulieu_khu();
            Load_dulieu_phong();
            Load_dulieu_phuongtien();
            Load_dulieu_sinhvien();
        }
    }
}
