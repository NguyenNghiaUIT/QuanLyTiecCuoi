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
using DTO;

namespace QuanLyTiecCuoiUI
{
    public partial class frmLapHoaDonThanhToan : Form
    {
        private DTO.DTO_TiecCuoi tiecCuoiInfo;
        private DTO.DTO_PhieuDatBan phieuDatBan;
        private List<String> mTenCoDaus = new List<string>();
        private List<String> mTenChuRes = new List<string>();
        private String mTenCoDau;
        private String mTenChuRe;


        private bool isApplyQuyDinh;
        private String mNgayDaiTiec;

        private decimal tongTienDichVu;
        private decimal tongTienBan;
        private decimal tongTienHoaDon;
        private decimal soTienConLai;
        private decimal soTienDatCoc;
        private decimal tongTienTra;
        private decimal soTienPhat;
        private decimal soTienDaThanhToan;

        private int soNgayTre;

        private DateTime currentDate;
        public frmLapHoaDonThanhToan()
        {
            InitializeComponent();

        }



        private void frmLapHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            lblThanhToanXong.Visible = false;

            currentDate = DateTime.Now;
            lblNgayThanhToan.Text = currentDate.ToString("dd/MM/yyyy");
            mNgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
            DataTable dataTable = BUS.BUS_LapHoaDonThanhToan.GetAllTiecCuoi(mNgayDaiTiec);

            LoadTenChuReAndTenCoDau(dataTable);
            cbbTenCoDau.DataSource = mTenCoDaus;
            cbbTenChuRe.DataSource = mTenChuRes;
            cbbTenCoDau.SelectedIndex = cbbTenChuRe.SelectedIndex = -1;

            isApplyQuyDinh = QuanLyTiecCuoiUI.Properties.Settings.Default.ApplyQuyDinh;

            txtSoTienTra.Enabled = false;
            btnThanhToan.Enabled = false;
            btnLapHoaDon.Enabled = false;
        }


