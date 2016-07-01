using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI.ucControlFeature
{
    public partial class ItemTraCuu : UserControl
    {
        public ItemTraCuu()
        {
            InitializeComponent();
        }

        private void btnTraCuuTiecCuoi_MouseHover(object sender, EventArgs e)
        {
            btnTraCuuTiecCuoi.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnTraCuuTiecCuoi_MouseLeave(object sender, EventArgs e)
        {
            btnTraCuuTiecCuoi.BackColor = Color.FromArgb(59, 56, 56);
        }
    }
}
