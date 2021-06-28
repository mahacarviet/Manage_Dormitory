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
    public partial class Frm_chinhsuakhu : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuakhu()
        {
            InitializeComponent();
        }

        public void Load_dulieu_khu()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From Khu");
            DataGrid_chinhsuakhu.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            Txt_makhu.DataBindings.Clear();
            Txt_makhu.DataBindings.Add("Text", DataGrid_chinhsuakhu.DataSource, "MaKhu");

            Txt_tenkhu.DataBindings.Clear();
            Txt_tenkhu.DataBindings.Add("Text", DataGrid_chinhsuakhu.DataSource, "TenKhu");

            Txt_sophong.DataBindings.Clear();
            Txt_sophong.DataBindings.Add("Text", DataGrid_chinhsuakhu.DataSource, "SoPhong");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_makhu.Text = "";
            Txt_tenkhu.Text = "";
            Txt_sophong.Text = "";
            Txt_makhu.Focus();
        }

        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string sqlchen = "Insert into Khu values ('" + Txt_makhu.Text + "', '" + Txt_tenkhu.Text + "' , '" + Txt_sophong.Text + "');";
            ketnoi.Execute(sqlchen);
            Load_dulieu_khu();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Update Khu Set TenKhu='" + Txt_tenkhu.Text + "', SoPhong='" + Txt_sophong.Text + "' Where MaKhu ='" + Txt_makhu.Text + "'");
            Load_dulieu_khu();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete Khu Where MaKhu = '" + Txt_makhu.Text + "'");
            Load_dulieu_khu();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_chinhsuakhu_Load(object sender, EventArgs e)
        {
            Load_dulieu_khu();
        }
    }
}
