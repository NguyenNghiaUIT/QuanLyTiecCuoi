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
    public partial class ItemBaoCao : UserControl
    {
        public ItemBaoCao()
        {
            InitializeComponent();
        }

        private void btnLapBaoCaoDoanhSo_MouseHover(object sender, EventArgs e)
        {
            btnLapBaoCaoDoanhSo.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnLapBaoCaoDoanhSo_MouseLeave(object sender, EventArgs e)
        {
            btnLapBaoCaoDoanhSo.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void ItemBaoCao_Load(object sender, EventArgs e)
        {

        }

    }
}
