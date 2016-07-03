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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenQuyDinh = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.cbApDung = new System.Windows.Forms.CheckBox();
            this.btnEditQuyDinh = new System.Windows.Forms.Button();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblApDung = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenQuyDinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // lblTenQuyDinh
            // 
            this.lblTenQuyDinh.AutoSize = true;
            this.lblTenQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuyDinh.Location = new System.Drawing.Point(15, 39);
            this.lblTenQuyDinh.Name = "lblTenQuyDinh";
            this.lblTenQuyDinh.Size = new System.Drawing.Size(96, 17);
            this.lblTenQuyDinh.TabIndex = 15;
            this.lblTenQuyDinh.Text = "Tên Quy Định";
            this.lblTenQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.Location = new System.Drawing.Point(200, 39);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(51, 17);
            this.lblGiaTri.TabIndex = 16;
            this.lblGiaTri.Text = "Giá Trị";
            // 
            // cbApDung
            // 
            this.cbApDung.AutoSize = true;
            this.cbApDung.Location = new System.Drawing.Point(357, 72);
            this.cbApDung.Name = "cbApDung";
            this.cbApDung.Size = new System.Drawing.Size(15, 14);
            this.cbApDung.TabIndex = 20;
            this.cbApDung.UseVisualStyleBackColor = true;
            // 
            // btnEditQuyDinh
            // 
            this.btnEditQuyDinh.Location = new System.Drawing.Point(446, 63);
            this.btnEditQuyDinh.Name = "btnEditQuyDinh";
            this.btnEditQuyDinh.Size = new System.Drawing.Size(94, 30);
            this.btnEditQuyDinh.TabIndex = 18;
            this.btnEditQuyDinh.Text = "Sửa";
            this.btnEditQuyDinh.UseVisualStyleBackColor = true;
            this.btnEditQuyDinh.Click += new System.EventHandler(this.btnEditQuyDinh_Click);
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(182, 66);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(102, 23);
            this.txtGiaTri.TabIndex = 17;
            // 
            // lblApDung
            // 
            this.lblApDung.AutoSize = true;
            this.lblApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApDung.Location = new System.Drawing.Point(342, 39);
            this.lblApDung.Name = "lblApDung";
            this.lblApDung.Size = new System.Drawing.Size(61, 17);
            this.lblApDung.TabIndex = 21;
            this.lblApDung.Text = "Áp dụng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenQuyDinh);
            this.groupBox1.Controls.Add(this.lblApDung);
            this.groupBox1.Controls.Add(this.txtGiaTri);
            this.groupBox1.Controls.Add(this.btnEditQuyDinh);
            this.groupBox1.Controls.Add(this.cbApDung);
            this.groupBox1.Controls.Add(this.lblGiaTri);
            this.groupBox1.Controls.Add(this.lblTenQuyDinh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy định";
            // 
            // txtTenQuyDinh
            // 
            this.txtTenQuyDinh.Location = new System.Drawing.Point(18, 66);
            this.txtTenQuyDinh.Name = "txtTenQuyDinh";
            this.txtTenQuyDinh.Size = new System.Drawing.Size(131, 23);
            this.txtTenQuyDinh.TabIndex = 22;
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 195);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Quản Lý Quy Định";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenQuyDinh;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.CheckBox cbApDung;
        private System.Windows.Forms.Button btnEditQuyDinh;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblApDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenQuyDinh;

    }
}