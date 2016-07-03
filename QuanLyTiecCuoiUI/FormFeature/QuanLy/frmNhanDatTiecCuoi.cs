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
    public partial class frmNhanDatTiecCuoi : Form
    {
        #region Parameters
        private bool IsCreateMenu = false;
        private bool IsTakeWedding = false;
        private bool IsCreateContract = false;
        private DTO_TiecCuoi dattieccuoi = new DTO_TiecCuoi();
        private List<DTO_CT_PhieuDatBan> lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
        private List<DTO_CT_PhieuDatDichVu> lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
        private List<Decimal> lstGiaSanh = new List<decimal>();
        private DataTable dtMonAn;
        private DataTable dtDichVu;
        #endregion

        #region Constructor & load data
        private void ShowNotification(bool state)
        {
            NotCa.Visible = NotChuRe.Visible = NotCoDau.Visible = NotNgayDaiTiec.Visible = NotSanh.Visible = NotTienDatCoc.Visible = state;
            lblNotification.Visible = state;
        }
        private void SetupDefaultControlState()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtDienThoai.Text = string.Empty;
            txtGhiChuThongTinTiecCuoi.Text = txtTienDatCoc.Text = string.Empty;
            lblGiaSanh.Text = string.Empty;
            btnXuatHopDong.Enabled = false;
            dtpNgayDatTiec.Value = DateTime.Now;
            dtpNgayDaiTiec.Value = DateTime.Now.AddDays(1);
        }
        private void SetupFormSizeDefault(bool state)
        {
            if (!state)
                this.Size = new Size(530, 570);
            else
                this.Size = new Size(835, 570);
        }
        public frmNhanDatTiecCuoi()
        {
            InitializeComponent();
            //Setup state default
            SetupFormSizeDefault(false);           
            SetupDefaultControlState();
            //Load
            LoadSanhAndCa();
            LoadMonAn();
            LoadDichVu();

            ShowNotification(false);
        }
        private void LoadMonAn()
        {
            dtMonAn = new DataTable();
            dtMonAn = BUS_MonAn.GetDataTableMonAn();
            cboDanhSachMonAn.DataSource = dtMonAn;
            cboDanhSachMonAn.DisplayMember = dtMonAn.Columns["TenMonAn"].ToString();
            cboDanhSachMonAn.ValueMember = dtMonAn.Columns["MaMonAn"].ToString();
            cboDanhSachMonAn.SelectedIndex = 0;
        }
        private void LoadDichVu()
        {
            dtDichVu = new DataTable();
            dtDichVu = BUS_DichVuNhaHang.GetDataDichVu();
            cboDanhSachDichVu.DataSource = dtDichVu;
            cboDanhSachDichVu.DisplayMember = dtDichVu.Columns["TenDichVu"].ToString();
            cboDanhSachDichVu.ValueMember = dtDichVu.Columns["MaDichVu"].ToString();
            cboDanhSachDichVu.SelectedIndex = 0;
        }

        private void LoadSanhAndCa()
        {
            try
            {
                DataTable result = BUS_NhanDatTiecCuoi.GetSanh();
                cboSanh.DataSource = result;
                cboSanh.ValueMember = result.Columns["MaSanh"].ToString();
                cboSanh.DisplayMember = result.Columns["TenSanh"].ToString();
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    lstGiaSanh.Add(Convert.ToDecimal(result.Rows[i][2].ToString()));
                }
                result = BUS_NhanDatTiecCuoi.GetCa();
                cboCa.DataSource = result;
                cboCa.ValueMember = result.Columns["MaCa"].ToString();
                cboCa.DisplayMember = result.Columns["TenCa"].ToString();
                //Set start selected index and value đơn giá bàn tối thiểu
                cboSanh.SelectedIndex = 0;
                cboSanh.SelectedItem = 0;
                lblGiaSanh.Text = lstGiaSanh[0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình load Combobox", "Lỗi");
            }
        }
        private void cboSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSanh.SelectedIndex;
            if (index < 0) return;
            lblGiaSanh.Text = lstGiaSanh[index].ToString();
        }
        #endregion

        #region load form 
        //load form 
        private void frmNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region event Nhập tiệc 
        private void txtSoLuongDichVuDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDonGiaYeuCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTenChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTenCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CheckStateToShow()
        {
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtTienDatCoc.Text == "" || cboCa.SelectedIndex < 0 || cboSanh.SelectedIndex < 0 || txtTienDatCoc.Text == "")
            {
                return false;
            }
            if (DateTime.Compare(dtpNgayDaiTiec.Value, dtpNgayDatTiec.Value) < 0 || DateTime.Compare(dtpNgayDaiTiec.Value, dtpNgayDatTiec.Value) == 0)
            {
                return false;
            }
            return true;
        }
        private void btnHuyTatCa_Click(object sender, EventArgs e)
        {
            SetupDefaultControlState();
            SetupFormSizeDefault(true);
            LoadSanhAndCa();
            IsCreateContract = IsCreateMenu = IsTakeWedding = false;
            lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
            lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
        }
        private void btnDatTiec_Click(object sender, EventArgs e)
        {
            //Check DTO TiecCuoi
            //Confirm infor 
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtTienDatCoc.Text == "" || cboCa.SelectedIndex < 0 || cboSanh.SelectedIndex < 0 || txtTienDatCoc.Text == "") 
            {
                ShowNotification(true);
                return;
            }
            if (DateTime.Compare(dtpNgayDaiTiec.Value, dtpNgayDatTiec.Value) < 0 || DateTime.Compare(dtpNgayDaiTiec.Value, dtpNgayDatTiec.Value) == 0)
            {
                MessageBox.Show("Ngày đãi tiệc phải sau ngày đặt tiệc ít nhất 1 ngày", "Thông báo");
                return;
            }
            //Add DTO
            dattieccuoi = new DTO_TiecCuoi();
            dattieccuoi.TenChuRe = txtTenChuRe.Text;
            dattieccuoi.TenCoDau = txtTenCoDau.Text;
            dattieccuoi.NgayDaiTiec = dtpNgayDaiTiec.Value.ToShortDateString();
            dattieccuoi.NgayDatTiec = dtpNgayDatTiec.Value.ToShortDateString();
            dattieccuoi.TienCoc = Convert.ToDecimal(txtTienDatCoc.Text);
            dattieccuoi.DienThoai = txtDienThoai.Text;
            dattieccuoi.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
            dattieccuoi.MaCa = cboCa.SelectedIndex;
            dattieccuoi.MaSanh = cboSanh.SelectedIndex;
            dattieccuoi.MaNV = 1; //Chưa thêm mã NV
            MessageBox.Show(dattieccuoi.TienCoc.ToString());
            //Kiểm tra thông tin phiếu;
        }
        #endregion

        #region Lập phiếu dịch vụ và món ăn
        private void btnPhieuDatBan_Click(object sender, EventArgs e)
        {
            if (CheckStateToShow())
            {
                this.Size = new Size(835, 570);
                this.MaximumSize = this.MinimumSize = new Size(835, 570);
                pnlPhieuDichVu.Visible = false;
            }
            else
            {
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                MessageBox.Show("Thông tin khách hàng phải được nhập đầy đủ trước", "Thông báo");
            }
        }

        private void btnPhieuDatDichVu_Click(object sender, EventArgs e)
        {
            if (CheckStateToShow())
            {
                this.Size = new Size(835, 570);
                this.MaximumSize = this.MinimumSize = new Size(835, 570);
                pnlPhieuDichVu.Visible = true;
            }
            else
            {
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                MessageBox.Show("Thông tin khách hàng phải được nhập đầy đủ trước", "Thông báo");
            }
        }
        #endregion

        private void cboDanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboDanhSachDichVu.SelectedIndex;
            if (index < 0) return;
            ptrDichVu.ImageLocation = @"DanhSachDichVu\" + dtDichVu.Rows[index][3].ToString();
            ptrDichVu.SizeMode = PictureBoxSizeMode.StretchImage;
            lblDonGiaDichVu.Text = dtDichVu.Rows[index][2].ToString() + " VNĐ";
            txtSoLuongDichVuDat.Text = "0";
            //Chưa load số lượng thực tế
        }

        private void btnChonDatDichVu_Click(object sender, EventArgs e)
        {
            DTO_CT_PhieuDatDichVu phieudichvu = new DTO_CT_PhieuDatDichVu();
            phieudichvu.MaDichVu = cboDanhSachDichVu.SelectedIndex;

        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyPhieuDichVu_Click(object sender, EventArgs e)
        {

        }

        private void lstDichVuTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {

        }

        private void btnLapPhieuDatBan_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyPhieuDatBan_Click(object sender, EventArgs e)
        {

        }

        private void lstDanhSachMonThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongDichVuDat_Click(object sender, EventArgs e)
        {
            txtSoLuongDichVuDat.Text = string.Empty;
        }
    }
}
