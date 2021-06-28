using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon
{
    public partial class Frm_tinhchiphi : Form
    {
        public Frm_tinhchiphi()
        {
            InitializeComponent();
        }

        private void Btn_tinhtoan_Click(object sender, EventArgs e)
        {
            int chisodien = Convert.ToInt32(Nud_dienmoi.Value - Nud_diencu.Value);
            int chisonuoc = Convert.ToInt32(Nud_nuocmoi.Value - Nud_nuoccu.Value);
            if (chisonuoc < 32)
            {
                Txt_ketqua.Text = (chisonuoc*7 + chisodien*3).ToString();
            }
            else if ((32 < chisonuoc) && (chisonuoc < 48))
            {
                Txt_ketqua.Text = ((chisonuoc-32)*14 + 32*7 + chisodien*3).ToString(); 
            }
            else
            {
                Txt_ketqua.Text = ((chisonuoc-48)*16 + 32*7 + 16*14 + chisodien*3).ToString();
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
