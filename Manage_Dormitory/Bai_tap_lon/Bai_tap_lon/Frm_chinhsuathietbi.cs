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
    public partial class Frm_chinhsuathietbi : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuathietbi()
        {
            InitializeComponent();
        }
        public void Load_dulieu_thietbi()
        {

            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From QuanLyThietBi");
            DataGrid_chinhsuathietbi.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Frm_chinhsuathietbi_Load(object sender, EventArgs e)
        {
            Load_dulieu_thietbi();
        }

        private void Hienthi_Dulieu()
        {
            Txt_mathietbi.DataBindings.Clear();
            Txt_mathietbi.DataBindings.Add("Text", DataGrid_chinhsuathietbi.DataSource, "MaThietBi");

            Txt_tenthietbi.DataBindings.Clear();
            Txt_tenthietbi.DataBindings.Add("Text", DataGrid_chinhsuathietbi.DataSource, "TenThietBi");

            Txt_thoihan.DataBindings.Clear();
            Txt_thoihan.DataBindings.Add("Text", DataGrid_chinhsuathietbi.DataSource, "ThoiHanBaoHanh");

            Txt_giatien.DataBindings.Clear();
            Txt_giatien.DataBindings.Add("Text", DataGrid_chinhsuathietbi.DataSource, "GiaTien");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_mathietbi.Text = "";
            Txt_tenthietbi.Text = "";
            Txt_thoihan.Text = "";
            Txt_giatien.Text = "";
            Txt_mathietbi.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into QuanLyThietBi values ('" + Txt_mathietbi.Text + "', '" + Txt_tenthietbi.Text + "' , '" + Txt_giatien.Text + "', '" + Txt_thoihan.Text + "')";
            ketnoi.Execute(sqlchen);
            Load_dulieu_thietbi();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Update QuanLyThietBi Set TenThietBi ='" + Txt_tenthietbi.Text + "', GiaTien='" + Txt_giatien.Text + "', ThoiHanBaoHanh='" + Txt_thoihan.Text + "', MaThietBi='" + Txt_mathietbi.Text + "'");
            Load_dulieu_thietbi();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete QuanLyThietBi Where MaThietBi = '" + Txt_mathietbi.Text + "'");
            Load_dulieu_thietbi();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
