namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLyDichVu
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
            this.gbDanhSachDichVu = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.lbTenDichVu = new System.Windows.Forms.Label();
            this.gbThongTinDichVu = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.gbDanhSachDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.gbThongTinDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachDichVu
            // 
            this.gbDanhSachDichVu.Controls.Add(this.dgvDanhSachDichVu);
            this.gbDanhSachDichVu.Location = new System.Drawing.Point(12, 222);
            this.gbDanhSachDichVu.Name = "gbDanhSachDichVu";
            this.gbDanhSachDichVu.Size = new System.Drawing.Size(515, 226);
            this.gbDanhSachDichVu.TabIndex = 8;
            this.gbDanhSachDichVu.TabStop = false;
            this.gbDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // dgvDanhSachDichVu
            // 
            this.dgvDanhSachDichVu.AllowUserToAddRows = false;
            this.dgvDanhSachDichVu.AllowUserToDeleteRows = false;
            this.dgvDanhSachDichVu.AllowUserToResizeRows = false;
            this.dgvDanhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDichVu.EnableHeadersVisualStyles = false;
            this.dgvDanhSachDichVu.Location = new System.Drawing.Point(6, 22);
            this.dgvDanhSachDichVu.MultiSelect = false;
            this.dgvDanhSachDichVu.Name = "dgvDanhSachDichVu";
            this.dgvDanhSachDichVu.ReadOnly = true;
            this.dgvDanhSachDichVu.RowHeadersVisible = false;
            this.dgvDanhSachDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvDanhSachDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachDichVu.ShowCellErrors = false;
            this.dgvDanhSachDichVu.ShowCellToolTips = false;
            this.dgvDanhSachDichVu.ShowEditingIcon = false;
            this.dgvDanhSachDichVu.ShowRowErrors = false;
            this.dgvDanhSachDichVu.Size = new System.Drawing.Size(501, 198);
            this.dgvDanhSachDichVu.TabIndex = 1;
            this.dgvDanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDichVu_CellClick);
            this.dgvDanhSachDichVu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDanhSachDichVu_DataBindingComplete);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnHuy);
            this.gbChucNang.Controls.Add(this.btnLuu);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnSua);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(415, 12);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(112, 204);
            this.gbChucNang.TabIndex = 6;
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
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(111, 98);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(280, 81);
            this.txtGhiChu.TabIndex = 3;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(6, 101);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(57, 17);
            this.lbGhiChu.TabIndex = 0;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(6, 72);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(57, 17);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Location = new System.Drawing.Point(111, 40);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(280, 23);
            this.txtTenDichVu.TabIndex = 1;
            // 
            // lbTenDichVu
            // 
            this.lbTenDichVu.AutoSize = true;
            this.lbTenDichVu.Location = new System.Drawing.Point(6, 43);
            this.lbTenDichVu.Name = "lbTenDichVu";
            this.lbTenDichVu.Size = new System.Drawing.Size(82, 17);
            this.lbTenDichVu.TabIndex = 0;
            this.lbTenDichVu.Text = "Tên dịch vụ";
            // 
            // gbThongTinDichVu
            // 
            this.gbThongTinDichVu.Controls.Add(this.txtDonGia);
            this.gbThongTinDichVu.Controls.Add(this.txtGhiChu);
            this.gbThongTinDichVu.Controls.Add(this.lbGhiChu);
            this.gbThongTinDichVu.Controls.Add(this.lbDonGia);
            this.gbThongTinDichVu.Controls.Add(this.txtTenDichVu);
            this.gbThongTinDichVu.Controls.Add(this.lbTenDichVu);
            this.gbThongTinDichVu.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinDichVu.Name = "gbThongTinDichVu";
            this.gbThongTinDichVu.Size = new System.Drawing.Size(397, 204);
            this.gbThongTinDichVu.TabIndex = 7;
            this.gbThongTinDichVu.TabStop = false;
            this.gbThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(111, 69);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(280, 23);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // frmQuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.gbDanhSachDichVu);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbThongTinDichVu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyDichVu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            this.gbDanhSachDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDichVu)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.gbThongTinDichVu.ResumeLayout(false);
            this.gbThongTinDichVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachDichVu;
        private System.Windows.Forms.DataGridView dgvDanhSachDichVu;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label lbTenDichVu;
        private System.Windows.Forms.GroupBox gbThongTinDichVu;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}