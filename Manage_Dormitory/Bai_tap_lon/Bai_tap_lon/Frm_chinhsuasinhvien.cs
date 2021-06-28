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
    public partial class Frm_chinhsuasinhvien : Form
    {
        Ket_noi ketnoi = new Ket_noi();

        public Frm_chinhsuasinhvien()
        {
            InitializeComponent();
        }

        public void Load_dulieu_sinhvien()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * From SinhVien");
            DataGrid_chinhsuasinhvien.DataSource = dta;
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
            Txt_masinhvien.DataBindings.Clear();
            Txt_masinhvien.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "MaSV");

            Txt_hoten.DataBindings.Clear();
            Txt_hoten.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "HoTen");

            Txt_cmnd.DataBindings.Clear();
            Txt_cmnd.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "CMND");
            
            Txt_sodienthoai.DataBindings.Clear();
            Txt_sodienthoai.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "SDT");

            Dtp_ngaylamhopdong.DataBindings.Clear();
            Dtp_ngaylamhopdong.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "NgayLamHopDong");

            Cbo_maphong.DataBindings.Clear();
            Cbo_maphong.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "MaPhong");

            Cbo_makhu.DataBindings.Clear();
            Cbo_makhu.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "MaKhu");

            Dtp_ngaysinh.DataBindings.Clear();
            Dtp_ngaysinh.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "NgaySinh");

            Txt_quequan.DataBindings.Clear();
            Txt_quequan.DataBindings.Add("Text", DataGrid_chinhsuasinhvien.DataSource, "QueQuan");
        }

        private void Btn_taomoi_Click(object sender, EventArgs e)
        {
            Txt_masinhvien.Text = "";
            Txt_hoten.Text = "";
            Txt_cmnd.Text = "";
            Txt_sodienthoai.Text = "";
            Dtp_ngaylamhopdong.Text = "";
            Cbo_maphong.Text = "";
            Cbo_makhu.Text = "";
            Dtp_ngaysinh.Text = "";
            Txt_quequan.Text = "";
            Txt_masinhvien.Focus();
        }

        private void Btn_xoadulieu_Click(object sender, EventArgs e)
        {
            ketnoi.Execute("Delete SinhVien Where MaSV = '" + Txt_masinhvien.Text + "'");
            Load_dulieu_sinhvien();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SqlConnection cnn;
        private void Btn_chendulieu_Click(object sender, EventArgs e)
        {
            string strKetNoi = @"Data Source=MAHACARVIET;Initial Catalog=quanlyktx1;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();

            if (Rb_nam.Checked == true)
            {
                string sqlchen = "Insert into SinhVien values ('" + Txt_masinhvien.Text + "', '" + Txt_hoten.Text + "' , '" + Txt_cmnd.Text + "', 'nam', '" + Dtp_ngaysinh.Value.ToString("dd/MM/yyyy") + "', '" + Txt_sodienthoai.Text + "', '" + Txt_quequan.Text + "', '" + Dtp_ngaylamhopdong.Value.ToString("dd/MM/yyyy") + "', '" + Cbo_maphong.Text + "', '" + Cbo_makhu.Text + "');";
                ketnoi.Execute(sqlchen);
                Load_dulieu_sinhvien();
            }

            if (Rb_nu.Checked == true)
            {
                string sqlchen = "Insert into SinhVien values ('" + Txt_masinhvien.Text + "', '" + Txt_hoten.Text + "' , '" + Txt_cmnd.Text + "', N'nữ', '" + Dtp_ngaysinh.Value.ToString("dd/MM/yyyy") + "', '" + Txt_sodienthoai.Text + "', '" + Txt_quequan.Text + "', '" + Dtp_ngaylamhopdong.Value.ToString("dd/MM/yyyy") + "', '" + Cbo_maphong.Text + "', '" + Cbo_makhu.Text + "');";
                ketnoi.Execute(sqlchen);
                Load_dulieu_sinhvien();
            }

            cnn.Close();
        }

        private void Btn_suadulieu_Click(object sender, EventArgs e)
        {
            string strKetNoi = @"Server=MAHACARVIET;Database=Quanly_K60;Trusted_Connection=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();

            if (Rb_nam.Checked == true)
            {
                ketnoi.Execute("Update SinhVien Set HoTen ='" + Txt_hoten.Text + "', CMND='" + Txt_cmnd.Text + "', HoTen='" + "nam" + "', NgaySinh='" + Dtp_ngaysinh.Value.ToString("dd/MM/yyyy") + "', SDT='" + Txt_sodienthoai.Text + "', QueQuan='" + Txt_quequan.Text + "', NgayLamHopDong='" + Dtp_ngaylamhopdong.Value.ToString("dd/MM/yyyy") + "', MaPhong='" + Cbo_maphong.Text + "', MaKhu='" + Cbo_makhu.Text + "' Where MaSV ='" + Txt_masinhvien + "'");
                Load_dulieu_sinhvien();
            }

            if (Rb_nu.Checked == true)
            {
                ketnoi.Execute("Update SinhVien Set HoTen ='" + Txt_hoten.Text + "', CMND='" + Txt_cmnd.Text + "', HoTen='" + "nữ" + "', NgaySinh='" + Dtp_ngaysinh.Value.ToString("dd/MM/yyyy") + "', SDT='" + Txt_sodienthoai.Text + "', QueQuan='" + Txt_quequan.Text + "', NgayLamHopDong='" + Dtp_ngaylamhopdong.Value.ToString("dd/MM/yyyy") + "', MaPhong='" + Cbo_maphong.Text + "', MaKhu='" + Cbo_makhu.Text + "' Where MaSV ='" + Txt_masinhvien + "'");
                Load_dulieu_sinhvien();
            }

            cnn.Close();
        }

        private void Frm_chinhsuasinhvien_Load(object sender, EventArgs e)
        {
            Load_dulieu_khu();
            Load_dulieu_phong();
            Load_dulieu_sinhvien();
        }
    }
}
