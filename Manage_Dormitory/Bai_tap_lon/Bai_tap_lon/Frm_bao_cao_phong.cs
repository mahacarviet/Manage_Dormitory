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
    public partial class Frm_bao_cao_phong : Form
    {
        Ket_noi ketnoi = new Ket_noi();  // khởi tạo class

        public Frm_bao_cao_phong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select * from Phong");
            Bao_cao_phong BC1 = new Bao_cao_phong();
            BC1.SetDataSource(dta);
            crystalReportViewer1.ReportSource = BC1;
        }
    }
}
