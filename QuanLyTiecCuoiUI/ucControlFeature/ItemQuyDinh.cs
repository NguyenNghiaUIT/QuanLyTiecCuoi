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
    public partial class ItemQuyDinh : UserControl
    {
        public ItemQuyDinh()
        {
            InitializeComponent();
        }

        private void btnLapBaoCaoDoanhSo_MouseHover(object sender, EventArgs e)
        {
            btnThayDoiQuyDinh.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnLapBaoCaoDoanhSo_MouseLeave(object sender, EventArgs e)
        {
            btnThayDoiQuyDinh.BackColor = Color.FromArgb(59, 56, 56);
        }
        private void btnQuanLyLoaiSanh_MouseHover(object sender, EventArgs e)
        {
            btnQuanLyLoaiSanh.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void btnQuanLyLoaiSanh_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLyLoaiSanh.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void ItemQuyDinh_Load(object sender, EventArgs e)
        {

        }
    }
}
