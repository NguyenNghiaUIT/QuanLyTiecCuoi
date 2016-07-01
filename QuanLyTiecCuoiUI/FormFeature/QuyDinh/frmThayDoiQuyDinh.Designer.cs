namespace QuanLyTiecCuoiUI.FormFeature.QuyDinh
{
    partial class frmThayDoiQuyDinh
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
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.lblTenQuyDinh = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.txtTenQuyDinh = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnEditQuyDinh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Location = new System.Drawing.Point(12, 156);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuyDinh.Size = new System.Drawing.Size(638, 154);
            this.dgvQuyDinh.TabIndex = 0;
            // 
            // lblTenQuyDinh
            // 
            this.lblTenQuyDinh.AutoSize = true;
            this.lblTenQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuyDinh.Location = new System.Drawing.Point(147, 12);
            this.lblTenQuyDinh.Name = "lblTenQuyDinh";
            this.lblTenQuyDinh.Size = new System.Drawing.Size(104, 17);
            this.lblTenQuyDinh.TabIndex = 1;
            this.lblTenQuyDinh.Text = "Tên Quy Định: ";
            this.lblTenQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.Location = new System.Drawing.Point(147, 45);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(55, 17);
            this.lblGiaTri.TabIndex = 2;
            this.lblGiaTri.Text = "Giá Trị:";
            // 
            // txtTenQuyDinh
            // 
            this.txtTenQuyDinh.Location = new System.Drawing.Point(258, 12);
            this.txtTenQuyDinh.Name = "txtTenQuyDinh";
            this.txtTenQuyDinh.Size = new System.Drawing.Size(184, 20);
            this.txtTenQuyDinh.TabIndex = 3;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(258, 45);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(184, 20);
            this.txtGiaTri.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(133, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Quy Định";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnEditQuyDinh
            // 
            this.btnEditQuyDinh.Location = new System.Drawing.Point(258, 101);
            this.btnEditQuyDinh.Name = "btnEditQuyDinh";
            this.btnEditQuyDinh.Size = new System.Drawing.Size(94, 23);
            this.btnEditQuyDinh.TabIndex = 6;
            this.btnEditQuyDinh.Text = "Sửa Quy Định";
            this.btnEditQuyDinh.UseVisualStyleBackColor = true;
            this.btnEditQuyDinh.Click += new System.EventHandler(this.btnEditQuyDinh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(393, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 322);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditQuyDinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.txtTenQuyDinh);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.lblTenQuyDinh);
            this.Controls.Add(this.dgvQuyDinh);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Quản Lý Quy Định";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.Label lblTenQuyDinh;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.TextBox txtTenQuyDinh;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnEditQuyDinh;
        private System.Windows.Forms.Button btnSave;
    }
}