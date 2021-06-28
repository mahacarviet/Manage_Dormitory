namespace Bai_tap_lon
{
    partial class Frm_dangnhap
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
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_dangnhaphethong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.Txt_matkhau = new System.Windows.Forms.TextBox();
            this.Txt_dangnhap = new System.Windows.Forms.TextBox();
            this.Btn_thoat = new System.Windows.Forms.Button();
            this.Btn_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.Location = new System.Drawing.Point(61, 216);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(156, 32);
            this.lbl_matkhau.TabIndex = 15;
            this.lbl_matkhau.Text = "Mật khẩu: ";
            // 
            // lbl_dangnhaphethong
            // 
            this.lbl_dangnhaphethong.AutoSize = true;
            this.lbl_dangnhaphethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangnhaphethong.Location = new System.Drawing.Point(190, 53);
            this.lbl_dangnhaphethong.Name = "lbl_dangnhaphethong";
            this.lbl_dangnhaphethong.Size = new System.Drawing.Size(428, 51);
            this.lbl_dangnhaphethong.TabIndex = 14;
            this.lbl_dangnhaphethong.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.AutoSize = true;
            this.lbl_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangnhap.Location = new System.Drawing.Point(61, 169);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(166, 32);
            this.lbl_dangnhap.TabIndex = 12;
            this.lbl_dangnhap.Text = "Tài khoản: ";
            // 
            // Txt_matkhau
            // 
            this.Txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_matkhau.Location = new System.Drawing.Point(256, 216);
            this.Txt_matkhau.Name = "Txt_matkhau";
            this.Txt_matkhau.PasswordChar = '*';
            this.Txt_matkhau.Size = new System.Drawing.Size(423, 34);
            this.Txt_matkhau.TabIndex = 11;
            // 
            // Txt_dangnhap
            // 
            this.Txt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dangnhap.Location = new System.Drawing.Point(256, 169);
            this.Txt_dangnhap.Name = "Txt_dangnhap";
            this.Txt_dangnhap.Size = new System.Drawing.Size(423, 34);
            this.Txt_dangnhap.TabIndex = 10;
            // 
            // Btn_thoat
            // 
            this.Btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_thoat.Location = new System.Drawing.Point(522, 326);
            this.Btn_thoat.Name = "Btn_thoat";
            this.Btn_thoat.Size = new System.Drawing.Size(157, 72);
            this.Btn_thoat.TabIndex = 9;
            this.Btn_thoat.Text = "Thoát";
            this.Btn_thoat.UseVisualStyleBackColor = true;
            this.Btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // Btn_dangnhap
            // 
            this.Btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dangnhap.Location = new System.Drawing.Point(149, 326);
            this.Btn_dangnhap.Name = "Btn_dangnhap";
            this.Btn_dangnhap.Size = new System.Drawing.Size(158, 72);
            this.Btn_dangnhap.TabIndex = 8;
            this.Btn_dangnhap.Text = "Đăng nhập";
            this.Btn_dangnhap.UseVisualStyleBackColor = true;
            this.Btn_dangnhap.Click += new System.EventHandler(this.Btn_dangnhap_Click);
            // 
            // Frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_dangnhaphethong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dangnhap);
            this.Controls.Add(this.Txt_matkhau);
            this.Controls.Add(this.Txt_dangnhap);
            this.Controls.Add(this.Btn_thoat);
            this.Controls.Add(this.Btn_dangnhap);
            this.Name = "Frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_dangnhaphethong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.TextBox Txt_matkhau;
        private System.Windows.Forms.TextBox Txt_dangnhap;
        private System.Windows.Forms.Button Btn_thoat;
        private System.Windows.Forms.Button Btn_dangnhap;
    }
}