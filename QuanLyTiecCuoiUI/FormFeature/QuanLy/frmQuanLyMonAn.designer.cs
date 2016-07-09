namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyMonAn
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
            this.gbDanhSachMonAn = new System.Windows.Forms.GroupBox();
            this.lstHinhAnh = new System.Windows.Forms.ListView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.gbThongTinMonAn = new System.Windows.Forms.GroupBox();
            this.lbCaution = new System.Windows.Forms.Label();
            this.lbThongTinHinhAnh = new System.Windows.Forms.Label();
            this.ptrHinhAnh = new System.Windows.Forms.PictureBox();
            this.lbCautionDonGia = new System.Windows.Forms.Label();
            this.lbCautionTenMonAn = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.lbHinhAnh = new System.Windows.Forms.Label();
            this.gbDanhSachMonAn.SuspendLayout();
            this.gbChucNang.SuspendLayout();
            this.gbThongTinMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDanhSachMonAn
            // 
            this.gbDanhSachMonAn.Controls.Add(this.lstHinhAnh);
            this.gbDanhSachMonAn.Location = new System.Drawing.Point(458, 12);
            this.gbDanhSachMonAn.Name = "gbDanhSachMonAn";
            this.gbDanhSachMonAn.Size = new System.Drawing.Size(314, 450);
            this.gbDanhSachMonAn.TabIndex = 5;
            this.gbDanhSachMonAn.TabStop = false;
            this.gbDanhSachMonAn.Text = "Danh sách món ăn";
            // 
            // lstHinhAnh
            // 
            this.lstHinhAnh.BackColor = System.Drawing.Color.Gainsboro;
            this.lstHinhAnh.Location = new System.Drawing.Point(6, 22);
            this.lstHinhAnh.Name = "lstHinhAnh";
            this.lstHinhAnh.Size = new System.Drawing.Size(302, 422);
            this.lstHinhAnh.TabIndex = 0;
            this.lstHinhAnh.UseCompatibleStateImageBehavior = false;
            this.lstHinhAnh.SelectedIndexChanged += new System.EventHandler(this.lstHinhAnh_SelectedIndexChanged);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnHuy);
            this.gbChucNang.Controls.Add(this.btnLuu);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnSua);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(340, 12);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(112, 204);
            this.gbChucNang.TabIndex = 3;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(6, 166);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(6, 130);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 94);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThem.Location = new System.Drawing.Point(6, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(33, 51);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(57, 17);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(110, 22);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(206, 23);
            this.txtTenMonAn.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(110, 80);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(206, 81);
            this.txtGhiChu.TabIndex = 3;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(33, 83);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(57, 17);
            this.lbGhiChu.TabIndex = 0;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Location = new System.Drawing.Point(6, 25);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(84, 17);
            this.lbTenMonAn.TabIndex = 0;
            this.lbTenMonAn.Text = "Tên món ăn";
            // 
            // gbThongTinMonAn
            // 
            this.gbThongTinMonAn.Controls.Add(this.lbCaution);
            this.gbThongTinMonAn.Controls.Add(this.lbThongTinHinhAnh);
            this.gbThongTinMonAn.Controls.Add(this.ptrHinhAnh);
            this.gbThongTinMonAn.Controls.Add(this.lbCautionDonGia);
            this.gbThongTinMonAn.Controls.Add(this.lbCautionTenMonAn);
            this.gbThongTinMonAn.Controls.Add(this.txtDonGia);
            this.gbThongTinMonAn.Controls.Add(this.btnXoaAnh);
            this.gbThongTinMonAn.Controls.Add(this.btnChonAnh);
            this.gbThongTinMonAn.Controls.Add(this.txtGhiChu);
            this.gbThongTinMonAn.Controls.Add(this.lbHinhAnh);
            this.gbThongTinMonAn.Controls.Add(this.lbGhiChu);
            this.gbThongTinMonAn.Controls.Add(this.lbDonGia);
            this.gbThongTinMonAn.Controls.Add(this.txtTenMonAn);
            this.gbThongTinMonAn.Controls.Add(this.lbTenMonAn);
            this.gbThongTinMonAn.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinMonAn.Name = "gbThongTinMonAn";
            this.gbThongTinMonAn.Size = new System.Drawing.Size(322, 450);
            this.gbThongTinMonAn.TabIndex = 4;
            this.gbThongTinMonAn.TabStop = false;
            this.gbThongTinMonAn.Text = "Thông tin món ăn";
            // 
            // lbCaution
            // 
            this.lbCaution.AutoSize = true;
            this.lbCaution.ForeColor = System.Drawing.Color.Red;
            this.lbCaution.Location = new System.Drawing.Point(6, 426);
            this.lbCaution.Name = "lbCaution";
            this.lbCaution.Size = new System.Drawing.Size(200, 17);
            this.lbCaution.TabIndex = 7;
            this.lbCaution.Text = "(*) là những thông tin bắt buộc";
            // 
            // lbThongTinHinhAnh
            // 
            this.lbThongTinHinhAnh.AutoSize = true;
            this.lbThongTinHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinHinhAnh.Location = new System.Drawing.Point(107, 410);
            this.lbThongTinHinhAnh.Name = "lbThongTinHinhAnh";
            this.lbThongTinHinhAnh.Size = new System.Drawing.Size(0, 16);
            this.lbThongTinHinhAnh.TabIndex = 6;
            // 
            // ptrHinhAnh
            // 
            this.ptrHinhAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptrHinhAnh.Location = new System.Drawing.Point(110, 203);
            this.ptrHinhAnh.Name = "ptrHinhAnh";
            this.ptrHinhAnh.Size = new System.Drawing.Size(206, 206);
            this.ptrHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHinhAnh.TabIndex = 5;
            this.ptrHinhAnh.TabStop = false;
            // 
            // lbCautionDonGia
            // 
            this.lbCautionDonGia.AutoSize = true;
            this.lbCautionDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.lbCautionDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbCautionDonGia.Location = new System.Drawing.Point(86, 51);
            this.lbCautionDonGia.Name = "lbCautionDonGia";
            this.lbCautionDonGia.Size = new System.Drawing.Size(13, 17);
            this.lbCautionDonGia.TabIndex = 4;
            this.lbCautionDonGia.Text = "*";
            // 
            // lbCautionTenMonAn
            // 
            this.lbCautionTenMonAn.AutoSize = true;
            this.lbCautionTenMonAn.BackColor = System.Drawing.SystemColors.Control;
            this.lbCautionTenMonAn.ForeColor = System.Drawing.Color.Red;
            this.lbCautionTenMonAn.Location = new System.Drawing.Point(86, 25);
            this.lbCautionTenMonAn.Name = "lbCautionTenMonAn";
            this.lbCautionTenMonAn.Size = new System.Drawing.Size(13, 17);
            this.lbCautionTenMonAn.TabIndex = 4;
            this.lbCautionTenMonAn.Text = "*";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(110, 51);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(206, 23);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.Location = new System.Drawing.Point(216, 167);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(100, 30);
            this.btnXoaAnh.TabIndex = 4;
            this.btnXoaAnh.Text = "Xoá ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(110, 167);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 30);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // lbHinhAnh
            // 
            this.lbHinhAnh.AutoSize = true;
            this.lbHinhAnh.Location = new System.Drawing.Point(25, 174);
            this.lbHinhAnh.Name = "lbHinhAnh";
            this.lbHinhAnh.Size = new System.Drawing.Size(65, 17);
            this.lbHinhAnh.TabIndex = 0;
            this.lbHinhAnh.Text = "Hình ảnh";
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 474);
            this.Controls.Add(this.gbDanhSachMonAn);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbThongTinMonAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Món Ăn";
            this.Load += new System.EventHandler(this.frmQuanLyMonAn_Load);
            this.gbDanhSachMonAn.ResumeLayout(false);
            this.gbChucNang.ResumeLayout(false);
            this.gbThongTinMonAn.ResumeLayout(false);
            this.gbThongTinMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachMonAn;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.GroupBox gbThongTinMonAn;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbCautionTenMonAn;
        private System.Windows.Forms.Label lbCautionDonGia;
        private System.Windows.Forms.PictureBox ptrHinhAnh;
        private System.Windows.Forms.Label lbHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Label lbThongTinHinhAnh;
        private System.Windows.Forms.Label lbCaution;
        private System.Windows.Forms.ListView lstHinhAnh;
    }
}