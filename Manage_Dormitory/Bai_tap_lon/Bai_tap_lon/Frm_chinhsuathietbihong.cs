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
    public partial class Frm_chinhsuathietbihong : Form
    {
        Ket_noi kn = new Ket_noi();

        public Frm_chinhsuathietbihong()
        {
            InitializeComponent();
        }
        public void Load_dulieu_thietbihong()
        {

            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From QuanLyThietBiHong");
            DataGrid_chinhsuathietbihong.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void Load_dulieu_phong()
        {

            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From Phong");
            Cbo_maphong.DataSource = dta;
            Cbo_maphong.DisplayMember = "MaPhong";
            Cbo_maphong.ValueMember = "MaPhong";
        }

        public void Load_dulieu_khu()
        {

            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("Select * From Khu");
            Cbo_makhu.DataSource = dta;
            Cbo_makhu.DisplayMember = "MaKhu";
            Cbo_makhu.ValueMember = "MaKhu";
        }

        private void Frm_chinhsuathietbihong_Load(object sender, EventArgs e)
        {
            Load_dulieu_khu();
            Load_dulieu_phong();
            Load_dulieu_thietbihong();
        }

        public void Hienthi_Dulieu()
        {
            Txt_mathietbi.DataBindings.Clear();
            Txt_mathietbi.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "MaThietBi");

            Cbo_makhu.DataBindings.Clear();
            Cbo_makhu.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "MaKhu");

            Cbo_maphong.DataBindings.Clear();
            Cbo_maphong.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "MaPhong");

            Nud_soluong.DataBindings.Clear();
            Nud_soluong.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "SoLuongHong");

            Dtp_ngayhetbaohanh.DataBindings.Clear();
            Dtp_ngayhetbaohanh.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "NgayHetBaoHanh");

            Dtp_ngaylapdat.DataBindings.Clear();
            Dtp_ngaylapdat.DataBindings.Add("Text", DataGrid_chinhsuathietbihong.DataSource, "NgayLapDat");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_mathietbi.Text = "";
            Cbo_maphong.Text = "";
            Cbo_makhu.Text = "";
            Nud_soluong.Value = 0;
            Dtp_ngaylapdat.Text = "";
            Dtp_ngayhetbaohanh.Text = "";
            Txt_mathietbi.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into ThietBiHong  Values('" + Txt_mathietbi.Text + "','" + Dtp_ngaylapdat.Value.ToString("dd/MM/yyyy") + "', '" + Dtp_ngayhetbaohanh.Value.ToString("dd/MM/yyyy") + "', '" + Cbo_maphong.Text + "','" + Cbo_makhu + "' ,'" + Nud_soluong.Value + "')";
            kn.Execute(sqlchen);
            Load_dulieu_thietbihong();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            string sqlsua = "Update ThietBiHong Set  NgayHetBaoHanh ='" + Dtp_ngayhetbaohanh.Text + "', NgayLapDat ='" + Dtp_ngaylapdat.Text + "', MaKhu ='" + Cbo_makhu.Text + "', MaPhong ='" + Cbo_maphong.Text + "', SoLuongHong ='" + Nud_soluong.Value + "' where MaThietBi = '" + Txt_mathietbi.Text + "'";
            kn.Execute(sqlsua);
            Load_dulieu_thietbihong();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            kn.Execute("Delete ThietBiHong Where MaThietBi = '" + Txt_mathietbi.Text + "'");
            Load_dulieu_thietbihong();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
