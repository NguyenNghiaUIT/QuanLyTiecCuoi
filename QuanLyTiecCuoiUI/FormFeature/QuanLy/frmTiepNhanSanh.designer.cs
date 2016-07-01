namespace QuanLyTiecCuoiUI
{
    partial class frmTiepNhanSanh
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
            this.lblTenSanh = new System.Windows.Forms.Label();
            this.lblLoaiSanh = new System.Windows.Forms.Label();
            this.lblDonGiaBanTT = new System.Windows.Forms.Label();
            this.lblSoLuongBanTD = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.cbbLoaiSanh = new System.Windows.Forms.ComboBox();
            this.cbbDonGiaBanTT = new System.Windows.Forms.ComboBox();
            this.txtSoLuongBanTD = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenSanh
            // 
            this.lblTenSanh.AutoSize = true;
            this.lblTenSanh.Location = new System.Drawing.Point(13, 16);
            this.lblTenSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSanh.Name = "lblTenSanh";
            this.lblTenSanh.Size = new System.Drawing.Size(68, 17);
            this.lblTenSanh.TabIndex = 2;
            this.lblTenSanh.Text = "Tên sảnh";
            // 
            // lblLoaiSanh
            // 
            this.lblLoaiSanh.AutoSize = true;
            this.lblLoaiSanh.Location = new System.Drawing.Point(13, 47);
            this.lblLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiSanh.Name = "lblLoaiSanh";
            this.lblLoaiSanh.Size = new System.Drawing.Size(70, 17);
            this.lblLoaiSanh.TabIndex = 3;
            this.lblLoaiSanh.Text = "Loại sảnh";
            // 
            // lblDonGiaBanTT
            // 
            this.lblDonGiaBanTT.AutoSize = true;
            this.lblDonGiaBanTT.Location = new System.Drawing.Point(13, 80);
            this.lblDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBanTT.Name = "lblDonGiaBanTT";
            this.lblDonGiaBanTT.Size = new System.Drawing.Size(139, 17);
            this.lblDonGiaBanTT.TabIndex = 4;
            this.lblDonGiaBanTT.Text = "Đơn giá bàn tối thiểu";
            // 
            // lblSoLuongBanTD
            // 
            this.lblSoLuongBanTD.AutoSize = true;
            this.lblSoLuongBanTD.Location = new System.Drawing.Point(13, 111);
            this.lblSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongBanTD.Name = "lblSoLuongBanTD";
            this.lblSoLuongBanTD.Size = new System.Drawing.Size(131, 17);
            this.lblSoLuongBanTD.TabIndex = 5;
            this.lblSoLuongBanTD.Text = "Số lượng bàn tối đa";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(13, 142);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(57, 17);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(164, 13);
            this.txtTenSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(214, 23);
            this.txtTenSanh.TabIndex = 0;
            // 
            // cbbLoaiSanh
            // 
            this.cbbLoaiSanh.FormattingEnabled = true;
            this.cbbLoaiSanh.Location = new System.Drawing.Point(164, 44);
            this.cbbLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSanh.Name = "cbbLoaiSanh";
            this.cbbLoaiSanh.Size = new System.Drawing.Size(214, 24);
            this.cbbLoaiSanh.TabIndex = 1;
            this.cbbLoaiSanh.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSanh_SelectedIndexChanged);
            // 
            // cbbDonGiaBanTT
            // 
            this.cbbDonGiaBanTT.FormattingEnabled = true;
            this.cbbDonGiaBanTT.Location = new System.Drawing.Point(164, 76);
            this.cbbDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDonGiaBanTT.Name = "cbbDonGiaBanTT";
            this.cbbDonGiaBanTT.Size = new System.Drawing.Size(214, 24);
            this.cbbDonGiaBanTT.TabIndex = 2;
            this.cbbDonGiaBanTT.SelectedIndexChanged += new System.EventHandler(this.cbbDonGiaBanTT_SelectedIndexChanged);
            // 
            // txtSoLuongBanTD
            // 
            this.txtSoLuongBanTD.Location = new System.Drawing.Point(164, 108);
            this.txtSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongBanTD.Name = "txtSoLuongBanTD";
            this.txtSoLuongBanTD.Size = new System.Drawing.Size(214, 23);
            this.txtSoLuongBanTD.TabIndex = 3;
            this.txtSoLuongBanTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongBanTD_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(164, 139);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(214, 108);
            this.txtGhiChu.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuy.Location = new System.Drawing.Point(422, 48);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(422, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTiepNhanSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtSoLuongBanTD);
            this.Controls.Add(this.cbbDonGiaBanTT);
            this.Controls.Add(this.cbbLoaiSanh);
            this.Controls.Add(this.txtTenSanh);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblSoLuongBanTD);
            this.Controls.Add(this.lblDonGiaBanTT);
            this.Controls.Add(this.lblLoaiSanh);
            this.Controls.Add(this.lblTenSanh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "frmTiepNhanSanh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIẾP NHẬN SẢNH";
            this.Load += new System.EventHandler(this.frmTiepNhanSanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSanh;
        private System.Windows.Forms.Label lblLoaiSanh;
        private System.Windows.Forms.Label lblDonGiaBanTT;
        private System.Windows.Forms.Label lblSoLuongBanTD;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.ComboBox cbbLoaiSanh;
        private System.Windows.Forms.ComboBox cbbDonGiaBanTT;
        private System.Windows.Forms.TextBox txtSoLuongBanTD;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}