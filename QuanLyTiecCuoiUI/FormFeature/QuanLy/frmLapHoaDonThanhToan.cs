using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyTiecCuoiUI
{
    public partial class frmLapHoaDonThanhToan : Form
    {
        private DateTime currentDate;
        public frmLapHoaDonThanhToan()
        {
            InitializeComponent();
            cbbTenChuRe.MouseWheel += cbbTenChuRe_MouseWheel;
            cbbTenCoDau.MouseWheel += cbbTenCoDau_MouseWheel;
        }

        void cbbTenCoDau_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        void cbbTenChuRe_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void frmLapHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            cbbTenChuRe.DataSource = BUS_LapHoaDonThanhToan.GetListTenChuRe();
            cbbTenCoDau.DataSource = BUS_LapHoaDonThanhToan.GetListTenCoDau();
            currentDate = DateTime.Now;
            lblNgayThanhToan.Text = currentDate.Day + "/" + currentDate.Month + "/" + currentDate.Year;
        }

        private void cbbTenChuRe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenCoDau.Items.Count > 0)
            {
                cbbTenCoDau.SelectedIndex = cbbTenChuRe.SelectedIndex;
                cbbNgayDatTiec.DataSource = BUS_LapHoaDonThanhToan.GetListNgayDatTiec(cbbTenChuRe.Text);
            }
        }

        private void cbbTenCoDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenChuRe.Items.Count > 0)
            {
                cbbTenChuRe.SelectedIndex = cbbTenCoDau.SelectedIndex;
                cbbNgayDatTiec.DataSource = BUS_LapHoaDonThanhToan.GetListNgayDatTiec(cbbTenChuRe.Text);
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            string tenChuRe = cbbTenChuRe.Text;
            string tenCoDau = cbbTenCoDau.Text;
            if (String.IsNullOrEmpty(tenChuRe) && String.IsNullOrEmpty(tenCoDau))
                return;

            DTO.DTO_TiecCuoi tiecCuoi = BUS.BUS_LapHoaDonThanhToan.GetTiecCuoi(tenChuRe, tenCoDau);
            if (tiecCuoi == null)
                return;

            DataTable chiTietDichVu = BUS.BUS_LapHoaDonThanhToan.GetChiTietDichVu(tiecCuoi.MaTiecCuoi);
            DTO.DTO_PhieuDatBan phieuDatBan = BUS.BUS_LapHoaDonThanhToan.GetPhieuDatBan(tiecCuoi.MaTiecCuoi);
            DataTable chiTietPhieuDatBan = BUS.BUS_LapHoaDonThanhToan.GetChiTietDatBan(phieuDatBan.MaPhieuDatBan);

            lblNgayThanhToan.Text = DateTime.Now.ToShortDateString();
            
            int soBan = phieuDatBan.SoBan;
            lblSoLuongBan.Text = soBan.ToString();
            decimal donGiaBan = phieuDatBan.DonGiaBan;
            lblDonGiaBan.Text = donGiaBan.ToString();
            lblTongTienBan.Text = (donGiaBan * soBan).ToString();
            



            // load hoa don len giao dien
            //BUS_LapHoaDonThanhToan.GetHoaDon(cbbTenChuRe.Text, cbbNgayDatTiec.Text);
            //lblSoLuongBan.Text = BUS_LapHoaDonThanhToan.GetSoLuongBan();
            //lblDonGiaBan.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetDonGiaBan());
            //lblTongTienBan.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetTongTienBan());
            //dgvCacDichVu.DataSource = BUS_LapHoaDonThanhToan.GetCacDichVu();
            //lblTongTienDV.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetTongTienDichVu());
            //lblTongTienHD.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetTongTienHoaDon());
            //lblTienDatCoc.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetTienDatCoc());
            //lblConLai.Text = string.Format("{0:n0}",BUS_LapHoaDonThanhToan.GetTienConLai());

            //double soNgayTre = (DateTime.Parse(lblNgayThanhToan.Text) - DateTime.Parse(cbbNgayDatTiec.Text)).TotalDays;
            //lblSoNgayTre.Text = soNgayTre.ToString();
            //lblPhanTramPhat.Text = "1";
            //double conLai = double.Parse(lblConLai.Text);
            //double tienPhat = conLai * 0.01 * soNgayTre;
            //double tongTien = conLai + tienPhat;
            //lblTongTienPhat.Text = string.Format("{0:n0}", tienPhat);
            //lblTongTienThanhToan.Text = string.Format("{0:n0}",tongTien);
        }
    }
}
