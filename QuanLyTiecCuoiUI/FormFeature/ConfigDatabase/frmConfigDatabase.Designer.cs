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
            this.lblServerName = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.txtDataSouce = new System.Windows.Forms.TextBox();
            this.lbDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(21, 30);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(75, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name: ";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(254, 101);
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
            this.txtDataSouce.Text = "(local)";
            // 
            // lbDatabaseName
            // 
            this.lbDatabaseName.AutoSize = true;
            this.lbDatabaseName.Location = new System.Drawing.Point(24, 74);
            this.lbDatabaseName.Name = "lbDatabaseName";
            this.lbDatabaseName.Size = new System.Drawing.Size(87, 13);
            this.lbDatabaseName.TabIndex = 3;
            this.lbDatabaseName.Text = "Database Name:";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(142, 66);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(355, 20);
            this.txtDatabaseName.TabIndex = 4;
            this.txtDatabaseName.Text = "QuanLyTiecCuoi";
            // 
            // frmConfigDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 164);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.lbDatabaseName);
            this.Controls.Add(this.txtDataSouce);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.lblServerName);
            this.Name = "frmConfigDatabase";
            this.Text = "Config Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox txtDataSouce;
        private System.Windows.Forms.Label lbDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseName;
    }
}