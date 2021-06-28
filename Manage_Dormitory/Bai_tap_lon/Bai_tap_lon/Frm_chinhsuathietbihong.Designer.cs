namespace Bai_tap_lon
{
    partial class Frm_chinhsuathietbihong
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
            this.DataGrid_chinhsuathietbihong = new System.Windows.Forms.DataGridView();
            this.Lbl_soluonghong = new System.Windows.Forms.Label();
            this.Lbl_maphong = new System.Windows.Forms.Label();
            this.Lbl_makhu = new System.Windows.Forms.Label();
            this.Btn_xoadulieu = new System.Windows.Forms.Button();
            this.Btn_suadulieu = new System.Windows.Forms.Button();
            this.Btn_chendulieu = new System.Windows.Forms.Button();
            this.Btn_thoat = new System.Windows.Forms.Button();
            this.Txt_mathietbi = new System.Windows.Forms.TextBox();
            this.Btn_taomoi = new System.Windows.Forms.Button();
            this.Lbl_chinhsuathietbihong = new System.Windows.Forms.Label();
            this.Lbl_mathietbi = new System.Windows.Forms.Label();
            this.Lbl_ngaylapdat = new System.Windows.Forms.Label();
            this.Lbl_ngayhetbaohanh = new System.Windows.Forms.Label();
            this.Nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.Dtp_ngaylapdat = new System.Windows.Forms.DateTimePicker();
            this.Dtp_ngayhetbaohanh = new System.Windows.Forms.DateTimePicker();
            this.Cbo_makhu = new System.Windows.Forms.ComboBox();
            this.Cbo_maphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_chinhsuathietbihong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_chinhsuathietbihong
            // 
            this.DataGrid_chinhsuathietbihong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_chinhsuathietbihong.Location = new System.Drawing.Point(51, 360);
            this.DataGrid_chinhsuathietbihong.Name = "DataGrid_chinhsuathietbihong";
            this.DataGrid_chinhsuathietbihong.RowHeadersWidth = 51;
            this.DataGrid_chinhsuathietbihong.RowTemplate.Height = 24;
            this.DataGrid_chinhsuathietbihong.Size = new System.Drawing.Size(756, 265);
            this.DataGrid_chinhsuathietbihong.TabIndex = 221;
            // 
            // Lbl_soluonghong
            // 
            this.Lbl_soluonghong.AutoSize = true;
            this.Lbl_soluonghong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_soluonghong.Location = new System.Drawing.Point(46, 218);
            this.Lbl_soluonghong.Name = "Lbl_soluonghong";
            this.Lbl_soluonghong.Size = new System.Drawing.Size(189, 29);
            this.Lbl_soluonghong.TabIndex = 218;
            this.Lbl_soluonghong.Text = "Số lượng hỏng:";
            // 
            // Lbl_maphong
            // 
            this.Lbl_maphong.AutoSize = true;
            this.Lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_maphong.Location = new System.Drawing.Point(47, 171);
            this.Lbl_maphong.Name = "Lbl_maphong";
            this.Lbl_maphong.Size = new System.Drawing.Size(135, 29);
            this.Lbl_maphong.TabIndex = 217;
            this.Lbl_maphong.Text = "Mã phòng:";
            // 
            // Lbl_makhu
            // 
            this.Lbl_makhu.AutoSize = true;
            this.Lbl_makhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_makhu.Location = new System.Drawing.Point(46, 123);
            this.Lbl_makhu.Name = "Lbl_makhu";
            this.Lbl_makhu.Size = new System.Drawing.Size(103, 29);
            this.Lbl_makhu.TabIndex = 215;
            this.Lbl_makhu.Text = "Mã khu:";
            // 
            // Btn_xoadulieu
            // 
            this.Btn_xoadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoadulieu.Location = new System.Drawing.Point(831, 433);
            this.Btn_xoadulieu.Name = "Btn_xoadulieu";
            this.Btn_xoadulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_xoadulieu.TabIndex = 214;
            this.Btn_xoadulieu.Text = "Xóa dữ liệu";
            this.Btn_xoadulieu.UseVisualStyleBackColor = true;
            this.Btn_xoadulieu.Click += new System.EventHandler(this.Btn_xoadulieu_Click);
            // 
            // Btn_suadulieu
            // 
            this.Btn_suadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_suadulieu.Location = new System.Drawing.Point(831, 320);
            this.Btn_suadulieu.Name = "Btn_suadulieu";
            this.Btn_suadulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_suadulieu.TabIndex = 213;
            this.Btn_suadulieu.Text = "Sửa dữ liệu";
            this.Btn_suadulieu.UseVisualStyleBackColor = true;
            this.Btn_suadulieu.Click += new System.EventHandler(this.Btn_suadulieu_Click);
            // 
            // Btn_chendulieu
            // 
            this.Btn_chendulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_chendulieu.Location = new System.Drawing.Point(831, 197);
            this.Btn_chendulieu.Name = "Btn_chendulieu";
            this.Btn_chendulieu.Size = new System.Drawing.Size(153, 72);
            this.Btn_chendulieu.TabIndex = 212;
            this.Btn_chendulieu.Text = "Chèn dữ liệu";
            this.Btn_chendulieu.UseVisualStyleBackColor = true;
            this.Btn_chendulieu.Click += new System.EventHandler(this.Btn_chendulieu_Click);
            // 
            // Btn_thoat
            // 
            this.Btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thoat.Location = new System.Drawing.Point(831, 553);
            this.Btn_thoat.Name = "Btn_thoat";
            this.Btn_thoat.Size = new System.Drawing.Size(153, 72);
            this.Btn_thoat.TabIndex = 211;
            this.Btn_thoat.Text = "Thoát";
            this.Btn_thoat.UseVisualStyleBackColor = true;
            this.Btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // Txt_mathietbi
            // 
            this.Txt_mathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mathietbi.Location = new System.Drawing.Point(289, 77);
            this.Txt_mathietbi.Name = "Txt_mathietbi";
            this.Txt_mathietbi.Size = new System.Drawing.Size(518, 34);
            this.Txt_mathietbi.TabIndex = 208;
            // 
            // Btn_taomoi
            // 
            this.Btn_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_taomoi.Location = new System.Drawing.Point(831, 77);
            this.Btn_taomoi.Name = "Btn_taomoi";
            this.Btn_taomoi.Size = new System.Drawing.Size(153, 72);
            this.Btn_taomoi.TabIndex = 210;
            this.Btn_taomoi.Text = "Tạo mới";
            this.Btn_taomoi.UseVisualStyleBackColor = true;
            this.Btn_taomoi.Click += new System.EventHandler(this.Btn_taomoi_Click);
            // 
            // Lbl_chinhsuathietbihong
            // 
            this.Lbl_chinhsuathietbihong.AutoSize = true;
            this.Lbl_chinhsuathietbihong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_chinhsuathietbihong.Location = new System.Drawing.Point(282, 20);
            this.Lbl_chinhsuathietbihong.Name = "Lbl_chinhsuathietbihong";
            this.Lbl_chinhsuathietbihong.Size = new System.Drawing.Size(472, 38);
            this.Lbl_chinhsuathietbihong.TabIndex = 209;
            this.Lbl_chinhsuathietbihong.Text = "CHỈNH SỬA THIẾT BỊ HỎNG";
            // 
            // Lbl_mathietbi
            // 
            this.Lbl_mathietbi.AutoSize = true;
            this.Lbl_mathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mathietbi.Location = new System.Drawing.Point(46, 77);
            this.Lbl_mathietbi.Name = "Lbl_mathietbi";
            this.Lbl_mathietbi.Size = new System.Drawing.Size(141, 29);
            this.Lbl_mathietbi.TabIndex = 207;
            this.Lbl_mathietbi.Text = "Mã thiết bị:";
            // 
            // Lbl_ngaylapdat
            // 
            this.Lbl_ngaylapdat.AutoSize = true;
            this.Lbl_ngaylapdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ngaylapdat.Location = new System.Drawing.Point(46, 264);
            this.Lbl_ngaylapdat.Name = "Lbl_ngaylapdat";
            this.Lbl_ngaylapdat.Size = new System.Drawing.Size(166, 29);
            this.Lbl_ngaylapdat.TabIndex = 222;
            this.Lbl_ngaylapdat.Text = "Ngày lắp đặt:";
            // 
            // Lbl_ngayhetbaohanh
            // 
            this.Lbl_ngayhetbaohanh.AutoSize = true;
            this.Lbl_ngayhetbaohanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ngayhetbaohanh.Location = new System.Drawing.Point(47, 308);
            this.Lbl_ngayhetbaohanh.Name = "Lbl_ngayhetbaohanh";
            this.Lbl_ngayhetbaohanh.Size = new System.Drawing.Size(237, 29);
            this.Lbl_ngayhetbaohanh.TabIndex = 224;
            this.Lbl_ngayhetbaohanh.Text = "Ngày hết bảo hành:";
            // 
            // Nud_soluong
            // 
            this.Nud_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_soluong.Location = new System.Drawing.Point(289, 218);
            this.Nud_soluong.Name = "Nud_soluong";
            this.Nud_soluong.Size = new System.Drawing.Size(518, 34);
            this.Nud_soluong.TabIndex = 226;
            // 
            // Dtp_ngaylapdat
            // 
            this.Dtp_ngaylapdat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngaylapdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngaylapdat.Location = new System.Drawing.Point(289, 264);
            this.Dtp_ngaylapdat.Name = "Dtp_ngaylapdat";
            this.Dtp_ngaylapdat.Size = new System.Drawing.Size(518, 34);
            this.Dtp_ngaylapdat.TabIndex = 227;
            // 
            // Dtp_ngayhetbaohanh
            // 
            this.Dtp_ngayhetbaohanh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngayhetbaohanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ngayhetbaohanh.Location = new System.Drawing.Point(289, 308);
            this.Dtp_ngayhetbaohanh.Name = "Dtp_ngayhetbaohanh";
            this.Dtp_ngayhetbaohanh.Size = new System.Drawing.Size(518, 34);
            this.Dtp_ngayhetbaohanh.TabIndex = 228;
            // 
            // Cbo_makhu
            // 
            this.Cbo_makhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_makhu.FormattingEnabled = true;
            this.Cbo_makhu.Location = new System.Drawing.Point(289, 123);
            this.Cbo_makhu.Name = "Cbo_makhu";
            this.Cbo_makhu.Size = new System.Drawing.Size(518, 37);
            this.Cbo_makhu.TabIndex = 229;
            // 
            // Cbo_maphong
            // 
            this.Cbo_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_maphong.FormattingEnabled = true;
            this.Cbo_maphong.Location = new System.Drawing.Point(289, 171);
            this.Cbo_maphong.Name = "Cbo_maphong";
            this.Cbo_maphong.Size = new System.Drawing.Size(518, 37);
            this.Cbo_maphong.TabIndex = 230;
            // 
            // Frm_chinhsuathietbihong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 649);
            this.Controls.Add(this.Cbo_maphong);
            this.Controls.Add(this.Cbo_makhu);
            this.Controls.Add(this.Dtp_ngayhetbaohanh);
            this.Controls.Add(this.Dtp_ngaylapdat);
            this.Controls.Add(this.Nud_soluong);
            this.Controls.Add(this.Lbl_ngayhetbaohanh);
            this.Controls.Add(this.Lbl_ngaylapdat);
            this.Controls.Add(this.DataGrid_chinhsuathietbihong);
            this.Controls.Add(this.Lbl_soluonghong);
            this.Controls.Add(this.Lbl_maphong);
            this.Controls.Add(this.Lbl_makhu);
            this.Controls.Add(this.Btn_xoadulieu);
            this.Controls.Add(this.Btn_suadulieu);
            this.Controls.Add(this.Btn_chendulieu);
            this.Controls.Add(this.Btn_thoat);
            this.Controls.Add(this.Txt_mathietbi);
            this.Controls.Add(this.Btn_taomoi);
            this.Controls.Add(this.Lbl_chinhsuathietbihong);
            this.Controls.Add(this.Lbl_mathietbi);
            this.Name = "Frm_chinhsuathietbihong";
            this.Text = "Frm_chinhsuathietbihong";
            this.Load += new System.EventHandler(this.Frm_chinhsuathietbihong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_chinhsuathietbihong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_chinhsuathietbihong;
        private System.Windows.Forms.Label Lbl_soluonghong;
        private System.Windows.Forms.Label Lbl_maphong;
        private System.Windows.Forms.Label Lbl_makhu;
        private System.Windows.Forms.Button Btn_xoadulieu;
        private System.Windows.Forms.Button Btn_suadulieu;
        private System.Windows.Forms.Button Btn_chendulieu;
        private System.Windows.Forms.Button Btn_thoat;
        private System.Windows.Forms.TextBox Txt_mathietbi;
        private System.Windows.Forms.Button Btn_taomoi;
        private System.Windows.Forms.Label Lbl_chinhsuathietbihong;
        private System.Windows.Forms.Label Lbl_mathietbi;
        private System.Windows.Forms.Label Lbl_ngaylapdat;
        private System.Windows.Forms.Label Lbl_ngayhetbaohanh;
        private System.Windows.Forms.NumericUpDown Nud_soluong;
        private System.Windows.Forms.DateTimePicker Dtp_ngaylapdat;
        private System.Windows.Forms.DateTimePicker Dtp_ngayhetbaohanh;
        private System.Windows.Forms.ComboBox Cbo_makhu;
        private System.Windows.Forms.ComboBox Cbo_maphong;
    }
}