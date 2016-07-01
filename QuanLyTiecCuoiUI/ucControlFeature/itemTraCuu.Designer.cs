namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class ItemTraCuu
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
            this.btnTraCuuTiecCuoi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnTraCuuTiecCuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuuTiecCuoi
            // 
            this.btnTraCuuTiecCuoi.Image = global::QuanLyTiecCuoiUI.Properties.Resources.TraCuu_TracuuTiecCuoi;
            this.btnTraCuuTiecCuoi.Location = new System.Drawing.Point(23, 3);
            this.btnTraCuuTiecCuoi.Name = "btnTraCuuTiecCuoi";
            this.btnTraCuuTiecCuoi.Size = new System.Drawing.Size(170, 32);
            this.btnTraCuuTiecCuoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTraCuuTiecCuoi.TabIndex = 1;
            this.btnTraCuuTiecCuoi.TabStop = false;
            this.btnTraCuuTiecCuoi.MouseLeave += new System.EventHandler(this.btnTraCuuTiecCuoi_MouseLeave);
            this.btnTraCuuTiecCuoi.MouseHover += new System.EventHandler(this.btnTraCuuTiecCuoi_MouseHover);
            // 
            // ItemTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.btnTraCuuTiecCuoi);
            this.Name = "ItemTraCuu";
            this.Size = new System.Drawing.Size(230, 50);
            ((System.ComponentModel.ISupportInitialize)(this.btnTraCuuTiecCuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnTraCuuTiecCuoi;
    }
}
