namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyLoaiSanh
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
            this.lblDonGiaBanToiThieu = new System.Windows.Forms.Label();
            this.lblMaLoaiSanh = new System.Windows.Forms.Label();
            this.dgvQuanLyLoaiSanh = new System.Windows.Forms.DataGridView();
            this.grpThongTinLoaiSanh = new System.Windows.Forms.GroupBox();
            this.txtDonGiaBanTT = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSanh = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpTinhNangQuanLy = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpDanhSachLoaiSanh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiSanh)).BeginInit();
            this.grpThongTinLoaiSanh.SuspendLayout();
            this.grpTinhNangQuanLy.SuspendLayout();
            this.grpDanhSachLoaiSanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDonGiaBanToiThieu
            // 
            this.lblDonGiaBanToiThieu.AutoSize = true;
            this.lblDonGiaBanToiThieu.Location = new System.Drawing.Point(7, 85);
            this.lblDonGiaBanToiThieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBanToiThieu.Name = "lblDonGiaBanToiThieu";
            this.lblDonGiaBanToiThieu.Size = new System.Drawing.Size(143, 17);
            this.lblDonGiaBanToiThieu.TabIndex = 36;
            this.lblDonGiaBanToiThieu.Text = "Đơn giá bàn tối thiểu:";
            // 
            // lblMaLoaiSanh
            // 
            this.lblMaLoaiSanh.AutoSize = true;
            this.lblMaLoaiSanh.Location = new System.Drawing.Point(7, 29);
            this.lblMaLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLoaiSanh.Name = "lblMaLoaiSanh";
            this.lblMaLoaiSanh.Size = new System.Drawing.Size(92, 17);
            this.lblMaLoaiSanh.TabIndex = 35;
            this.lblMaLoaiSanh.Text = "Mã loại sảnh:";
            // 
            // dgvQuanLyLoaiSanh
            // 
            this.dgvQuanLyLoaiSanh.AllowUserToAddRows = false;
            this.dgvQuanLyLoaiSanh.AllowUserToDeleteRows = false;
            this.dgvQuanLyLoaiSanh.AllowUserToResizeRows = false;
            this.dgvQuanLyLoaiSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyLoaiSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyLoaiSanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyLoaiSanh.Location = new System.Drawing.Point(3, 19);
            this.dgvQuanLyLoaiSanh.Name = "dgvQuanLyLoaiSanh";
            this.dgvQuanLyLoaiSanh.ReadOnly = true;
            this.dgvQuanLyLoaiSanh.RowHeadersVisible = false;
            this.dgvQuanLyLoaiSanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyLoaiSanh.Size = new System.Drawing.Size(394, 154);
            this.dgvQuanLyLoaiSanh.TabIndex = 7;
            // 
            // grpThongTinLoaiSanh
            // 
            this.grpThongTinLoaiSanh.Controls.Add(this.txtDonGiaBanTT);
            this.grpThongTinLoaiSanh.Controls.Add(this.lblDonGiaBanToiThieu);
            this.grpThongTinLoaiSanh.Controls.Add(this.lblMaLoaiSanh);
            this.grpThongTinLoaiSanh.Controls.Add(this.txtMaLoaiSanh);
            this.grpThongTinLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongTinLoaiSanh.Location = new System.Drawing.Point(12, 12);
            this.grpThongTinLoaiSanh.Name = "grpThongTinLoaiSanh";
            this.grpThongTinLoaiSanh.Size = new System.Drawing.Size(213, 216);
            this.grpThongTinLoaiSanh.TabIndex = 33;
            this.grpThongTinLoaiSanh.TabStop = false;
            this.grpThongTinLoaiSanh.Text = "Thông tin loại sảnh";
            // 
            // txtDonGiaBanTT
            // 
            this.txtDonGiaBanTT.Location = new System.Drawing.Point(10, 106);
            this.txtDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBanTT.Name = "txtDonGiaBanTT";
            this.txtDonGiaBanTT.Size = new System.Drawing.Size(196, 23);
            this.txtDonGiaBanTT.TabIndex = 1;
            this.txtDonGiaBanTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBanTT_KeyPress);
            // 
            // txtMaLoaiSanh
            // 
            this.txtMaLoaiSanh.Location = new System.Drawing.Point(10, 50);
            this.txtMaLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiSanh.MaxLength = 1;
            this.txtMaLoaiSanh.Name = "txtMaLoaiSanh";
            this.txtMaLoaiSanh.Size = new System.Drawing.Size(197, 23);
            this.txtMaLoaiSanh.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Location = new System.Drawing.Point(41, 175);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(41, 139);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(41, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(41, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpTinhNangQuanLy
            // 
            this.grpTinhNangQuanLy.Controls.Add(this.btnThem);
            this.grpTinhNangQuanLy.Controls.Add(this.btnSua);
            this.grpTinhNangQuanLy.Controls.Add(this.btnHuy);
            this.grpTinhNangQuanLy.Controls.Add(this.btnLuu);
            this.grpTinhNangQuanLy.Controls.Add(this.btnXoa);
            this.grpTinhNangQuanLy.Location = new System.Drawing.Point(231, 13);
            this.grpTinhNangQuanLy.Name = "grpTinhNangQuanLy";
            this.grpTinhNangQuanLy.Size = new System.Drawing.Size(181, 215);
            this.grpTinhNangQuanLy.TabIndex = 34;
            this.grpTinhNangQuanLy.TabStop = false;
            this.grpTinhNangQuanLy.Text = "Tính năng quản lý";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(41, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpDanhSachLoaiSanh
            // 
            this.grpDanhSachLoaiSanh.Controls.Add(this.dgvQuanLyLoaiSanh);
            this.grpDanhSachLoaiSanh.Location = new System.Drawing.Point(12, 234);
            this.grpDanhSachLoaiSanh.Name = "grpDanhSachLoaiSanh";
            this.grpDanhSachLoaiSanh.Size = new System.Drawing.Size(400, 176);
            this.grpDanhSachLoaiSanh.TabIndex = 37;
            this.grpDanhSachLoaiSanh.TabStop = false;
            this.grpDanhSachLoaiSanh.Text = "Danh sách các loại sảnh";
            // 
            // frmQuanLyLoaiSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 411);
            this.Controls.Add(this.grpDanhSachLoaiSanh);
            this.Controls.Add(this.grpThongTinLoaiSanh);
            this.Controls.Add(this.grpTinhNangQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 450);
            this.MinimumSize = new System.Drawing.Size(440, 450);
            this.Name = "frmQuanLyLoaiSanh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LOẠI SẢNH";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyLoaiSanh)).EndInit();
            this.grpThongTinLoaiSanh.ResumeLayout(false);
            this.grpThongTinLoaiSanh.PerformLayout();
            this.grpTinhNangQuanLy.ResumeLayout(false);
            this.grpDanhSachLoaiSanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDonGiaBanToiThieu;
        private System.Windows.Forms.Label lblMaLoaiSanh;
        private System.Windows.Forms.DataGridView dgvQuanLyLoaiSanh;
        private System.Windows.Forms.GroupBox grpThongTinLoaiSanh;
        private System.Windows.Forms.TextBox txtMaLoaiSanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpTinhNangQuanLy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grpDanhSachLoaiSanh;
        private System.Windows.Forms.TextBox txtDonGiaBanTT;
    }
}