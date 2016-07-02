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
            this.components = new System.ComponentModel.Container();
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myTooltip = new System.Windows.Forms.ToolTip(this.components);
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
            this.lblDonGiaBanTT.Location = new System.Drawing.Point(13, 79);
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
            this.txtTenSanh.Location = new System.Drawing.Point(173, 13);
            this.txtTenSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(214, 23);
            this.txtTenSanh.TabIndex = 0;
            this.txtTenSanh.TextChanged += new System.EventHandler(this.txtTenSanh_TextChanged);
            // 
            // cbbLoaiSanh
            // 
            this.cbbLoaiSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSanh.FormattingEnabled = true;
            this.cbbLoaiSanh.Location = new System.Drawing.Point(173, 44);
            this.cbbLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSanh.Name = "cbbLoaiSanh";
            this.cbbLoaiSanh.Size = new System.Drawing.Size(214, 24);
            this.cbbLoaiSanh.TabIndex = 1;
            this.cbbLoaiSanh.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSanh_SelectedIndexChanged);
            // 
            // cbbDonGiaBanTT
            // 
            this.cbbDonGiaBanTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonGiaBanTT.FormattingEnabled = true;
            this.cbbDonGiaBanTT.Location = new System.Drawing.Point(173, 76);
            this.cbbDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDonGiaBanTT.Name = "cbbDonGiaBanTT";
            this.cbbDonGiaBanTT.Size = new System.Drawing.Size(214, 24);
            this.cbbDonGiaBanTT.TabIndex = 2;
            this.cbbDonGiaBanTT.SelectedIndexChanged += new System.EventHandler(this.cbbDonGiaBanTT_SelectedIndexChanged);
            // 
            // txtSoLuongBanTD
            // 
            this.txtSoLuongBanTD.Location = new System.Drawing.Point(173, 108);
            this.txtSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongBanTD.MaxLength = 3;
            this.txtSoLuongBanTD.Name = "txtSoLuongBanTD";
            this.txtSoLuongBanTD.Size = new System.Drawing.Size(214, 23);
            this.txtSoLuongBanTD.TabIndex = 3;
            this.txtSoLuongBanTD.TextChanged += new System.EventHandler(this.txtSoLuongBanTD_TextChanged);
            this.txtSoLuongBanTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongBanTD_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(173, 139);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(214, 87);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            this.txtGhiChu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGhiChu_KeyDown);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuy.Location = new System.Drawing.Point(422, 49);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(422, 13);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Các mục (*) không được để trống.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(143, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(150, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "*";
            // 
            // frmTiepNhanSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
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
            this.Shown += new System.EventHandler(this.frmTiepNhanSanh_Shown);
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
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip myTooltip;
    }
}