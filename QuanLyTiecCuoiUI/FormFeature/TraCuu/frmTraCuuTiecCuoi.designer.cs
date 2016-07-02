namespace QuanLyTiecCuoiUI
{
    partial class frmTraCuuTiecCuoi
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
            this.gbTraCuuTheo = new System.Windows.Forms.GroupBox();
            this.rbNgay = new System.Windows.Forms.RadioButton();
            this.rbTenCoDau = new System.Windows.Forms.RadioButton();
            this.rbTenChuRe = new System.Windows.Forms.RadioButton();
            this.gbNhapTuKhoa = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.gbKetQuaTraCuu = new System.Windows.Forms.GroupBox();
            this.dgvKetQuaTraCuu = new System.Windows.Forms.DataGridView();
            this.gbTraCuuTheo.SuspendLayout();
            this.gbNhapTuKhoa.SuspendLayout();
            this.gbKetQuaTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTraCuuTheo
            // 
            this.gbTraCuuTheo.Controls.Add(this.rbNgay);
            this.gbTraCuuTheo.Controls.Add(this.rbTenCoDau);
            this.gbTraCuuTheo.Controls.Add(this.rbTenChuRe);
            this.gbTraCuuTheo.Location = new System.Drawing.Point(12, 12);
            this.gbTraCuuTheo.Name = "gbTraCuuTheo";
            this.gbTraCuuTheo.Size = new System.Drawing.Size(312, 57);
            this.gbTraCuuTheo.TabIndex = 0;
            this.gbTraCuuTheo.TabStop = false;
            this.gbTraCuuTheo.Text = "Tra cứu theo";
            // 
            // rbNgay
            // 
            this.rbNgay.AutoSize = true;
            this.rbNgay.Location = new System.Drawing.Point(250, 23);
            this.rbNgay.Name = "rbNgay";
            this.rbNgay.Size = new System.Drawing.Size(83, 29);
            this.rbNgay.TabIndex = 2;
            this.rbNgay.TabStop = true;
            this.rbNgay.Text = "Ngày";
            this.rbNgay.UseVisualStyleBackColor = true;
            this.rbNgay.CheckedChanged += new System.EventHandler(this.rbNgay_CheckedChanged);
            // 
            // rbTenCoDau
            // 
            this.rbTenCoDau.AutoSize = true;
            this.rbTenCoDau.Location = new System.Drawing.Point(125, 23);
            this.rbTenCoDau.Name = "rbTenCoDau";
            this.rbTenCoDau.Size = new System.Drawing.Size(136, 29);
            this.rbTenCoDau.TabIndex = 1;
            this.rbTenCoDau.TabStop = true;
            this.rbTenCoDau.Text = "Tên cô dâu";
            this.rbTenCoDau.UseVisualStyleBackColor = true;
            this.rbTenCoDau.CheckedChanged += new System.EventHandler(this.rbTenCoDau_CheckedChanged);
            // 
            // rbTenChuRe
            // 
            this.rbTenChuRe.AutoSize = true;
            this.rbTenChuRe.Location = new System.Drawing.Point(7, 23);
            this.rbTenChuRe.Name = "rbTenChuRe";
            this.rbTenChuRe.Size = new System.Drawing.Size(131, 29);
            this.rbTenChuRe.TabIndex = 0;
            this.rbTenChuRe.TabStop = true;
            this.rbTenChuRe.Text = "Tên chú rể";
            this.rbTenChuRe.UseVisualStyleBackColor = true;
            this.rbTenChuRe.CheckedChanged += new System.EventHandler(this.rbTenChuRe_CheckedChanged);
            // 
            // gbNhapTuKhoa
            // 
            this.gbNhapTuKhoa.Controls.Add(this.dtpNgay);
            this.gbNhapTuKhoa.Controls.Add(this.btnTraCuu);
            this.gbNhapTuKhoa.Controls.Add(this.txtTuKhoa);
            this.gbNhapTuKhoa.Location = new System.Drawing.Point(340, 12);
            this.gbNhapTuKhoa.Name = "gbNhapTuKhoa";
            this.gbNhapTuKhoa.Size = new System.Drawing.Size(332, 57);
            this.gbNhapTuKhoa.TabIndex = 1;
            this.gbNhapTuKhoa.TabStop = false;
            this.gbNhapTuKhoa.Text = "Nhập từ khóa cần tra cứu";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(6, 22);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(214, 30);
            this.dtpNgay.TabIndex = 5;
            this.dtpNgay.Visible = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(226, 18);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(100, 30);
            this.btnTraCuu.TabIndex = 4;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(6, 22);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(214, 30);
            this.txtTuKhoa.TabIndex = 3;
            // 
            // gbKetQuaTraCuu
            // 
            this.gbKetQuaTraCuu.Controls.Add(this.dgvKetQuaTraCuu);
            this.gbKetQuaTraCuu.Location = new System.Drawing.Point(12, 75);
            this.gbKetQuaTraCuu.Name = "gbKetQuaTraCuu";
            this.gbKetQuaTraCuu.Size = new System.Drawing.Size(660, 224);
            this.gbKetQuaTraCuu.TabIndex = 2;
            this.gbKetQuaTraCuu.TabStop = false;
            this.gbKetQuaTraCuu.Text = "Kết quả tra cứu";
            // 
            // dgvKetQuaTraCuu
            // 
            this.dgvKetQuaTraCuu.AllowUserToAddRows = false;
            this.dgvKetQuaTraCuu.AllowUserToDeleteRows = false;
            this.dgvKetQuaTraCuu.AllowUserToResizeColumns = false;
            this.dgvKetQuaTraCuu.AllowUserToResizeRows = false;
            this.dgvKetQuaTraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTraCuu.Location = new System.Drawing.Point(7, 23);
            this.dgvKetQuaTraCuu.MultiSelect = false;
            this.dgvKetQuaTraCuu.Name = "dgvKetQuaTraCuu";
            this.dgvKetQuaTraCuu.ReadOnly = true;
            this.dgvKetQuaTraCuu.RowHeadersVisible = false;
            this.dgvKetQuaTraCuu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvKetQuaTraCuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTraCuu.Size = new System.Drawing.Size(647, 195);
            this.dgvKetQuaTraCuu.TabIndex = 0;
            this.dgvKetQuaTraCuu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTraCuu_CellContentClick);
            // 
            // frmTraCuuTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.gbKetQuaTraCuu);
            this.Controls.Add(this.gbNhapTuKhoa);
            this.Controls.Add(this.gbTraCuuTheo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTraCuuTiecCuoi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Tiệc Cưới";
            this.gbTraCuuTheo.ResumeLayout(false);
            this.gbTraCuuTheo.PerformLayout();
            this.gbNhapTuKhoa.ResumeLayout(false);
            this.gbNhapTuKhoa.PerformLayout();
            this.gbKetQuaTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTraCuuTheo;
        private System.Windows.Forms.RadioButton rbNgay;
        private System.Windows.Forms.RadioButton rbTenCoDau;
        private System.Windows.Forms.RadioButton rbTenChuRe;
        private System.Windows.Forms.GroupBox gbNhapTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox gbKetQuaTraCuu;
        private System.Windows.Forms.DataGridView dgvKetQuaTraCuu;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}