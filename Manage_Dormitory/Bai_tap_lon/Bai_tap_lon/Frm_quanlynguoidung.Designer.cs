namespace Bai_tap_lon
{
    partial class Frm_quanlynguoidung
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
            this.DataGrid_quanlynguoidung = new System.Windows.Forms.DataGridView();
            this.Txt_hoten = new System.Windows.Forms.TextBox();
            this.Lbl_hoten = new System.Windows.Forms.Label();
            this.Txt_matkhau = new System.Windows.Forms.TextBox();
            this.Lbl_matkhau = new System.Windows.Forms.Label();
            this.Btn_xoadulieu = new System.Windows.Forms.Button();
            this.Btn_suadulieu = new System.Windows.Forms.Button();
            this.Btn_chendulieu = new System.Windows.Forms.Button();
            this.Btn_thoat = new System.Windows.Forms.Button();
            this.Btn_taomoi = new System.Windows.Forms.Button();
            this.Lbl_quanlytaikhoan = new System.Windows.Forms.Label();
            this.Txt_taikhoan = new System.Windows.Forms.TextBox();
            this.Lbl_taikhoan = new System.Windows.Forms.Label();
            this.Lbl_quyen = new System.Windows.Forms.Label();
            this.Rb_admin = new System.Windows.Forms.RadioButton();
            this.Rb_user = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_quanlynguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_quanlynguoidung
            // 
            this.DataGrid_quanlynguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_quanlynguoidung.Location = new System.Drawing.Point(32, 297);
            this.DataGrid_quanlynguoidung.Name = "DataGrid_quanlynguoidung";
            this.DataGrid_quanlynguoidung.RowHeadersWidth = 51;
            this.DataGrid_quanlynguoidung.RowTemplate.Height = 24;
            this.DataGrid_quanlynguoidung.Size = new System.Drawing.Size(754, 301);
            this.DataGrid_quanlynguoidung.TabIndex = 122;
            this.DataGrid_quanlynguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_quanlynguoidung_CellContentClick);
            // 
            // Txt_hoten
            // 
            this.Txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_hoten.Location = new System.Drawing.Point(190, 208);
            this.Txt_hoten.Name = "Txt_hoten";
            this.Txt_hoten.Size = new System.Drawing.Size(574, 34);
            this.Txt_hoten.TabIndex = 121;
            // 
            // Lbl_hoten
            // 
            this.Lbl_hoten.AutoSize = true;
            this.Lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hoten.Location = new System.Drawing.Point(77, 208);
            this.Lbl_hoten.Name = "Lbl_hoten";
            this.Lbl_hoten.Size = new System.Drawing.Size(96, 29);
            this.Lbl_hoten.TabIndex = 120;
            this.Lbl_hoten.Text = "Họ tên:";
            // 
            // Txt_matkhau
            // 
            this.Txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_matkhau.Location = new System.Drawing.Point(190, 160);
            this.Txt_matkhau.Name = "Txt_matkhau";
            this.Txt_matkhau.PasswordChar = '*';
            this.Txt_matkhau.Size = new System.Drawing.Size(574, 34);
            this.Txt_matkhau.TabIndex = 119;
            // 
            // Lbl_matkhau
            // 
            this.Lbl_matkhau.AutoSize = true;
            this.Lbl_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_matkhau.Location = new System.Drawing.Point(49, 160);
            this.Lbl_matkhau.Name = "Lbl_matkhau";
            this.Lbl_matkhau.Size = new System.Drawing.Size(124, 29);
            this.Lbl_matkhau.TabIndex = 118;
            this.Lbl_matkhau.Text = "Mật khẩu:";
            // 
            // Btn_xoadulieu
            // 
            this.Btn_xoadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoadulieu.Location = new System.Drawing.Point(806, 422);
            this.Btn_xoadulieu.Name = "Btn_xoadulieu";
            this.Btn_xoadulieu.Size = new System.Drawing.Size(153, 73);
            this.Btn_xoadulieu.TabIndex = 117;
            this.Btn_xoadulieu.Text = "Xóa dữ liệu";
            this.Btn_xoadulieu.UseVisualStyleBackColor = true;
            this.Btn_xoadulieu.Click += new System.EventHandler(this.Btn_xoadulieu_Click);
            // 
            // Btn_suadulieu
            // 
            this.Btn_suadulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_suadulieu.Location = new System.Drawing.Point(806, 320);
            this.Btn_suadulieu.Name = "Btn_suadulieu";
            this.Btn_suadulieu.Size = new System.Drawing.Size(153, 75);
            this.Btn_suadulieu.TabIndex = 116;
            this.Btn_suadulieu.Text = "Sửa dữ liệu";
            this.Btn_suadulieu.UseVisualStyleBackColor = true;
            this.Btn_suadulieu.Click += new System.EventHandler(this.Btn_suadulieu_Click);
            // 
            // Btn_chendulieu
            // 
            this.Btn_chendulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_chendulieu.Location = new System.Drawing.Point(806, 212);
            this.Btn_chendulieu.Name = "Btn_chendulieu";
            this.Btn_chendulieu.Size = new System.Drawing.Size(153, 79);
            this.Btn_chendulieu.TabIndex = 115;
            this.Btn_chendulieu.Text = "Chèn dữ liệu";
            this.Btn_chendulieu.UseVisualStyleBackColor = true;
            this.Btn_chendulieu.Click += new System.EventHandler(this.Btn_chendulieu_Click);
            // 
            // Btn_thoat
            // 
            this.Btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thoat.Location = new System.Drawing.Point(806, 527);
            this.Btn_thoat.Name = "Btn_thoat";
            this.Btn_thoat.Size = new System.Drawing.Size(153, 71);
            this.Btn_thoat.TabIndex = 114;
            this.Btn_thoat.Text = "Thoát";
            this.Btn_thoat.UseVisualStyleBackColor = true;
            this.Btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // Btn_taomoi
            // 
            this.Btn_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_taomoi.Location = new System.Drawing.Point(806, 113);
            this.Btn_taomoi.Name = "Btn_taomoi";
            this.Btn_taomoi.Size = new System.Drawing.Size(153, 72);
            this.Btn_taomoi.TabIndex = 113;
            this.Btn_taomoi.Text = "Tạo mới";
            this.Btn_taomoi.UseVisualStyleBackColor = true;
            this.Btn_taomoi.Click += new System.EventHandler(this.Btn_taomoi_Click);
            // 
            // Lbl_quanlytaikhoan
            // 
            this.Lbl_quanlytaikhoan.AutoSize = true;
            this.Lbl_quanlytaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_quanlytaikhoan.Location = new System.Drawing.Point(202, 34);
            this.Lbl_quanlytaikhoan.Name = "Lbl_quanlytaikhoan";
            this.Lbl_quanlytaikhoan.Size = new System.Drawing.Size(600, 38);
            this.Lbl_quanlytaikhoan.TabIndex = 112;
            this.Lbl_quanlytaikhoan.Text = "QUẢN LÝ TÀI KHOẢN NGƯỜI DÙNG";
            // 
            // Txt_taikhoan
            // 
            this.Txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_taikhoan.Location = new System.Drawing.Point(190, 112);
            this.Txt_taikhoan.Name = "Txt_taikhoan";
            this.Txt_taikhoan.Size = new System.Drawing.Size(574, 34);
            this.Txt_taikhoan.TabIndex = 111;
            // 
            // Lbl_taikhoan
            // 
            this.Lbl_taikhoan.AutoSize = true;
            this.Lbl_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_taikhoan.Location = new System.Drawing.Point(38, 113);
            this.Lbl_taikhoan.Name = "Lbl_taikhoan";
            this.Lbl_taikhoan.Size = new System.Drawing.Size(135, 29);
            this.Lbl_taikhoan.TabIndex = 110;
            this.Lbl_taikhoan.Text = "Tài khoản:";
            // 
            // Lbl_quyen
            // 
            this.Lbl_quyen.AutoSize = true;
            this.Lbl_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_quyen.Location = new System.Drawing.Point(79, 250);
            this.Lbl_quyen.Name = "Lbl_quyen";
            this.Lbl_quyen.Size = new System.Drawing.Size(95, 29);
            this.Lbl_quyen.TabIndex = 125;
            this.Lbl_quyen.Text = "Quyền:";
            // 
            // Rb_admin
            // 
            this.Rb_admin.AutoSize = true;
            this.Rb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_admin.Location = new System.Drawing.Point(288, 258);
            this.Rb_admin.Name = "Rb_admin";
            this.Rb_admin.Size = new System.Drawing.Size(107, 33);
            this.Rb_admin.TabIndex = 132;
            this.Rb_admin.TabStop = true;
            this.Rb_admin.Text = "Admin";
            this.Rb_admin.UseVisualStyleBackColor = true;
            // 
            // Rb_user
            // 
            this.Rb_user.AutoSize = true;
            this.Rb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_user.Location = new System.Drawing.Point(550, 258);
            this.Rb_user.Name = "Rb_user";
            this.Rb_user.Size = new System.Drawing.Size(89, 33);
            this.Rb_user.TabIndex = 134;
            this.Rb_user.TabStop = true;
            this.Rb_user.Text = "User";
            this.Rb_user.UseVisualStyleBackColor = true;
            // 
            // Frm_quanlynguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 617);
            this.Controls.Add(this.Rb_user);
            this.Controls.Add(this.Rb_admin);
            this.Controls.Add(this.Lbl_quyen);
            this.Controls.Add(this.DataGrid_quanlynguoidung);
            this.Controls.Add(this.Txt_hoten);
            this.Controls.Add(this.Lbl_hoten);
            this.Controls.Add(this.Txt_matkhau);
            this.Controls.Add(this.Lbl_matkhau);
            this.Controls.Add(this.Btn_xoadulieu);
            this.Controls.Add(this.Btn_suadulieu);
            this.Controls.Add(this.Btn_chendulieu);
            this.Controls.Add(this.Btn_thoat);
            this.Controls.Add(this.Btn_taomoi);
            this.Controls.Add(this.Lbl_quanlytaikhoan);
            this.Controls.Add(this.Txt_taikhoan);
            this.Controls.Add(this.Lbl_taikhoan);
            this.Name = "Frm_quanlynguoidung";
            this.Text = "Frm_quanlynguoidung";
            this.Load += new System.EventHandler(this.Frm_quanlynguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_quanlynguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_quanlynguoidung;
        private System.Windows.Forms.TextBox Txt_hoten;
        private System.Windows.Forms.Label Lbl_hoten;
        private System.Windows.Forms.TextBox Txt_matkhau;
        private System.Windows.Forms.Label Lbl_matkhau;
        private System.Windows.Forms.Button Btn_xoadulieu;
        private System.Windows.Forms.Button Btn_suadulieu;
        private System.Windows.Forms.Button Btn_chendulieu;
        private System.Windows.Forms.Button Btn_thoat;
        private System.Windows.Forms.Button Btn_taomoi;
        private System.Windows.Forms.Label Lbl_quanlytaikhoan;
        private System.Windows.Forms.TextBox Txt_taikhoan;
        private System.Windows.Forms.Label Lbl_taikhoan;
        private System.Windows.Forms.Label Lbl_quyen;
        private System.Windows.Forms.RadioButton Rb_admin;
        private System.Windows.Forms.RadioButton Rb_user;
    }
}