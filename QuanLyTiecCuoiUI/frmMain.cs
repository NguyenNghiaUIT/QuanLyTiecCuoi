using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiecCuoiUI.ucControlFeature;

namespace QuanLyTiecCuoiUI
{
    public partial class frmMain : Form
    {
        #region parameters
        private bool MiniumMenu;
        private menuQuanLy quanly = new menuQuanLy();
        #endregion

        #region Khởi tạo form
        public frmMain()
        {
            InitializeComponent();
            SetStartStateForm();
        }
        public void SetStartStateForm()
        {
            MiniumMenu = false;
            pnlRight.Size = new Size(235, base.Height);
            tlpMenuItem.RowStyles[0].Height = 10;
            tlpMenuItem.RowStyles[1].Height = 0;
            tlpMenuItem.RowStyles[2].Height = 10;
            tlpMenuItem.RowStyles[3].Height = 0;
            tlpMenuItem.RowStyles[4].Height = 10;
            tlpMenuItem.RowStyles[5].Height = 0;
            tlpMenuItem.RowStyles[6].Height = 10;
            tlpMenuItem.RowStyles[7].Height = 0;
            tlpMenuItem.RowStyles[8].Height = 60;
        }
        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region Sự kiện button menu
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (!MiniumMenu)
            {
                pnlRight.Size = new Size(60, base.Height);
                MiniumMenu = true;
            }             
            else
            {
                pnlRight.Size = new Size(235, base.Height);
                MiniumMenu = false;
            }
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            tlpMenuItem.RowStyles[1].Height = 55;
            tlpMenuItem.RowStyles[8].Height = 5;
            quanly.LoadRoles(2);
            tlpMenuItem.Controls.Add(quanly, 0, 1);

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tra cứu");
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo");
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quy định");
        }
        #endregion
    }
}