        private void cbbTenChuRe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbbTenchuRe");
            if (!btnLapHoaDon.Enabled)
                btnLapHoaDon.Enabled = true;
            if (cbbTenChuRe.Items.Count > 0)
            {
                mTenChuRe = cbbTenChuRe.Text;
            }
        }

        private void cbbTenCoDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbbTenCoDauChange");
            if (!btnLapHoaDon.Enabled)
                btnLapHoaDon.Enabled = true;
            if (cbbTenCoDau.Items.Count > 0)
            {
                mTenCoDau = cbbTenCoDau.Text;
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(mTenChuRe.Trim()) && String.IsNullOrWhiteSpace(mTenCoDau.Trim()))
            {
                MessageBox.Show("Bạn chưa chọn tên chú rể và tên cô dâu, Vui lòng chọn lại.", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

            //set up so ngay tre


            tiecCuoiInfo = BUS.BUS_LapHoaDonThanhToan.GetTiecCuoi(mTenChuRe, mTenCoDau, mNgayDaiTiec);
            if (tiecCuoiInfo != null)
            {
                phieuDatBan = BUS.BUS_LapHoaDonThanhToan.GetPhieuDatBan(tiecCuoiInfo.MaTiecCuoi);
                if (phieuDatBan != null)
                {
                    lblSoLuongBan.Text = phieuDatBan.SoBan.ToString();
                    lblDonGiaBan.Text = ConvertStringToCurrency(phieuDatBan.DonGiaBan);
                    tongTienBan = phieuDatBan.DonGiaBan * phieuDatBan.SoBan;
                    lblTongTienBan.Text = ConvertStringToCurrency(tongTienBan);

                    DataTable dataTableChiTietDichVu = BUS.BUS_LapHoaDonThanhToan.GetChiTietDichVu(tiecCuoiInfo.MaTiecCuoi);
                    dgvCacDichVu.DataSource = dataTableChiTietDichVu;

                    bool isLapHoaDon = BUS.BUS_LapHoaDonThanhToan.IsLapHoaDonThanhToan(tiecCuoiInfo.MaTiecCuoi);

                    if (isLapHoaDon)
                    {
                        List<DTO.DTO_HoaDon> hoaDons = BUS.BUS_HoaDon.GetAllHoaDon(tiecCuoiInfo.MaTiecCuoi);
                        if (hoaDons != null && hoaDons.Count > 0)
                        {
                            lblTienDaThanhToan.Text = "Số tiền đã trả";
                            DTO.DTO_HoaDon latestHoaDon = hoaDons[hoaDons.Count - 1];

                            soTienConLai = latestHoaDon.ConLai;
                            lblConLai.Text = ConvertStringToCurrency(soTienConLai);

                            tongTienDichVu = latestHoaDon.TongTienDichVu;
                            lblTongTienDV.Text = ConvertStringToCurrency(tongTienDichVu);

                            tongTienBan = latestHoaDon.TongTienBan;
                            lblTongTienBan.Text = ConvertStringToCurrency(tongTienBan);

                            tongTienHoaDon = latestHoaDon.TongTienHoaDon;
                            lblTongTienHD.Text = ConvertStringToCurrency(tongTienHoaDon);

                        
                            decimal tongTienDaThanhToan = 0;
                            foreach (DTO_HoaDon hoadon in hoaDons)
                            {
                                tongTienDaThanhToan += hoadon.TienDaThanhToan;
                            }

                            String[] strNgayDaiTiec = latestHoaDon.NgayThanhToan.Split('/');
                            DateTime ngayThanhToanGanNhat = new DateTime(int.Parse(strNgayDaiTiec[2]), int.Parse(strNgayDaiTiec[0]), int.Parse(strNgayDaiTiec[1]));
                            soNgayTre = currentDate.Subtract(ngayThanhToanGanNhat).Days;


                            lblNTTInfo.Text = "Ngày thanh toán gần đây:";
                            lblNgayThanhToan.Text = ngayThanhToanGanNhat.ToString("dd/MM/yyyy");
                            lblSoNgayTre.Text = soNgayTre.ToString();

                            soTienDaThanhToan = tongTienDaThanhToan;
                            lblTienDatCoc.Text = ConvertStringToCurrency(soTienDaThanhToan);
                            tongTienTra = soTienConLai;
                            lblTongTienThanhToan.Text = ConvertStringToCurrency(tongTienTra);

                            if (tongTienTra == 0)
                            {
                                gbThanhToan.Controls.Remove(btnThanhToan);
                                gbThanhToan.Controls.Remove(lblSoTienTra);
                                gbThanhToan.Controls.Remove(txtSoTienTra);
                                gbThanhToan.Controls.Remove(lblStart);
                                txtSoTienTra.Enabled = false;
                                btnThanhToan.Enabled = false;
                                lblThanhToanXong.Visible = true;
                                return;
                            }

                        }
                    }
                    else
                    {
                        soTienDatCoc = tiecCuoiInfo.TienCoc;
                        lblTienDatCoc.Text = ConvertStringToCurrency(soTienDatCoc);

                        tongTienDichVu = BUS.BUS_LapHoaDonThanhToan.GetTongTienDichVu(tiecCuoiInfo.MaTiecCuoi);
                        lblTongTienDV.Text = ConvertStringToCurrency(tongTienDichVu);
                        tongTienHoaDon = tongTienBan + tongTienDichVu;
                        lblTongTienHD.Text = ConvertStringToCurrency(tongTienHoaDon);
                        soTienConLai = tongTienHoaDon - soTienDatCoc;
                        lblConLai.Text = ConvertStringToCurrency(soTienConLai);


                        String[] strNgayDaiTiec = mNgayDaiTiec.Split('/');
                        DateTime ngayDaiTiecDatetime = new DateTime(int.Parse(strNgayDaiTiec[2]), int.Parse(strNgayDaiTiec[0]), int.Parse(strNgayDaiTiec[1]));
                        soNgayTre = currentDate.Subtract(ngayDaiTiecDatetime).Days;
                        lblSoNgayTre.Text = soNgayTre.ToString();
                        lblResult.Text = "";

                        //chiTietPhieuDatBanDataTable = BUS.BUS_LapHoaDonThanhToan.GetChiTietDatBan(phieuDatBan.MaPhieuDatBan);
                        //if (chiTietPhieuDatBanDataTable.Rows.Count > 0)
                        //{
                        //    if (chiTietPhieuDatBanDataTable != null)
                        //    {
                        //        foreach (DataRow row in chiTietPhieuDatBanDataTable.Rows)
                        //        {
                        //            foreach (DataColumn column in chiTietPhieuDatBanDataTable.Columns)
                        //            {
                        //                Console.WriteLine(row[column].ToString());
                        //            }
                        //        }
                        //    }
                        //}
                    }
                }

                if (isApplyQuyDinh)
                {
                    float phanTramPhat = BUS.BUS_ThamSo.GetThamSo().GiaTri;
                    lblPhanTramPhat.Text = phanTramPhat.ToString() + "%";
                    soTienPhat = (decimal)((float)soTienConLai * 0.01f) * soNgayTre;
                    lblTongTienPhat.Text = ConvertStringToCurrency(soTienPhat);
                    tongTienTra = soTienConLai + soTienPhat;
                    lblTongTienThanhToan.Text = ConvertStringToCurrency(soTienConLai + soTienPhat);
                }
                else
                {
                    lblPhanTramPhat.Text = "Không áp dụng";
                }

               
            }

            txtSoTienTra.Enabled = true;
            btnThanhToan.Enabled = true;
            btnLapHoaDon.Enabled = false;
            cbbTenCoDau.Enabled = false;
            cbbTenChuRe.Enabled = false;
            dtpNgayDaiTiec.Enabled = false;



        }
        private void dtpNgayDaiTiec_ValueChanged(object sender, EventArgs e)
        {

            resetControl();
            mTenCoDaus.Clear();
            mTenChuRes.Clear();
            cbbTenCoDau.DataSource = null;
            cbbTenChuRe.DataSource = null;
            dgvCacDichVu.DataSource = null;

            mNgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
            Console.WriteLine(mNgayDaiTiec);
            DataTable dataTable = BUS.BUS_LapHoaDonThanhToan.GetAllTiecCuoi(mNgayDaiTiec);
            LoadTenChuReAndTenCoDau(dataTable);

            if (mTenChuRes.Count > 0)
            {
                cbbTenChuRe.DataSource = mTenChuRes;
                cbbTenCoDau.DataSource = mTenCoDaus;
                cbbTenChuRe.SelectedIndex = cbbTenCoDau.SelectedIndex = 0;
            }

            int rows = dataTable.Rows.Count;
            Console.WriteLine(rows);
        }

        private void LoadTenChuReAndTenCoDau(DataTable dataTable)
        {
            if (dataTable == null)
                return;
            foreach (DataRow row in dataTable.Rows)
            {
                mTenChuRes.Add(row["TenChuRe"].ToString());
                mTenCoDaus.Add(row["TenCoDau"].ToString());
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            String soTienTraStr = txtSoTienTra.Text;
            decimal soTienTra = 0;
            if (String.IsNullOrWhiteSpace(soTienTraStr))
            {

                MessageBox.Show("Số tiền trả không được để trống", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
            try
            {
                soTienTra = decimal.Parse(soTienTraStr);
            }
            catch
            {
                MessageBox.Show("Số tiền trả không đúng format!", "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }

            DialogResult dlResult = MessageBox.Show("Bạn có muốn thanh toán không?", "Xác nhận", MessageBoxButtons.OK);
            if (dlResult == System.Windows.Forms.DialogResult.OK)
            {
                DTO.DTO_HoaDon hoaDon = new DTO.DTO_HoaDon();
                hoaDon.MaTiecCuoi = tiecCuoiInfo.MaTiecCuoi;
                hoaDon.NgayThanhToan = currentDate.ToString("MM/dd/yyyy");
                hoaDon.TongTienBan = tongTienBan;
                hoaDon.TienDaThanhToan = soTienDatCoc + soTienTra;
                hoaDon.TongTienDichVu = tongTienDichVu;
                hoaDon.TongTienHoaDon = tongTienHoaDon;
                hoaDon.ConLai = tongTienTra - soTienTra;

                if (hoaDon.ConLai < 0)
                {
                    txtSoTienTra.Text = "";
                    MessageBox.Show("Số tiền thanh toán không được lớn hơn tổng tiền", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                //TODO Thanh Toan Xong
                if (hoaDon.ConLai == 0)
                    tiecCuoiInfo.TinhTrangTiec = 1;
                else //TODO Con No
                    tiecCuoiInfo.TinhTrangTiec = 2;

                if (BUS.BUS_HoaDon.InsertHoaDon(hoaDon))
                {
                    BUS.BUS_LapHoaDonThanhToan.UpdateTiecCuoi(tiecCuoiInfo);
                    gbThanhToan.Controls.Remove(btnThanhToan);
                    gbThanhToan.Controls.Remove(lblSoTienTra);
                    gbThanhToan.Controls.Remove(txtSoTienTra);
                    gbThanhToan.Controls.Remove(lblStart);
                    lblThanhToanXong.Visible = true;
                    lblThanhToanXong.Text = "Thanh toán thành công";
                    cbbTenChuRe.Enabled = true;
                    cbbTenCoDau.Enabled = true;
                    dtpNgayDaiTiec.Enabled = true;
                    btnLapHoaDon.Enabled = true;

                    btnThanhToan.Enabled = false;
                    txtSoTienTra.ReadOnly = true;
                }
                else
                    MessageBox.Show("Thanh thất bại!", "Thông báo", MessageBoxButtons.OK);
            }


        }

        private void resetControl()
        {
            lblConLai.Text = "-";
            lblDonGiaBan.Text = "-";
            lblPhanTramPhat.Text = "-";
            lblSoLuongBan.Text = "-";
            lblSoNgayTre.Text = "-";
            lblTienDatCoc.Text = "-";
            lblTongTienBan.Text = "-";
            lblTongTienDV.Text = "-";
            lblTongTienHD.Text = "-";
            lblTongTienPhat.Text = "-";
            lblTongTienThanhToan.Text = "-";

            //if(!gbThanhToan.Controls.Contains(btnThanhToan))
            //    gbThanhToan.Controls.Add(btnThanhToan);

            //if (!gbThanhToan.Controls.Contains(lblSoTienTra))
            //    gbThanhToan.Controls.Add(lblSoTienTra);

            //if (!gbThanhToan.Controls.Contains(txtSoTienTra))
            //    gbThanhToan.Controls.Add(txtSoTienTra);

            //if (!gbThanhToan.Controls.Contains(lblStart))
            //    gbThanhToan.Controls.Add(lblStart);

            //if(gbThanhToan.Controls.Contains(lblThanhToanXong))
            //    gbThanhToan.Controls.Remove(lblThanhToanXong);
            
        }

        private void cbThanhToanTruoc_CheckedChanged(object sender, EventArgs e)
        {
            lblTienDaThanhToan.Text = "Tiền đã thanh toán: ";
        }

        private void txtSoTienTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private string ConvertStringToCurrency(decimal value)
        {
            return String.Format("{0:c}", value);
        }






    }
}
