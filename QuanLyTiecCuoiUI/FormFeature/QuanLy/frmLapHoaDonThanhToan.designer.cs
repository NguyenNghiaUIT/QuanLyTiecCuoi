namespace QuanLyTiecCuoiUI
{
    partial class frmLapHoaDonThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenChuRe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenCoDau = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTongTienPhat = new System.Windows.Forms.Label();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.lblPhanTramPhat = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblConLai = new System.Windows.Forms.Label();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.lblTongTienDV = new System.Windows.Forms.Label();
            this.lblTongTienHD = new System.Windows.Forms.Label();
            this.lblTongTienBan = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblSoLuongBan = new System.Windows.Forms.Label();
            this.lblNgayThanhToan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCacDichVu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.cbbNgayDatTiec = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chú rể:";
            // 
            // cbbTenChuRe
            // 
            this.cbbTenChuRe.FormattingEnabled = true;
            this.cbbTenChuRe.Location = new System.Drawing.Point(113, 6);
            this.cbbTenChuRe.Name = "cbbTenChuRe";
            this.cbbTenChuRe.Size = new System.Drawing.Size(191, 24);
            this.cbbTenChuRe.TabIndex = 1;
            this.cbbTenChuRe.SelectedIndexChanged += new System.EventHandler(this.cbbTenChuRe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "hoặc tên cô dâu:";
            // 
            // cbbTenCoDau
            // 
            this.cbbTenCoDau.FormattingEnabled = true;
            this.cbbTenCoDau.Location = new System.Drawing.Point(461, 6);
            this.cbbTenCoDau.Name = "cbbTenCoDau";
            this.cbbTenCoDau.Size = new System.Drawing.Size(191, 24);
            this.cbbTenCoDau.TabIndex = 3;
            this.cbbTenCoDau.SelectedIndexChanged += new System.EventHandler(this.cbbTenCoDau_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTongTienThanhToan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTongTienPhat);
            this.groupBox1.Controls.Add(this.lblSoNgayTre);
            this.groupBox1.Controls.Add(this.lblPhanTramPhat);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblConLai);
            this.groupBox1.Controls.Add(this.lblTienDatCoc);
            this.groupBox1.Controls.Add(this.lblTongTienDV);
            this.groupBox1.Controls.Add(this.lblTongTienHD);
            this.groupBox1.Controls.Add(this.lblTongTienBan);
            this.groupBox1.Controls.Add(this.lblDonGiaBan);
            this.groupBox1.Controls.Add(this.lblSoLuongBan);
            this.groupBox1.Controls.Add(this.lblNgayThanhToan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvCacDichVu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 386);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn thanh toán";
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(476, 356);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(14, 17);
            this.lblTongTienThanhToan.TabIndex = 30;
            this.lblTongTienThanhToan.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Còn lại:";
            // 
            // lblTongTienPhat
            // 
            this.lblTongTienPhat.AutoSize = true;
            this.lblTongTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhat.Location = new System.Drawing.Point(476, 328);
            this.lblTongTienPhat.Name = "lblTongTienPhat";
            this.lblTongTienPhat.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienPhat.TabIndex = 28;
            this.lblTongTienPhat.Text = "-";
            // 
            // lblSoNgayTre
            // 
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayTre.Location = new System.Drawing.Point(476, 274);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(13, 17);
            this.lblSoNgayTre.TabIndex = 27;
            this.lblSoNgayTre.Text = "-";
            // 
            // lblPhanTramPhat
            // 
            this.lblPhanTramPhat.AutoSize = true;
            this.lblPhanTramPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanTramPhat.Location = new System.Drawing.Point(476, 301);
            this.lblPhanTramPhat.Name = "lblPhanTramPhat";
            this.lblPhanTramPhat.Size = new System.Drawing.Size(13, 17);
            this.lblPhanTramPhat.TabIndex = 26;
            this.lblPhanTramPhat.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "Tổng tiền phạt:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(315, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Giá trị phạt (%/ngày):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Số ngày trễ:";
            // 
            // lblConLai
            // 
            this.lblConLai.AutoSize = true;
            this.lblConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConLai.Location = new System.Drawing.Point(140, 356);
            this.lblConLai.Name = "lblConLai";
            this.lblConLai.Size = new System.Drawing.Size(13, 17);
            this.lblConLai.TabIndex = 22;
            this.lblConLai.Text = "-";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDatCoc.Location = new System.Drawing.Point(140, 328);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(13, 17);
            this.lblTienDatCoc.TabIndex = 21;
            this.lblTienDatCoc.Text = "-";
            // 
            // lblTongTienDV
            // 
            this.lblTongTienDV.AutoSize = true;
            this.lblTongTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienDV.Location = new System.Drawing.Point(140, 274);
            this.lblTongTienDV.Name = "lblTongTienDV";
            this.lblTongTienDV.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienDV.TabIndex = 20;
            this.lblTongTienDV.Text = "-";
            // 
            // lblTongTienHD
            // 
            this.lblTongTienHD.AutoSize = true;
            this.lblTongTienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHD.Location = new System.Drawing.Point(140, 301);
            this.lblTongTienHD.Name = "lblTongTienHD";
            this.lblTongTienHD.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienHD.TabIndex = 19;
            this.lblTongTienHD.Text = "-";
            // 
            // lblTongTienBan
            // 
            this.lblTongTienBan.AutoSize = true;
            this.lblTongTienBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienBan.Location = new System.Drawing.Point(421, 56);
            this.lblTongTienBan.Name = "lblTongTienBan";
            this.lblTongTienBan.Size = new System.Drawing.Size(13, 17);
            this.lblTongTienBan.TabIndex = 18;
            this.lblTongTienBan.Text = "-";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaBan.Location = new System.Drawing.Point(421, 29);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(13, 17);
            this.lblDonGiaBan.TabIndex = 17;
            this.lblDonGiaBan.Text = "-";
            // 
            // lblSoLuongBan
            // 
            this.lblSoLuongBan.AutoSize = true;
            this.lblSoLuongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongBan.Location = new System.Drawing.Point(129, 56);
            this.lblSoLuongBan.Name = "lblSoLuongBan";
            this.lblSoLuongBan.Size = new System.Drawing.Size(13, 17);
            this.lblSoLuongBan.TabIndex = 16;
            this.lblSoLuongBan.Text = "-";
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.AutoSize = true;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.Location = new System.Drawing.Point(129, 29);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(13, 17);
            this.lblNgayThanhToan.TabIndex = 15;
            this.lblNgayThanhToan.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Các dịch vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số tiền cần thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tiền đặt cọc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng tiền hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền dịch vụ:";
            // 
            // dgvCacDichVu
            // 
            this.dgvCacDichVu.AllowUserToAddRows = false;
            this.dgvCacDichVu.AllowUserToDeleteRows = false;
            this.dgvCacDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCacDichVu.ColumnHeadersHeight = 25;
            this.dgvCacDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCacDichVu.Location = new System.Drawing.Point(6, 110);
            this.dgvCacDichVu.Name = "dgvCacDichVu";
            this.dgvCacDichVu.ReadOnly = true;
            this.dgvCacDichVu.Size = new System.Drawing.Size(628, 150);
            this.dgvCacDichVu.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenDichVu";
            this.Column1.HeaderText = "Dịch vụ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá (VND)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Thành tiền (VND)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày thanh toán:";
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Location = new System.Drawing.Point(461, 47);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(100, 30);
            this.btnLapHoaDon.TabIndex = 5;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // cbbNgayDatTiec
            // 
            this.cbbNgayDatTiec.FormattingEnabled = true;
            this.cbbNgayDatTiec.Location = new System.Drawing.Point(113, 47);
            this.cbbNgayDatTiec.Name = "cbbNgayDatTiec";
            this.cbbNgayDatTiec.Size = new System.Drawing.Size(191, 24);
            this.cbbNgayDatTiec.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ngày đặt tiệc:";
            // 
            // frmLapHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 512);
            this.Controls.Add(this.cbbNgayDatTiec);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTenCoDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenChuRe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 550);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "frmLapHoaDonThanhToan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP HÓA ĐƠN THANH TOÁN";
            this.Load += new System.EventHandler(this.frmLapHoaDonThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenChuRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenCoDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCacDichVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblConLai;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.Label lblTongTienDV;
        private System.Windows.Forms.Label lblTongTienHD;
        private System.Windows.Forms.Label lblTongTienBan;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.Label lblNgayThanhToan;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.ComboBox cbbNgayDatTiec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTongTienPhat;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.Label lblPhanTramPhat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}