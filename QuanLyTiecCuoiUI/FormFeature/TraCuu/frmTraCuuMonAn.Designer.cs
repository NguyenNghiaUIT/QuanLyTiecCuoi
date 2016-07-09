namespace QuanLyTiecCuoiUI
{
    partial class frmTraCuuMonAn
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
            this.tcTraCuuMonAn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.gbThongTinMonAn = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.ptrHinh = new System.Windows.Forms.PictureBox();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.tcTraCuuMonAn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.gbThongTinMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTraCuuMonAn
            // 
            this.tcTraCuuMonAn.Controls.Add(this.tabPage1);
            this.tcTraCuuMonAn.Controls.Add(this.tabPage2);
            this.tcTraCuuMonAn.Location = new System.Drawing.Point(12, 265);
            this.tcTraCuuMonAn.Name = "tcTraCuuMonAn";
            this.tcTraCuuMonAn.SelectedIndex = 0;
            this.tcTraCuuMonAn.Size = new System.Drawing.Size(400, 284);
            this.tcTraCuuMonAn.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDanhSachMonAn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách món ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.AllowUserToAddRows = false;
            this.dgvDanhSachMonAn.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonAn.AllowUserToResizeRows = false;
            this.dgvDanhSachMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.EnableHeadersVisualStyles = false;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachMonAn.MultiSelect = false;
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.ReadOnly = true;
            this.dgvDanhSachMonAn.RowHeadersVisible = false;
            this.dgvDanhSachMonAn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvDanhSachMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(392, 255);
            this.dgvDanhSachMonAn.TabIndex = 0;
            this.dgvDanhSachMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMonAn_CellClick);
            this.dgvDanhSachMonAn.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDanhSachMonAn_DataBindingComplete);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvKetQuaTimKiem);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kết quả tìm kiếm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.txtTuKhoa);
            this.gbTimKiem.Location = new System.Drawing.Point(12, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(400, 55);
            this.gbTimKiem.TabIndex = 1;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(294, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(7, 23);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(281, 23);
            this.txtTuKhoa.TabIndex = 0;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // gbThongTinMonAn
            // 
            this.gbThongTinMonAn.Controls.Add(this.btnChon);
            this.gbThongTinMonAn.Controls.Add(this.lbGhiChu);
            this.gbThongTinMonAn.Controls.Add(this.lbDonGia);
            this.gbThongTinMonAn.Controls.Add(this.lbTenMonAn);
            this.gbThongTinMonAn.Controls.Add(this.ptrHinh);
            this.gbThongTinMonAn.Location = new System.Drawing.Point(12, 73);
            this.gbThongTinMonAn.Name = "gbThongTinMonAn";
            this.gbThongTinMonAn.Size = new System.Drawing.Size(400, 186);
            this.gbThongTinMonAn.TabIndex = 2;
            this.gbThongTinMonAn.TabStop = false;
            this.gbThongTinMonAn.Text = "Thông tin món ăn";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(16, 148);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(100, 30);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGhiChu.Location = new System.Drawing.Point(132, 62);
            this.lbGhiChu.MinimumSize = new System.Drawing.Size(213, 77);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(213, 77);
            this.lbGhiChu.TabIndex = 1;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbDonGia.Location = new System.Drawing.Point(132, 45);
            this.lbDonGia.MinimumSize = new System.Drawing.Size(213, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(213, 17);
            this.lbDonGia.TabIndex = 1;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.AutoSize = true;
            this.lbTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMonAn.Location = new System.Drawing.Point(131, 24);
            this.lbTenMonAn.MinimumSize = new System.Drawing.Size(213, 0);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(213, 22);
            this.lbTenMonAn.TabIndex = 1;
            this.lbTenMonAn.Text = "Tên món ăn";
            // 
            // ptrHinh
            // 
            this.ptrHinh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ptrHinh.Location = new System.Drawing.Point(6, 22);
            this.ptrHinh.Name = "ptrHinh";
            this.ptrHinh.Size = new System.Drawing.Size(120, 120);
            this.ptrHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHinh.TabIndex = 0;
            this.ptrHinh.TabStop = false;
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AllowUserToAddRows = false;
            this.dgvKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimKiem.AllowUserToResizeRows = false;
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiem.EnableHeadersVisualStyles = false;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQuaTimKiem.MultiSelect = false;
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.ReadOnly = true;
            this.dgvKetQuaTimKiem.RowHeadersVisible = false;
            this.dgvKetQuaTimKiem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvKetQuaTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(390, 187);
            this.dgvKetQuaTimKiem.TabIndex = 0;
            this.dgvKetQuaTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellClick);
            this.dgvKetQuaTimKiem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKetQuaTimKiem_DataBindingComplete);
            // 
            // frmTraCuuMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 561);
            this.Controls.Add(this.gbThongTinMonAn);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.tcTraCuuMonAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuMonAn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTraCuuMonAn";
            this.Load += new System.EventHandler(this.frmTraCuuMonAn_Load);
            this.tcTraCuuMonAn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbThongTinMonAn.ResumeLayout(false);
            this.gbThongTinMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TabControl tcTraCuuMonAn;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
        private System.Windows.Forms.GroupBox gbThongTinMonAn;
        private System.Windows.Forms.PictureBox ptrHinh;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
    }
}