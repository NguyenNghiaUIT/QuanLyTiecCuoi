namespace QuanLyTiecCuoiUI.ucControlFeature
{
    partial class menuQuanLy
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
            this.tlpItem = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpItem
            // 
            this.tlpItem.ColumnCount = 1;
            this.tlpItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItem.Location = new System.Drawing.Point(0, 0);
            this.tlpItem.Name = "tlpItem";
            this.tlpItem.RowCount = 1;
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItem.Size = new System.Drawing.Size(235, 500);
            this.tlpItem.TabIndex = 0;
            // 
            // menuQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpItem);
            this.Name = "menuQuanLy";
            this.Size = new System.Drawing.Size(235, 500);
            this.Load += new System.EventHandler(this.menuQuanLy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItem;
    }
}
