namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class ItemBaoCao
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
            this.btnLapBaoCaoDoanhSo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLapBaoCaoDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapBaoCaoDoanhSo
            // 
            this.btnLapBaoCaoDoanhSo.Image = global::QuanLyTiecCuoiUI.Properties.Resources.DoanhSo_lapDoanhSo;
            this.btnLapBaoCaoDoanhSo.Location = new System.Drawing.Point(23, 3);
            this.btnLapBaoCaoDoanhSo.Name = "btnLapBaoCaoDoanhSo";
            this.btnLapBaoCaoDoanhSo.Size = new System.Drawing.Size(186, 32);
            this.btnLapBaoCaoDoanhSo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLapBaoCaoDoanhSo.TabIndex = 2;
            this.btnLapBaoCaoDoanhSo.TabStop = false;
            this.btnLapBaoCaoDoanhSo.MouseLeave += new System.EventHandler(this.btnLapBaoCaoDoanhSo_MouseLeave);
            this.btnLapBaoCaoDoanhSo.MouseHover += new System.EventHandler(this.btnLapBaoCaoDoanhSo_MouseHover);
            // 
            // ItemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.btnLapBaoCaoDoanhSo);
            this.Name = "ItemBaoCao";
            this.Size = new System.Drawing.Size(230, 50);
            this.Load += new System.EventHandler(this.ItemBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLapBaoCaoDoanhSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnLapBaoCaoDoanhSo;
    }
}
