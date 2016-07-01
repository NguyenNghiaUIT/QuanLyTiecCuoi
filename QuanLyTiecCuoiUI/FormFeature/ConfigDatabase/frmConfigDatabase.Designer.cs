namespace QuanLyTiecCuoiUI.FormFeature.ConfigDatabase
{
    partial class frmConfigDatabase
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
            this.lblDataSource = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.txtDataSouce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(21, 30);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(102, 13);
            this.lblDataSource.TabIndex = 0;
            this.lblDataSource.Text = "Nhập Data Source: ";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(256, 53);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // txtDataSouce
            // 
            this.txtDataSouce.Location = new System.Drawing.Point(142, 27);
            this.txtDataSouce.Name = "txtDataSouce";
            this.txtDataSouce.Size = new System.Drawing.Size(355, 20);
            this.txtDataSouce.TabIndex = 2;
            // 
            // frmConfigDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 102);
            this.Controls.Add(this.txtDataSouce);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.lblDataSource);
            this.Name = "frmConfigDatabase";
            this.Text = "Config Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox txtDataSouce;
    }
}