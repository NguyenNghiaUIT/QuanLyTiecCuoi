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
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
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
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.gbDanhSachMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.gbChucNang.SuspendLayout();
            this.gbThongTinMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachMonAn
            // 
            this.gbDanhSachMonAn.Controls.Add(this.dgvDanhSachMonAn);
            this.gbDanhSachMonAn.Location = new System.Drawing.Point(12, 222);
            this.gbDanhSachMonAn.Name = "gbDanhSachMonAn";
            this.gbDanhSachMonAn.Size = new System.Drawing.Size(515, 226);
            this.gbDanhSachMonAn.TabIndex = 5;
            this.gbDanhSachMonAn.TabStop = false;
            this.gbDanhSachMonAn.Text = "Danh sách món ăn";
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.AllowUserToAddRows = false;
            this.dgvDanhSachMonAn.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonAn.AllowUserToResizeRows = false;
            this.dgvDanhSachMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.EnableHeadersVisualStyles = false;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(6, 22);
            this.dgvDanhSachMonAn.MultiSelect = false;
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.ReadOnly = true;
            this.dgvDanhSachMonAn.RowHeadersVisible = false;
            this.dgvDanhSachMonAn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvDanhSachMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonAn.ShowCellErrors = false;
            this.dgvDanhSachMonAn.ShowCellToolTips = false;
            this.dgvDanhSachMonAn.ShowEditingIcon = false;
            this.dgvDanhSachMonAn.ShowRowErrors = false;
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(501, 198);
            this.dgvDanhSachMonAn.TabIndex = 1;
            this.dgvDanhSachMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMonAn_CellClick);
            this.dgvDanhSachMonAn.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDanhSachMonAn_DataBindingComplete);
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
            this.lbDonGia.Location = new System.Drawing.Point(6, 72);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(57, 17);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(111, 40);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(280, 23);
            this.txtTenMonAn.TabIndex = 1;
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
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Location = new System.Drawing.Point(6, 43);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(84, 17);
            this.lbTenMonAn.TabIndex = 0;
            this.lbTenMonAn.Text = "Tên món ăn";
            // 
            // gbThongTinMonAn
            // 
            this.gbThongTinMonAn.Controls.Add(this.txtDonGia);
            this.gbThongTinMonAn.Controls.Add(this.txtGhiChu);
            this.gbThongTinMonAn.Controls.Add(this.lbGhiChu);
            this.gbThongTinMonAn.Controls.Add(this.lbDonGia);
            this.gbThongTinMonAn.Controls.Add(this.txtTenMonAn);
            this.gbThongTinMonAn.Controls.Add(this.lbTenMonAn);
            this.gbThongTinMonAn.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinMonAn.Name = "gbThongTinMonAn";
            this.gbThongTinMonAn.Size = new System.Drawing.Size(397, 204);
            this.gbThongTinMonAn.TabIndex = 4;
            this.gbThongTinMonAn.TabStop = false;
            this.gbThongTinMonAn.Text = "Thông tin món ăn";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(111, 69);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(280, 23);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            this.gbThongTinMonAn.ResumeLayout(false);
            this.gbThongTinMonAn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachMonAn;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
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
    }
}