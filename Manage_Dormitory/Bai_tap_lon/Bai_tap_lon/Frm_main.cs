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
    public partial class Frm_main : Form
    {
        private int childFormNumber = 0;

        public Frm_main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void chiPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm14 = new Frm_tinhchiphi();
            frm14.Show();
        }

        private void thêmTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm0 = new Frm_quanlynguoidung();
            frm0.Show();
        }

        private void Smi_chinhsuasinhvien_Click(object sender, EventArgs e)
        {
            Form frm1 = new Frm_chinhsuasinhvien();
            frm1.Show();
        }

        private void Smi_chinhsuaphong_Click(object sender, EventArgs e)
        {
            Form frm2 = new Frm_chinhsuaphong();
            frm2.Show();
        }

        private void Smi_chinhsuakhu_Click(object sender, EventArgs e)
        {
            Form frm3 = new Frm_chinhsuakhu();
            frm3.Show();
        }

        private void Smi_chinhsuaphuongtien_Click(object sender, EventArgs e)
        {
            Form frm4 = new Frm_chinhsuaphuongtien();
            frm4.Show();
        }

        private void thiêtBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm5 = new Frm_chinhsuathietbi();
            frm5.Show();
        }

        private void Smi_chinhsuathietbihong_Click(object sender, EventArgs e)
        {
            Form frm6 = new Frm_chinhsuathietbihong();
            frm6.Show();
        }

        private void Smi_chinhsuacanbo_Click(object sender, EventArgs e)
        {
            Form frm7 = new Frm_chinhsuacanbo();
            frm7.Show();
        }

        private void Smi_timkiemsinhvien_Click(object sender, EventArgs e)
        {
            Form frm8 = new Frm_timkiemsinhvien();
            frm8.Show();
        }

        private void Smi_timkiemphong_Click(object sender, EventArgs e)
        {
            Form frm9 = new Frm_timkiemphong();
            frm9.Show();
        }

        private void Smi_sinhhoat_Click(object sender, EventArgs e)
        {
            Form frm10 = new Frm_timkiemsinhhoat();
            frm10.Show();
        }

        private void Smi_timkiemphuongtien_Click(object sender, EventArgs e)
        {
            Form frm11 = new Frm_timkiemphuongtien();
            frm11.Show();
        }

        private void thôngTinThiêtBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm12 = new Frm_quanlythietbi();
            frm12.Show();
        }

        private void thiêtBiHongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm13 = new Frm_quanlythietbihong();
            frm13.Show();
        }

        private void khuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm14 = new Frm_bao_cao_khu();
            frm14.Show();
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm15 = new Frm_bao_cao_phong();
            frm15.Show();
        }

        private void thiêtBiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm16 = new Frm_bao_cao_thiet_bi();
            frm16.Show();
        }

        private void thiêtBiHongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm17 = new Frm_bao_cao_thiet_bi_hong();
            frm17.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm18 = new Frm_bao_cao_nhan_vien();
            frm18.Show();
        }
    }
}
