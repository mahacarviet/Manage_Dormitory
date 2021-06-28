namespace Bai_tap_lon
{
    partial class Frm_timkiemphong
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
            this.RB_nhapmaphong = new System.Windows.Forms.RadioButton();
            this.Rb_maphong = new System.Windows.Forms.RadioButton();
            this.DataGrid_timkiemphong = new System.Windows.Forms.DataGridView();
            this.Btn_timkiem = new System.Windows.Forms.Button();
            this.Btn_thoat = new System.Windows.Forms.Button();
            this.Lbl_timkiem = new System.Windows.Forms.Label();
            this.Txt_maphong = new System.Windows.Forms.TextBox();
            this.Lbl_nhapma = new System.Windows.Forms.Label();
            this.Cbo_maphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_timkiemphong)).BeginInit();
            this.SuspendLayout();
            // 
            // RB_nhapmaphong
            // 
            this.RB_nhapmaphong.AutoSize = true;
            this.RB_nhapmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_nhapmaphong.Location = new System.Drawing.Point(45, 210);
            this.RB_nhapmaphong.Name = "RB_nhapmaphong";
            this.RB_nhapmaphong.Size = new System.Drawing.Size(225, 33);
            this.RB_nhapmaphong.TabIndex = 143;
            this.RB_nhapmaphong.TabStop = true;
            this.RB_nhapmaphong.Text = "Nhập mã phòng:";
            this.RB_nhapmaphong.UseVisualStyleBackColor = true;
            // 
            // Rb_maphong
            // 
            this.Rb_maphong.AutoSize = true;
            this.Rb_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_maphong.Location = new System.Drawing.Point(45, 108);
            this.Rb_maphong.Name = "Rb_maphong";
            this.Rb_maphong.Size = new System.Drawing.Size(225, 33);
            this.Rb_maphong.TabIndex = 141;
            this.Rb_maphong.TabStop = true;
            this.Rb_maphong.Text = "Nhập mã phòng:";
            this.Rb_maphong.UseVisualStyleBackColor = true;
            this.Rb_maphong.CheckedChanged += new System.EventHandler(this.Rb_masinhvien_CheckedChanged);
            // 
            // DataGrid_timkiemphong
            // 
            this.DataGrid_timkiemphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_timkiemphong.Location = new System.Drawing.Point(40, 275);
            this.DataGrid_timkiemphong.Name = "DataGrid_timkiemphong";
            this.DataGrid_timkiemphong.RowHeadersWidth = 51;
            this.DataGrid_timkiemphong.RowTemplate.Height = 24;
            this.DataGrid_timkiemphong.Size = new System.Drawing.Size(946, 313);
            this.DataGrid_timkiemphong.TabIndex = 140;
            // 
            // Btn_timkiem
            // 
            this.Btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_timkiem.Location = new System.Drawing.Point(833, 96);
            this.Btn_timkiem.Name = "Btn_timkiem";
            this.Btn_timkiem.Size = new System.Drawing.Size(153, 71);
            this.Btn_timkiem.TabIndex = 135;
            this.Btn_timkiem.Text = "Tìm kiếm";
            this.Btn_timkiem.UseVisualStyleBackColor = true;
            this.Btn_timkiem.Click += new System.EventHandler(this.Btn_timkiem_Click);
            // 
            // Btn_thoat
            // 
            this.Btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thoat.Location = new System.Drawing.Point(833, 190);
            this.Btn_thoat.Name = "Btn_thoat";
            this.Btn_thoat.Size = new System.Drawing.Size(153, 69);
            this.Btn_thoat.TabIndex = 136;
            this.Btn_thoat.Text = "Thoát";
            this.Btn_thoat.UseVisualStyleBackColor = true;
            this.Btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // Lbl_timkiem
            // 
            this.Lbl_timkiem.AutoSize = true;
            this.Lbl_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_timkiem.Location = new System.Drawing.Point(264, 26);
            this.Lbl_timkiem.Name = "Lbl_timkiem";
            this.Lbl_timkiem.Size = new System.Drawing.Size(505, 38);
            this.Lbl_timkiem.TabIndex = 138;
            this.Lbl_timkiem.Text = "TÌM KIẾM THÔNG TIN PHÒNG";
            // 
            // Txt_maphong
            // 
            this.Txt_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_maphong.Location = new System.Drawing.Point(310, 111);
            this.Txt_maphong.Name = "Txt_maphong";
            this.Txt_maphong.Size = new System.Drawing.Size(477, 34);
            this.Txt_maphong.TabIndex = 132;
            this.Txt_maphong.TextChanged += new System.EventHandler(this.Txt_masinhvien_TextChanged);
            // 
            // Lbl_nhapma
            // 
            this.Lbl_nhapma.AutoSize = true;
            this.Lbl_nhapma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nhapma.Location = new System.Drawing.Point(61, 108);
            this.Lbl_nhapma.Name = "Lbl_nhapma";
            this.Lbl_nhapma.Size = new System.Drawing.Size(0, 25);
            this.Lbl_nhapma.TabIndex = 137;
            this.Lbl_nhapma.Click += new System.EventHandler(this.Lbl_nhapma_Click);
            // 
            // Cbo_maphong
            // 
            this.Cbo_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_maphong.FormattingEnabled = true;
            this.Cbo_maphong.Location = new System.Drawing.Point(310, 210);
            this.Cbo_maphong.Name = "Cbo_maphong";
            this.Cbo_maphong.Size = new System.Drawing.Size(477, 37);
            this.Cbo_maphong.TabIndex = 144;
            // 
            // Frm_timkiemphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.Cbo_maphong);
            this.Controls.Add(this.RB_nhapmaphong);
            this.Controls.Add(this.Rb_maphong);
            this.Controls.Add(this.DataGrid_timkiemphong);
            this.Controls.Add(this.Btn_timkiem);
            this.Controls.Add(this.Btn_thoat);
            this.Controls.Add(this.Lbl_timkiem);
            this.Controls.Add(this.Txt_maphong);
            this.Controls.Add(this.Lbl_nhapma);
            this.Name = "Frm_timkiemphong";
            this.Text = "Frm_timkiemphong";
            this.Load += new System.EventHandler(this.Frm_timkiemphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_timkiemphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RB_nhapmaphong;
        private System.Windows.Forms.RadioButton Rb_maphong;
        private System.Windows.Forms.DataGridView DataGrid_timkiemphong;
        private System.Windows.Forms.Button Btn_timkiem;
        private System.Windows.Forms.Button Btn_thoat;
        private System.Windows.Forms.Label Lbl_timkiem;
        private System.Windows.Forms.TextBox Txt_maphong;
        private System.Windows.Forms.Label Lbl_nhapma;
        private System.Windows.Forms.ComboBox Cbo_maphong;
    }
}