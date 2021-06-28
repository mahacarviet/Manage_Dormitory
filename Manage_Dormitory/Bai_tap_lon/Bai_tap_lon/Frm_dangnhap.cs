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
    public partial class Frm_dangnhap : Form
    {
        Ket_noi kn = new Ket_noi();

        public Frm_dangnhap()
        {
            InitializeComponent();
        }
        public SqlConnection cnn;

        private void Btn_dangnhap_Click(object sender, EventArgs e)
        {

            kn.KetNoi_Dulieu();
            try
            {

                string strKetNoi = @"Data Source=MAHACARVIET;Initial Catalog=quanlyktx1;Integrated Security=True";
                cnn = new SqlConnection(strKetNoi);
                cnn.Open();
                string TK = Txt_dangnhap.Text;
                string MK = Txt_matkhau.Text;
                string sql_login = "Select UserName, Pass, Quyen From Taikhoan where UserName= '" + TK + "'and Pass ='" + MK + "' and Quyen = 'admin'";
                //string sql_quyen = "Select Quyen From Taikhoan where UserName= '" + TK + "' and Quyen= 'admin'";
                //string sql_quyen1 = "Select Quyen From Taikhoan where UserName= '" + TK + "' and Quyen= 'user'";
                //string ktra = sql_quyen.ToString();
                //string admin = "admin";
                //string user = "user";
                //string res = TK.Substring(0, 2);
                string sql_login1 = "Select UserName, Pass, Quyen From Taikhoan where UserName= '" + TK + "'and Pass ='" + MK + "' and Quyen = 'user'";

                SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
                SqlDataReader datRed = cmd.ExecuteReader();
                SqlCommand cmd2 = new SqlCommand(sql_login1, kn.cnn);
                SqlDataReader datRed2 = cmd.ExecuteReader();
                if (datRed.Read() == true)
                {
                        MessageBox.Show("Đăng nhập thành công admin!");
                        Frm_main frm1 = new Frm_main();
                        frm1.Show();
                        // Visible = false;
                        this.Hide();
                 
                }
                else if (datRed2.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công user!");
                    Frm_main_user frm2 = new Frm_main_user();
                    frm2.Show();
                    // Visible = false;
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnn.Close();
            }

            catch (Exception )
            {
                MessageBox.Show("Lỗi kết nối với Cơ sở dữ liệu!");
                
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
