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
    public partial class ItemQuanLy : UserControl
    {
        public ItemQuanLy()
        {
            InitializeComponent();
        }

        private void btnTiepNhanSanh_MouseHover(object sender, EventArgs e)
        {
            btnTiepNhanSanh.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnTiepNhanSanh_MouseLeave(object sender, EventArgs e)
        {
            btnTiepNhanSanh.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnQuanLySanh_MouseHover(object sender, EventArgs e)
        {
            btnQuanLySanh.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnQuanLySanh_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLySanh.BackColor = Color.FromArgb(59, 56, 56);
        }



        private void btnNhanDatTiecCuoi_MouseHover(object sender, EventArgs e)
        {
            btnNhanDatTiecCuoi.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnNhanDatTiecCuoi_MouseLeave(object sender, EventArgs e)
        {
            btnNhanDatTiecCuoi.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnQuanLyTiecCuoi_MouseHover(object sender, EventArgs e)
        {
            btnQuanLyTiecCuoi.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnQuanLyTiecCuoi_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLyTiecCuoi.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnLapHoaDonThanhToan_MouseHover(object sender, EventArgs e)
        {
            btnLapHoaDonThanhToan.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnLapHoaDonThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnLapHoaDonThanhToan.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnQuanLyKhachHang_MouseHover(object sender, EventArgs e)
        {
            btnQuanLyKhachHang.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnQuanLyKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLyKhachHang.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnQuanLyMonAn_MouseHover(object sender, EventArgs e)
        {
            btnQuanLyMonAn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnQuanLyMonAn_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLyMonAn.BackColor = Color.FromArgb(59, 56, 56);
        }

        private void btnQuanLyDichVu_MouseHover(object sender, EventArgs e)
        {
            btnQuanLyDichVu.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnQuanLyDichVu_MouseLeave(object sender, EventArgs e)
        {
            btnQuanLyDichVu.BackColor = Color.FromArgb(59, 56, 56);
        }
    }
}
