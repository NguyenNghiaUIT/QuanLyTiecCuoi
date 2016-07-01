namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class ItemQuyDinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuanLyCa = new System.Windows.Forms.PictureBox();
            this.btnQuanLyLoaiSanh = new System.Windows.Forms.PictureBox();
            this.btnThayDoiQuyDinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyLoaiSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThayDoiQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuanLyCa
            // 
            this.btnQuanLyCa.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Ca_QuanLyCa;
            this.btnQuanLyCa.Location = new System.Drawing.Point(23, 81);
            this.btnQuanLyCa.Name = "btnQuanLyCa";
            this.btnQuanLyCa.Size = new System.Drawing.Size(186, 34);
            this.btnQuanLyCa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuanLyCa.TabIndex = 5;
            this.btnQuanLyCa.TabStop = false;
            // 
            // btnQuanLyLoaiSanh
            // 
            this.btnQuanLyLoaiSanh.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Sanh_QuanLyLoaiSanh;
            this.btnQuanLyLoaiSanh.Location = new System.Drawing.Point(23, 41);
            this.btnQuanLyLoaiSanh.Name = "btnQuanLyLoaiSanh";
            this.btnQuanLyLoaiSanh.Size = new System.Drawing.Size(186, 34);
            this.btnQuanLyLoaiSanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuanLyLoaiSanh.TabIndex = 4;
            this.btnQuanLyLoaiSanh.TabStop = false;
            // 
            // btnThayDoiQuyDinh
            // 
            this.btnThayDoiQuyDinh.Image = global::QuanLyTiecCuoiUI.Properties.Resources.QuyDinh_ThayDoiQuyDinh;
            this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(23, 3);
            this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
            this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(186, 32);
            this.btnThayDoiQuyDinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThayDoiQuyDinh.TabIndex = 3;
            this.btnThayDoiQuyDinh.TabStop = false;
            this.btnThayDoiQuyDinh.MouseLeave += new System.EventHandler(this.btnLapBaoCaoDoanhSo_MouseLeave);
            this.btnThayDoiQuyDinh.MouseHover += new System.EventHandler(this.btnLapBaoCaoDoanhSo_MouseHover);
            // 
            // ItemQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.btnQuanLyCa);
            this.Controls.Add(this.btnQuanLyLoaiSanh);
            this.Controls.Add(this.btnThayDoiQuyDinh);
            this.Name = "ItemQuyDinh";
            this.Size = new System.Drawing.Size(230, 130);
            this.Load += new System.EventHandler(this.ItemQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyLoaiSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThayDoiQuyDinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnThayDoiQuyDinh;
        private System.Windows.Forms.PictureBox btnQuanLyLoaiSanh;
        private System.Windows.Forms.PictureBox btnQuanLyCa;
    }
}
