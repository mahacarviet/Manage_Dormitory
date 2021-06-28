namespace Bai_tap_lon
{
    partial class Frm_chinhsuaphuongtien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_maphong = new System.Windows.Forms.Label();
            this.Lbl_makhu = new System.Windows.Forms.Label();
            this.DataGrid_chinhsuaphuongtien = new System.Windows.Forms.DataGridView();
            this.Lbl_masinhvien = new System.Windows.Forms.Label();
            this.Txt_tenchuxe = new System.Windows.Forms.TextBox();
            this.Lbl_tenchuxe = new System.Windows.Forms.Label();
            this.Btn_xoadulieu = new System.Windows.Forms.Button();
            this.Btn_suadulieu = new System.Windows.Forms.Button();
            this.Btn_chendulieu = new System.Windows.Forms.Button();
            this.Btn_thoat = new System.Windows.Forms.Button();
            this.Btn_taomoi = new System.Windows.Forms.Button();
            this.Lbl_quanlyphuongtien = new System.Windows.Forms.Label();
            this.Txt_bienso = new System.Windows.Forms.TextBox();
            this.Lbl_bienso = new System.Windows.Forms.Label();
            this.Txt_ghichu = new System.Windows.Forms.TextBox();
            this.Txt_giagui = new System.Windows.Forms.TextBox();
            this.Lbl_ghichu = new System.Windows.Forms.Label();
            this.Lbl_giagui = new System.Windows.Forms.Label();
            this.Txt_mota = new System.Windows.Forms.TextBox();
            this.Lbl_mota = new System.Windows.Forms.Label();
            this.Lbl_ngayhethan = new System.Windows.Forms.Label();
            this.Lbl_ngaydangky = new System.Windows.Forms.Label();
            this.Dtp_ngaydangky = new System.Windows.Forms.DateTimePicker();
            this.Dtp_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.Cbo_makhu = new System.Windows.Forms.ComboBox();
            this.Cbo_maphong = new System.Windows.Forms.ComboBox();
            this.Cbo_masinhvien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_chinhsuaphuongtien)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_maphong
            // 
            this.Lbl_maphong.AutoSize = true;
            this.Lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_maphong.Location = new System.Drawing.Point(25, 272);
            this.Lbl_maphong.Name = "Lbl_maphong";
            this.Lbl_maphong.Size = new System.Drawing.Size(135, 29);
            this.Lbl_maphong.TabIndex = 149;
            this.Lbl_maphong.Text = "Mã phòng:";
            // 
            // Lbl_makhu
            // 
            this.Lbl_makhu.AutoSize = true;
            this.Lbl_makhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_makhu.Location = new System.Drawing.Point(25, 222);
            this.Lbl_makhu.Name = "Lbl_makhu";
            this.Lbl_makhu.Size = new System.Drawing.Size(103, 29);
            this.Lbl_makhu.TabIndex = 148;
            this.Lbl_makhu.Text = "Mã khu:";
            this.Lbl_makhu.Click += new System.EventHandler(this.Lbl_gioitinh_Click);
            // 
            // DataGrid_chinhsuaphuongtien
            // 
            this.DataGrid_chinhsuaphuongtien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_chinhsuaphuongtien.Location = new System.Drawing.Point(30, 414);
            this.DataGrid_chinhsuaphuongtien.Name = "DataGrid_chinhsuaphuongtien";
            this.DataGrid_chinhsuaphuongtien.RowHeadersWidth = 51;
            this.DataGrid_chinhsuaphuongtien.RowTemplate.Height = 24;
            this.DataGrid_chinhsuaphuongtien.Size = new System.Drawing.Size(989, 280);
            this.DataGrid_chinhsuaphuongtien.TabIndex = 147;
            // 
            // Lbl_masinhvien
            // 
            this.Lbl_masinhvien.AutoSize = true;
            this.Lbl_masinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_masinhvien.Location = new System.Drawing.Point(25, 175);
            this.Lbl_masinhvien.Name = "Lbl_masinhvien";
            this.Lbl_masinhvien.Size = new System.Drawing.Size(165, 29);
            this.Lbl_masinhvien.TabIndex = 145;
            this.Lbl_masinhvien.Text = "Mã sinh viên:";
            // 
            // Txt_tenchuxe
            // 
            this.Txt_tenchuxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tenchuxe.Location = new System.Drawing.Point(188, 127);
            this.Txt_tenchuxe.Name = "Txt_tenchuxe";
            this.Txt_tenchuxe.Size = new System.Drawing.Size(285, 34);
            this.Txt_tenchuxe.TabIndex = 144;
            // 
            // Lbl_tenchuxe
            // 
            this.Lbl_tenchuxe.AutoSize = true;
            this.Lbl_tenchuxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tenchuxe.Location = new System.Drawing.Point(25, 127);
            this.Lbl_tenchuxe.Name = "Lbl_tenchuxe";
            this.Lbl_tenchuxe.Size = new System.Drawing.Size(148, 29);
            this.Lbl_tenchuxe.TabIndex = 143;
            this.Lbl_tenchuxe.Text = "Tên chủ xe:";
            // 
            // Btn_xoadulieu
            // 
            this.Btn_xoadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoadulieu.Location = new System.Drawing.Point(661, 326);
            this.Btn_xoadulieu.Name = "Btn_xoadulieu";
            this.Btn_xoadulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_xoadulieu.TabIndex = 142;
            this.Btn_xoadulieu.Text = "Xóa dữ liệu";
            this.Btn_xoadulieu.UseVisualStyleBackColor = true;
            this.Btn_xoadulieu.Click += new System.EventHandler(this.Btn_xoadulieu_Click);
            // 
            // Btn_suadulieu
            // 
            this.Btn_suadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_suadulieu.Location = new System.Drawing.Point(448, 326);
            this.Btn_suadulieu.Name = "Btn_suadulieu";
            this.Btn_suadulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_suadulieu.TabIndex = 141;
            this.Btn_suadulieu.Text = "Sửa dữ liệu";
            this.Btn_suadulieu.UseVisualStyleBackColor = true;
            this.Btn_suadulieu.Click += new System.EventHandler(this.Btn_suadulieu_Click);
            // 
            // Btn_chendulieu
            // 
            this.Btn_chendulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_chendulieu.Location = new System.Drawing.Point(248, 326);
            this.Btn_chendulieu.Name = "Btn_chendulieu";
            this.Btn_chendulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_chendulieu.TabIndex = 140;
            this.Btn_chendulieu.Text = "Chèn dữ liệu";
            this.Btn_chendulieu.UseVisualStyleBackColor = true;
            this.Btn_chendulieu.Click += new System.EventHandler(this.Btn_chendulieu_Click);
            // 
            // Btn_thoat
            // 
            this.Btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thoat.Location = new System.Drawing.Point(866, 325);
            this.Btn_thoat.Name = "Btn_thoat";
            this.Btn_thoat.Size = new System.Drawing.Size(153, 72);
            this.Btn_thoat.TabIndex = 139;
            this.Btn_thoat.Text = "Thoát";
            this.Btn_thoat.UseVisualStyleBackColor = true;
            this.Btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // Btn_taomoi
            // 
            this.Btn_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_taomoi.Location = new System.Drawing.Point(36, 326);
            this.Btn_taomoi.Name = "Btn_taomoi";
            this.Btn_taomoi.Size = new System.Drawing.Size(153, 72);
            this.Btn_taomoi.TabIndex = 138;
            this.Btn_taomoi.Text = "Tạo mới";
            this.Btn_taomoi.UseVisualStyleBackColor = true;
            this.Btn_taomoi.Click += new System.EventHandler(this.Btn_taomoi_Click);
            // 
            // Lbl_quanlyphuongtien
            // 
            this.Lbl_quanlyphuongtien.AutoSize = true;
            this.Lbl_quanlyphuongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_quanlyphuongtien.Location = new System.Drawing.Point(299, 23);
            this.Lbl_quanlyphuongtien.Name = "Lbl_quanlyphuongtien";
            this.Lbl_quanlyphuongtien.Size = new System.Drawing.Size(419, 38);
            this.Lbl_quanlyphuongtien.TabIndex = 137;
            this.Lbl_quanlyphuongtien.Text = "QUẢN LÝ PHƯƠNG TIỆN";
            // 
            // Txt_bienso
            // 
            this.Txt_bienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_bienso.Location = new System.Drawing.Point(188, 79);
            this.Txt_bienso.Name = "Txt_bienso";
            this.Txt_bienso.Size = new System.Drawing.Size(285, 34);
            this.Txt_bienso.TabIndex = 136;
            // 
            // Lbl_bienso
            // 
            this.Lbl_bienso.AutoSize = true;
            this.Lbl_bienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_bienso.Location = new System.Drawing.Point(25, 80);
            this.Lbl_bienso.Name = "Lbl_bienso";
            this.Lbl_bienso.Size = new System.Drawing.Size(142, 29);
            this.Lbl_bienso.TabIndex = 135;
            this.Lbl_bienso.Text = "Biển số xe:";
            // 
            // Txt_ghichu
            // 
            this.Txt_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ghichu.Location = new System.Drawing.Point(671, 270);
            this.Txt_ghichu.Name = "Txt_ghichu";
            this.Txt_ghichu.Size = new System.Drawing.Size(348, 34);
            this.Txt_ghichu.TabIndex = 169;
            // 
            // Txt_giagui
            // 
            this.Txt_giagui.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_giagui.Location = new System.Drawing.Point(671, 220);
            this.Txt_giagui.Name = "Txt_giagui";
            this.Txt_giagui.Size = new System.Drawing.Size(348, 34);
            this.Txt_giagui.TabIndex = 168;
            // 
            // Lbl_ghichu
            // 
            this.Lbl_ghichu.AutoSize = true;
            this.Lbl_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ghichu.Location = new System.Drawing.Point(493, 270);
            this.Lbl_ghichu.Name = "Lbl_ghichu";
            this.Lbl_ghichu.Size = new System.Drawing.Size(108, 29);
            this.Lbl_ghichu.TabIndex = 167;
            this.Lbl_ghichu.Text = "Ghi chú:";
            // 
            // Lbl_giagui
            // 
            this.Lbl_giagui.AutoSize = true;
            this.Lbl_giagui.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_giagui.Location = new System.Drawing.Point(493, 220);
            this.Lbl_giagui.Name = "Lbl_giagui";
            this.Lbl_giagui.Size = new System.Drawing.Size(103, 29);
            this.Lbl_giagui.TabIndex = 166;
            this.Lbl_giagui.Text = "Giá gửi:";
            // 
            // Txt_mota
            // 
            this.Txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mota.Location = new System.Drawing.Point(671, 173);
            this.Txt_mota.Name = "Txt_mota";
            this.Txt_mota.Size = new System.Drawing.Size(348, 34);
            this.Txt_mota.TabIndex = 165;
            // 
            // Lbl_mota
            // 
            this.Lbl_mota.AutoSize = true;
            this.Lbl_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mota.Location = new System.Drawing.Point(493, 173);
            this.Lbl_mota.Name = "Lbl_mota";
            this.Lbl_mota.Size = new System.Drawing.Size(84, 29);
            this.Lbl_mota.TabIndex = 164;
            this.Lbl_mota.Text = "Mô tả:";
            // 
            // Lbl_ngayhethan
            // 
            this.Lbl_ngayhethan.AutoSize = true;
            this.Lbl_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ngayhethan.Location = new System.Drawing.Point(493, 125);
            this.Lbl_ngayhethan.Name = "Lbl_ngayhethan";
            this.Lbl_ngayhethan.Size = new System.Drawing.Size(172, 29);
            this.Lbl_ngayhethan.TabIndex = 162;
            this.Lbl_ngayhethan.Text = "Ngày hết hạn:";
            // 
            // Lbl_ngaydangky
            // 
            this.Lbl_ngaydangky.AutoSize = true;
            this.Lbl_ngaydangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ngaydangky.Location = new System.Drawing.Point(493, 80);
            this.Lbl_ngaydangky.Name = "Lbl_ngaydangky";
            this.Lbl_ngaydangky.Size = new System.Drawing.Size(177, 29);
            this.Lbl_ngaydangky.TabIndex = 160;
            this.Lbl_ngaydangky.Text = "Ngày đăng ký:";
            // 
            // Dtp_ngaydangky
            // 
            this.Dtp_ngaydangky.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngaydangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngaydangky.Location = new System.Drawing.Point(671, 80);
            this.Dtp_ngaydangky.Name = "Dtp_ngaydangky";
            this.Dtp_ngaydangky.Size = new System.Drawing.Size(348, 28);
            this.Dtp_ngaydangky.TabIndex = 228;
            // 
            // Dtp_ngayhethan
            // 
            this.Dtp_ngayhethan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngayhethan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngayhethan.Location = new System.Drawing.Point(671, 127);
            this.Dtp_ngayhethan.Name = "Dtp_ngayhethan";
            this.Dtp_ngayhethan.Size = new System.Drawing.Size(348, 28);
            this.Dtp_ngayhethan.TabIndex = 229;
            // 
            // Cbo_makhu
            // 
            this.Cbo_makhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_makhu.FormattingEnabled = true;
            this.Cbo_makhu.Location = new System.Drawing.Point(188, 222);
            this.Cbo_makhu.Name = "Cbo_makhu";
            this.Cbo_makhu.Size = new System.Drawing.Size(285, 37);
            this.Cbo_makhu.TabIndex = 230;
            // 
            // Cbo_maphong
            // 
            this.Cbo_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_maphong.FormattingEnabled = true;
            this.Cbo_maphong.Location = new System.Drawing.Point(188, 272);
            this.Cbo_maphong.Name = "Cbo_maphong";
            this.Cbo_maphong.Size = new System.Drawing.Size(285, 37);
            this.Cbo_maphong.TabIndex = 231;
            // 
            // Cbo_masinhvien
            // 
            this.Cbo_masinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_masinhvien.FormattingEnabled = true;
            this.Cbo_masinhvien.Location = new System.Drawing.Point(188, 175);
            this.Cbo_masinhvien.Name = "Cbo_masinhvien";
            this.Cbo_masinhvien.Size = new System.Drawing.Size(285, 37);
            this.Cbo_masinhvien.TabIndex = 232;
            // 
            // Frm_chinhsuaphuongtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 713);
            this.Controls.Add(this.Cbo_masinhvien);
            this.Controls.Add(this.Cbo_maphong);
            this.Controls.Add(this.Cbo_makhu);
            this.Controls.Add(this.Dtp_ngayhethan);
            this.Controls.Add(this.Dtp_ngaydangky);
            this.Controls.Add(this.Txt_ghichu);
            this.Controls.Add(this.Txt_giagui);
            this.Controls.Add(this.Lbl_ghichu);
            this.Controls.Add(this.Lbl_giagui);
            this.Controls.Add(this.Txt_mota);
            this.Controls.Add(this.Lbl_mota);
            this.Controls.Add(this.Lbl_ngayhethan);
            this.Controls.Add(this.Lbl_ngaydangky);
            this.Controls.Add(this.Lbl_maphong);
            this.Controls.Add(this.Lbl_makhu);
            this.Controls.Add(this.DataGrid_chinhsuaphuongtien);
            this.Controls.Add(this.Lbl_masinhvien);
            this.Controls.Add(this.Txt_tenchuxe);
            this.Controls.Add(this.Lbl_tenchuxe);
            this.Controls.Add(this.Btn_xoadulieu);
            this.Controls.Add(this.Btn_suadulieu);
            this.Controls.Add(this.Btn_chendulieu);
            this.Controls.Add(this.Btn_thoat);
            this.Controls.Add(this.Btn_taomoi);
            this.Controls.Add(this.Lbl_quanlyphuongtien);
            this.Controls.Add(this.Txt_bienso);
            this.Controls.Add(this.Lbl_bienso);
            this.Name = "Frm_chinhsuaphuongtien";
            this.Text = "Frm_chinhsuaphuongtien";
            this.Load += new System.EventHandler(this.Frm_chinhsuaphuongtien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_chinhsuaphuongtien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_maphong;
        private System.Windows.Forms.Label Lbl_makhu;
        private System.Windows.Forms.DataGridView DataGrid_chinhsuaphuongtien;
        private System.Windows.Forms.Label Lbl_masinhvien;
        private System.Windows.Forms.TextBox Txt_tenchuxe;
        private System.Windows.Forms.Label Lbl_tenchuxe;
        private System.Windows.Forms.Button Btn_xoadulieu;
        private System.Windows.Forms.Button Btn_suadulieu;
        private System.Windows.Forms.Button Btn_chendulieu;
        private System.Windows.Forms.Button Btn_thoat;
        private System.Windows.Forms.Button Btn_taomoi;
        private System.Windows.Forms.Label Lbl_quanlyphuongtien;
        private System.Windows.Forms.TextBox Txt_bienso;
        private System.Windows.Forms.Label Lbl_bienso;
        private System.Windows.Forms.TextBox Txt_ghichu;
        private System.Windows.Forms.TextBox Txt_giagui;
        private System.Windows.Forms.Label Lbl_ghichu;
        private System.Windows.Forms.Label Lbl_giagui;
        private System.Windows.Forms.TextBox Txt_mota;
        private System.Windows.Forms.Label Lbl_mota;
        private System.Windows.Forms.Label Lbl_ngayhethan;
        private System.Windows.Forms.Label Lbl_ngaydangky;
        private System.Windows.Forms.DateTimePicker Dtp_ngaydangky;
        private System.Windows.Forms.DateTimePicker Dtp_ngayhethan;
        private System.Windows.Forms.ComboBox Cbo_makhu;
        private System.Windows.Forms.ComboBox Cbo_maphong;
        private System.Windows.Forms.ComboBox Cbo_masinhvien;
    }
}