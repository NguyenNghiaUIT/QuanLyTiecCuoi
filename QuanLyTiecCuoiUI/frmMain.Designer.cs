namespace QuanLyTiecCuoiUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tlpMenuItem = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.ovalAvatar = new QuanLyTiecCuoiUI.NewAssets.OvalPictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.tlpMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.btnMainMenu);
            this.pnlTop.Controls.Add(this.ovalAvatar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1264, 66);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlRight.Controls.Add(this.tlpMenuItem);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(0, 66);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(235, 615);
            this.pnlRight.TabIndex = 1;
            // 
            // tlpMenuItem
            // 
            this.tlpMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tlpMenuItem.ColumnCount = 1;
            this.tlpMenuItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuItem.Controls.Add(this.btnQuanLy, 0, 0);
            this.tlpMenuItem.Controls.Add(this.btnTraCuu, 0, 2);
            this.tlpMenuItem.Controls.Add(this.btnLapBaoCao, 0, 4);
            this.tlpMenuItem.Controls.Add(this.btnThayDoiQuyDinh, 0, 6);
            this.tlpMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuItem.Location = new System.Drawing.Point(0, 0);
            this.tlpMenuItem.Name = "tlpMenuItem";
            this.tlpMenuItem.RowCount = 9;
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpMenuItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMenuItem.Size = new System.Drawing.Size(235, 615);
            this.tlpMenuItem.TabIndex = 0;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuanLy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnQuanLy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQuanLy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuanLy.Image = global::QuanLyTiecCuoiUI.Properties.Resources.tag_manager_icon;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(3, 3);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(229, 55);
            this.btnQuanLy.TabIndex = 0;
            this.btnQuanLy.Text = "          QUẢN LÝ";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTraCuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTraCuu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(3, 64);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(229, 55);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "          TRA CỨU";
            this.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLapBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLapBaoCao.FlatAppearance.BorderSize = 0;
            this.btnLapBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnLapBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLapBaoCao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLapBaoCao.Image = global::QuanLyTiecCuoiUI.Properties.Resources.Sales_report_icon;
            this.btnLapBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapBaoCao.Location = new System.Drawing.Point(3, 125);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(229, 55);
            this.btnLapBaoCao.TabIndex = 2;
            this.btnLapBaoCao.Text = "          LẬP BÁO CÁO";
            this.btnLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // btnThayDoiQuyDinh
            // 
            this.btnThayDoiQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThayDoiQuyDinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnThayDoiQuyDinh.FlatAppearance.BorderSize = 0;
            this.btnThayDoiQuyDinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThayDoiQuyDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThayDoiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnThayDoiQuyDinh.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnThayDoiQuyDinh.Image = global::QuanLyTiecCuoiUI.Properties.Resources.settings_icon;
            this.btnThayDoiQuyDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(3, 186);
            this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
            this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(229, 55);
            this.btnThayDoiQuyDinh.TabIndex = 3;
            this.btnThayDoiQuyDinh.Text = "          QUY ĐỊNH";
            this.btnThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiQuyDinh.UseVisualStyleBackColor = true;
            this.btnThayDoiQuyDinh.Click += new System.EventHandler(this.btnThayDoiQuyDinh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.logongang_min1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(611, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 36);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackgroundImage = global::QuanLyTiecCuoiUI.Properties.Resources.menu_start_taskbar_and_window_panel_list_512;
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 26);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // ovalAvatar
            // 
            this.ovalAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalAvatar.BackColor = System.Drawing.Color.DarkGray;
            this.ovalAvatar.Location = new System.Drawing.Point(1205, 6);
            this.ovalAvatar.Name = "ovalAvatar";
            this.ovalAvatar.Size = new System.Drawing.Size(50, 50);
            this.ovalAvatar.TabIndex = 0;
            this.ovalAvatar.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.tlpMenuItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private NewAssets.OvalPictureBox ovalAvatar;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenuItem;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.Button btnThayDoiQuyDinh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}