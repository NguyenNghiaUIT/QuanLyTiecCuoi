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
        private bool IsCreateService = false;
        private DTO_TiecCuoi dattieccuoi = new DTO_TiecCuoi();
        private List<DTO_CT_PhieuDatBan> lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
        private List<DTO_CT_PhieuDatDichVu> lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
        private List<Decimal> lstGiaSanh = new List<decimal>();
        private List<int> lstSoLuongBanToiDaSanh = new List<int>();
        private DataTable dtMonAn;
        private DataTable dtDichVu;
        private ImageList imgListDichVu = new ImageList();
        private ImageList imgListMonAn = new ImageList();
        private List<int> lstDichVuInsert = new List<int>();
        private List<int> lstMonAnInsert = new List<int>();
        private int SoLuongBanToiDa = 0;
        private decimal DonGiaBanThucTe = 0;
        private decimal TienDatCocToiThieu = 0;
        #endregion

        #region Constructor & load data
        private void ShowNotification(bool state)
        {
            NotCa.Visible = NotChuRe.Visible = NotCoDau.Visible = NotNgayDaiTiec.Visible = NotSanh.Visible = NotDienThoai.Visible = state;
            lblNotification.Visible = state;
        }
        private void SetupDefaultControlState()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtDienThoai.Text = string.Empty;
            txtGhiChuThongTinTiecCuoi.Text = txtTienDatCoc.Text = string.Empty;
            lblGiaSanh.Text = string.Empty;
            btnDatTiec.Enabled = false;
            dtpNgayDatTiec.Value = DateTime.Now;
            dtpNgayDaiTiec.Value = DateTime.Now.AddDays(1);
        }
        private void SetupStateControlTiecCuoi(bool state)
        {
            txtTenCoDau.ReadOnly = txtTenChuRe.ReadOnly = txtDienThoai.ReadOnly = txtTienDatCoc.ReadOnly = txtGhiChuThongTinTiecCuoi.ReadOnly = state;
            dtpNgayDatTiec.Enabled = dtpNgayDaiTiec.Enabled = cboCa.Enabled = cboSanh.Enabled = !state;
        }
        private void TienDatCocState(bool state)
        {
            txtTienDatCoc.ReadOnly = state;
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

            //Setup image list 
            SetupImageListDichVu();
            SetupImageListMonAn();
            ShowNotification(false);
            dtpNgayDatTiec.Enabled = false;
            //load tiền đặt cọc trạng thái 
            NotTienDatCoc.Visible = false;
            TienDatCocState(true);

        }
        private void LoadMonAn()
        {
            dtMonAn = new DataTable();
            dtMonAn = BUS_MonAn.GetDataTableMonAn();
            cboDanhSachMonAn.DataSource = dtMonAn;
            cboDanhSachMonAn.DisplayMember = dtMonAn.Columns["TenMonAn"].ToString();
            cboDanhSachMonAn.ValueMember = dtMonAn.Columns["MaMonAn"].ToString();
            try
            {
                cboDanhSachMonAn.SelectedIndex = 0;
            }
            catch(Exception ex)
            {

            }
        }
        private void LoadDichVu()
        {
            try
            {
                dtDichVu = new DataTable();
                dtDichVu = BUS_DichVuNhaHang.GetDataDichVu();
                cboDanhSachDichVu.DataSource = dtDichVu;
                cboDanhSachDichVu.DisplayMember = dtDichVu.Columns["TenDichVu"].ToString();
                cboDanhSachDichVu.ValueMember = dtDichVu.Columns["MaDichVu"].ToString();
                cboDanhSachDichVu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                
            }
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
                    lstSoLuongBanToiDaSanh.Add(Convert.ToInt32(result.Rows[i][3].ToString()));
                }
                result = BUS_NhanDatTiecCuoi.GetCa();
                cboCa.DataSource = result;
                cboCa.ValueMember = result.Columns["MaCa"].ToString();
                cboCa.DisplayMember = result.Columns["TenCa"].ToString();
                //Set start selected index and value đơn giá bàn tối thiểu
                try
                {
                    cboSanh.SelectedIndex = 0;
                    cboSanh.SelectedItem = 0;
                }
                catch(Exception ex)
                {

                }
                lblGiaSanh.Text = lstGiaSanh[0].ToString();
                txtSoLuongBan.Text = lstSoLuongBanToiDaSanh[0].ToString();
                SoLuongBanToiDa = lstSoLuongBanToiDaSanh[0];
                grpThongTinBanAn.Text = "Đặt số bàn ăn - tối đa: " + SoLuongBanToiDa.ToString() + " bàn";
            }
            catch (Exception ex)
            {
                
            }
        }
        private void cboSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSanh.SelectedIndex;
            if (index < 0) return;
            try
            {
                lblGiaSanh.Text = lstGiaSanh[index].ToString();
                SoLuongBanToiDa = lstSoLuongBanToiDaSanh[index];
                txtSoLuongBan.Text = lstSoLuongBanToiDaSanh[index].ToString();
                grpThongTinBanAn.Text = "Đặt số bàn ăn - tối đa: " + SoLuongBanToiDa.ToString() + " bàn";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return;
            }
        }
        #endregion

        #region load form 
        //load form 
        private void frmNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region event Nhập tiệc 

        private void txtTenChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtTenChuRe.Text[txtTenChuRe.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            //Ngăn ký tự bắt đầu
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            //Ngăn ký tự số
            if (char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
        private void txtTenCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ngăn double space
            try
            {
                if ((txtTenCoDau.Text[txtTenCoDau.Text.Length - 1] == ' ') && (e.KeyChar == (char)Keys.Space))
                    e.Handled = true;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chiều dài số điện thoại, quá 11 thì xóa
            if (txtDienThoai.Text.Length > 10)
            {
                e.KeyChar = (char)Keys.Back;
                return;
            }
                
            //first keys
            if ((sender as TextBox).SelectionStart == 0)
            {               
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar != (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            //check state not char
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTienDatCoc_Enter(object sender, EventArgs e)
        {
            if (txtTienDatCoc.Text == TienDatCocToiThieu.ToString())
                txtTienDatCoc.Text = string.Empty;
        }
        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool CheckDatTiecState()
        {
            if (IsCreateMenu && CheckStateToShow())
                return true;
            return false;
        }
        private bool CheckStateToShow()
        {
            if (txtDienThoai.Text.Length < 6) return false;
            if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || cboCa.SelectedIndex < 0 || cboSanh.SelectedIndex < 0 || txtDienThoai.Text == "") 
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
            try
            {
                SetupDefaultControlState();
                SetupFormSizeDefault(true);

                SetupStateControlTiecCuoi(false);
                dtpNgayDatTiec.Enabled = false;
                LoadSanhAndCa();
                IsCreateContract = IsCreateMenu = IsTakeWedding = false;
                lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
                lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
                imgListDichVu = new ImageList();
                imgListMonAn = new ImageList();
                lstDichVuTiecCuoi.Items.Clear();
                lstDanhSachMonThucDon.Items.Clear();

                //lstDanhSachMonThucDon = new ListView();
                //lstDichVuTiecCuoi = new ListView();

                btnPhieuDatDichVu.Enabled = true;
                btnPhieuDatBan.Enabled = true;
                IsCreateContract = IsCreateMenu = IsCreateService = IsTakeWedding = false;
                lstDichVuInsert = new List<int>();
                lstMonAnInsert = new List<int>();
                ShowNotification(false);
                this.Size = new Size(530, 570);
                TienDatCocToiThieu = 0;
                this.MaximumSize = this.MinimumSize = new Size(530, 570);

                txtTienDatCoc.ReadOnly = true;
                //trạng thái của panel dịch vụ và món ăn 

                //dịch vụ
                txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
                txtSoLuongDichVuDat.Text = "1";

                //món ăn
                txtSoLuongBan.Text = SoLuongBanToiDa.ToString();
                txtSoLuongBanDuTru.Text = "0";
                txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);
            }
            catch(Exception ex)
            {
                return;
            }
        }
        private bool CheckRightTienDatCoc(string money)
        {
            decimal d = Convert.ToDecimal(money);
            if (d % 500 != 0) return false;
            return true;
        }
        private void btnDatTiec_Click(object sender, EventArgs e)
        {
            //Kiểm tra tiền đặt cọc 
            if (txtTienDatCoc.Text == string.Empty)
                txtTienDatCoc.Text = TienDatCocToiThieu.ToString();
            if (!CheckRightTienDatCoc(txtTienDatCoc.Text))
            {
                MessageBox.Show("Tiền đặt cọc phải là bội số của 500 đồng", "Thông báo");
                return;
            }
            //Kiểm tra đã đặt hóa đơn chưa 
            if (!CheckDatTiecState())
            {
                MessageBox.Show("Bạn bắt buộc phải đặt thực đơn ", "Thông báo");
                return;
            }

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
            dattieccuoi.NgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
            dattieccuoi.NgayDatTiec = dtpNgayDatTiec.Value.ToString("MM/dd/yyyy");
            dattieccuoi.TienCoc = Convert.ToDecimal(txtTienDatCoc.Text);
            dattieccuoi.DienThoai = txtDienThoai.Text;
            dattieccuoi.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
            dattieccuoi.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
            dattieccuoi.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
            dattieccuoi.MaNV = 2; //Chưa thêm mã NV
            dattieccuoi.TinhTrangTiec = 1;

            //Kiểm tra thông tin phiếu;
            DTO_TiecCuoi tiec = new DTO_TiecCuoi();
            tiec.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
            tiec.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
            tiec.NgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
            DataTable re = BUS_NhanDatTiecCuoi.GetDate(tiec);
            if (re.Rows.Count > 0)  
            {
                MessageBox.Show("Chọn lại thời gian tổ chức tiệc: Ca, ngày đãi tiệc, vì thời gian đã bị trùng", "Thông báo");
                return;
            }
            //tính chi phí 1 bàn tiệc 
            decimal tongtien = 0;
            decimal sum = 0, sum1;
            sum1 = 0;
            foreach (var item in lstChiTietDatBan)
            {
                sum += item.DonGia;
            }
            sum1 = sum;
            sum = sum * Convert.ToInt32(txtSoLuongBan.Text);
            tongtien += sum;
            sum = 0;
            //tính chi phí của dịch vụ
            foreach (var item in lstChiTietDichVu)
            {
                sum += item.SoLuong * item.DonGia;
            }
            tongtien += sum;

            //Kiểm tra tiền cọc có >= 5%
            decimal minTiencoc = (decimal)(tongtien * 5) / 100;
            if (Convert.ToDecimal(txtTienDatCoc.Text) < minTiencoc)
            {
                MessageBox.Show("Tiền đặt cọc phải ít nhất bằng 5% tổng giá trị đặt tiệc - >=" + minTiencoc + " VNĐ");
                return;
            }
            //Thêm vào bảng tiệc cưới
            bool state = BUS_NhanDatTiecCuoi.InsertTiecCuoi(dattieccuoi);
            int matieccuoi = 0;
            if (state)
            {
                DataTable r = BUS_NhanDatTiecCuoi.GetLastID();
                DTO_PhieuDatBan phieudatban = new DTO_PhieuDatBan();
                phieudatban.MaTiecCuoi = Int32.Parse(r.Rows[0][0].ToString());
                matieccuoi = phieudatban.MaTiecCuoi;
                if (txtSoLuongBan.Text == "")
                    phieudatban.SoBan = SoLuongBanToiDa;
                else
                    phieudatban.SoBan = Int32.Parse(txtSoLuongBan.Text);
                if (txtSoLuongBanDuTru.Text == "")
                    phieudatban.SoBanDuTru = 0;
                else
                    phieudatban.SoBanDuTru = Int32.Parse(txtSoLuongBanDuTru.Text);
                phieudatban.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
                //tính đơn giá bàn
                
                phieudatban.DonGiaBan = sum1;
                bool statePhieu = BUS_NhanDatTiecCuoi.InsertPhieuDatBan(phieudatban);
                if (statePhieu)
                {
                    try
                    {
                        DataTable f = BUS_NhanDatTiecCuoi.GetLastIDPhieu();
                        int IDPhieuDatBan = Int32.Parse(f.Rows[0][0].ToString());
                        //Thêm phiếu đặt bàn 
                        foreach (var item in lstChiTietDatBan)
                        {
                            item.MaPhieuDatBan = IDPhieuDatBan;
                            BUS_NhanDatTiecCuoi.InsertChiTietDatBan(item);
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
                else
                    MessageBox.Show("Thêm phiếu đặt bàn ăn thất bại ", "Thông Báo");

                //Thêm phiếu đặt dịch vụ
                try
                {
                    foreach (var item in lstChiTietDichVu)
                    {
                        item.MaTiecCuoi = matieccuoi;
                        BUS_NhanDatTiecCuoi.InsertChiTietDatDichVu(item);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm phiếu đặt dịch vụ thất bại");
                }
                MessageBox.Show("Đặt tiệc cưới thành công ");

                try
                {
                    SetupDefaultControlState();
                    SetupFormSizeDefault(true);
                    LoadSanhAndCa();
                    IsCreateContract = IsCreateMenu = IsTakeWedding = false;
                    lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
                    lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
                    imgListDichVu = new ImageList();
                    imgListMonAn = new ImageList();
                    lstDichVuTiecCuoi.Items.Clear();
                    lstDanhSachMonThucDon.Items.Clear();

                    btnPhieuDatDichVu.Enabled = true;
                    btnPhieuDatBan.Enabled = true;
                    IsCreateContract = IsCreateMenu = IsCreateService = IsTakeWedding = false;
                    lstDichVuInsert.Clear();
                    lstMonAnInsert.Clear();
                    ShowNotification(false);

                    TienDatCocToiThieu = 0;
                    SetupStateControlTiecCuoi(false);
                    dtpNgayDatTiec.Enabled = false;
                    txtTienDatCoc.Text = string.Empty;
                    txtTienDatCoc.ReadOnly = true;

                    //dịch vụ
                    txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
                    txtSoLuongDichVuDat.Text = "1";

                    //món ăn
                    txtSoLuongBan.Text = SoLuongBanToiDa.ToString();
                    txtSoLuongBanDuTru.Text = "0";
                    txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);
                }
                catch (Exception ex)
                {

                }
            }
            else
                MessageBox.Show("Đặt tiệc cưới thất bại");
        }
        #endregion

        #region Trạng thái form dịch vụ và món ăn
        private void btnPhieuDatBan_Click(object sender, EventArgs e)
        {
            if (CheckStateToShow())
            {
                //Check infor tiệc cưới đã tồn tại hay chưa
                DTO_TiecCuoi tiec = new DTO_TiecCuoi();
                tiec.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
                tiec.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
                tiec.NgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
                DataTable re = BUS_NhanDatTiecCuoi.GetDate(tiec);
                if (re.Rows.Count > 0)
                {
                    MessageBox.Show("Chọn lại thời gian tổ chức tiệc: Ca, ngày đãi tiệc, vì thời gian đã bị trùng", "Thông báo");
                    return;
                }
                //Load new state cho phiếu đặt dịch vụ
                this.Size = new Size(835, 570);
                this.MaximumSize = this.MinimumSize = new Size(835, 570);
                
                SetupStateControlTiecCuoi(true);
                pnlPhieuDichVu.Visible = false;
                txtSoLuongBanDuTru.Text = "0";
                if (lstMonAnInsert != null) lstMonAnInsert.Clear();
                if (lstChiTietDatBan != null) lstChiTietDatBan.Clear();

                lblDonGiaDichVu.Text = dtDichVu.Rows[cboDanhSachDichVu.SelectedIndex][2].ToString() + " VNĐ";
                txtSoLuongDichVuDat.Text = "1";
                txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);

            }
            else
            {
                //trả về trạng thái ban đầu
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                ShowNotification(true);
                MessageBox.Show("Thông tin khách hàng - điện thoại liên lạc phải được nhập đầy đủ trước", "Thông báo");
            }
        }

        private void btnPhieuDatDichVu_Click(object sender, EventArgs e)
        {
            if (CheckStateToShow())
            {
                DTO_TiecCuoi tiec = new DTO_TiecCuoi();
                tiec.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
                tiec.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
                tiec.NgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
                DataTable re = BUS_NhanDatTiecCuoi.GetDate(tiec);
                if (re.Rows.Count > 0)
                {
                    MessageBox.Show("Chọn lại thời gian tổ chức tiệc: Ca, ngày đãi tiệc, vì thời gian đã bị trùng", "Thông báo");
                    return;
                }
                
                this.Size = new Size(835, 570);
                this.MaximumSize = this.MinimumSize = new Size(835, 570);
                SetupStateControlTiecCuoi(true);               
                pnlPhieuDichVu.Visible = true;
                lstDichVuInsert.Clear();
                lstChiTietDichVu.Clear();

                btnDatTiec.Enabled = false;
            }
            else
            {
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                ShowNotification(true);
                MessageBox.Show("Thông tin khách hàng - điện thoại liên lạc phải được nhập đầy đủ trước", "Thông báo");
            }
        }
        #endregion

        #region Lập phiếu đặt dịch vụ
        private void cboDanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboDanhSachDichVu.SelectedIndex;
                if (index < 0) return;
                ptrDichVu.ImageLocation = @"DanhSachDichVu\" + dtDichVu.Rows[index][3].ToString();
                ptrDichVu.SizeMode = PictureBoxSizeMode.StretchImage;
                lblDonGiaDichVu.Text = dtDichVu.Rows[index][2].ToString() + " VNĐ";
                txtSoLuongDichVuDat.Text = "1";
                txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
                toolTipInfor.SetToolTip(ptrDichVu, dtDichVu.Rows[index][4].ToString());
            }
            catch (Exception ex)
            {

            }
            //Chưa load số lượng thực tế sau khi người dùng nhập
        }
        private void txtDonGiaDatDichVu_Enter(object sender, EventArgs e)
        {
            if (txtDonGiaDatDichVu.Text == lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4))
                txtDonGiaDatDichVu.Text = string.Empty;
        }
        private void txtDonGiaDatDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((sender as TextBox).SelectionStart == 0)
            {
                txtDonGiaDatDichVu.Text = string.Empty;
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar == (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaDatDichVu_MouseLeave(object sender, EventArgs e)
        {
            if (txtDonGiaYeuCau.Text == "")
                txtDonGiaYeuCau.Text = dtDichVu.Rows[cboDanhSachDichVu.SelectedIndex][2].ToString();
        }
        private void txtSoLuongDichVuDat_Click(object sender, EventArgs e)
        {
            //không
        }
        private void txtSoLuongDichVuDat_Enter(object sender, EventArgs e)
        {
            if (txtSoLuongDichVuDat.Text == "1")
                txtSoLuongDichVuDat.Text = string.Empty;
        }
        private void txtSoLuongDichVuDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtSoLuongDichVuDat.Text == "1")
            //    txtSoLuongDichVuDat.Text = string.Empty;
            if ((sender as TextBox).SelectionStart == 0)
            {
                txtSoLuongDichVuDat.Text = string.Empty;
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar == (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoLuongDichVuDat_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoLuongDichVuDat.Text == "" || txtSoLuongDichVuDat.Text == "1")
                txtSoLuongDichVuDat.Text = "1";
        }
        private void SetupImageListDichVu()
        {
            lstDichVuTiecCuoi.View = View.Tile;
            lstDichVuTiecCuoi.TileSize = new Size(250, 90);

            //lstDichVuTiecCuoi.MouseUp += new MouseEventHandler(this.OnClickRightDichVu);
        }
        //private void OnClickRightDichVu(object sender, MouseEventArgs e)
        //{
        //    ListView lstView = sender as ListView;
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        ListViewItem item = lstView.GetItemAt(e.X, e.Y);
        //        if (item != null)
        //        {
        //            item.Selected = true;
        //            //Setup event list item
        //            ContextMenuStrip MenuAction = new ContextMenuStrip();
        //            ToolStripMenuItem XoaDichVu = new ToolStripMenuItem("Xóa dịch vụ");
        //            XoaDichVu.Click += new EventHandler(this.DichVu_OnClickRemove);
        //            MenuAction.Items.AddRange(new ToolStripItem[] { XoaDichVu });
        //            MenuAction.Show(Cursor.Position);
        //        }
        //    }
        //}
        //private void DichVu_OnClickRemove(object sender, EventArgs e)
        //{
        //    imgListDichVu.Images[lstDichVuInsert.Count - 2] = (Image)imgListDichVu.Images[lstDichVuInsert.Count - 2].Clone();
        //    lstDichVuInsert.RemoveAt(lstDichVuTiecCuoi.SelectedIndices[0]);
        //    imgListDichVu.Images.RemoveAt(lstDichVuTiecCuoi.SelectedIndices[0]);
        //    lstDichVuTiecCuoi.Items.RemoveAt(lstDichVuTiecCuoi.SelectedIndices[0]);
        //}
        private void InsertNewDichVu(DTO_DichVu dichvu)
        {
            //Hiển thị hình ảnh 
            try
            {
                imgListDichVu.Images.Add(dichvu.TenDichVu, Image.FromFile(@"DanhSachDichVu\" + dichvu.HinhAnh));
                imgListDichVu.ImageSize = new Size(80, 80);
                lstDichVuTiecCuoi.LargeImageList = imgListDichVu;
                lstDichVuTiecCuoi.Refresh();
            }
            catch (Exception ex)
            {

            }
            //Gán vào list
            try
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = lstDichVuTiecCuoi.Items.Count;
                item.Text = dichvu.TenDichVu + " - Thành tiền: " + Environment.NewLine + dichvu.DonGia;
                lstDichVuTiecCuoi.Items.Add(item);
                lstDichVuTiecCuoi.Refresh();
            }
            catch (Exception ex)
            {

            }      
        }

        private void btnChonDatDichVu_Click(object sender, EventArgs e)
        {
            //Kiểm tra đơn giá đặt dịch vụ có thêm chưa
            if (txtDonGiaDatDichVu.Text == string.Empty)
                txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);

            //Check tính đúng của tiệc 
            if (!CheckRightTienDatCoc(txtDonGiaDatDichVu.Text))
            {
                MessageBox.Show("Đơn giá đặt dịch vụ phải là bội số của 500 đồng", "Thông báo");
                return;
            }

            //Add chưa có mã tiệc cưới
            if (txtDonGiaDatDichVu.Text == string.Empty) 
                txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
            if (txtSoLuongDichVuDat.Text == "")
                txtSoLuongDichVuDat.Text = "1";
            int index = cboDanhSachDichVu.SelectedIndex;
            if (!lstDichVuInsert.Contains(Int32.Parse(dtDichVu.Rows[index][0].ToString())))
            {
                try
                {
                    DTO_CT_PhieuDatDichVu phieudichvu = new DTO_CT_PhieuDatDichVu();
                    phieudichvu.MaDichVu = Int32.Parse(dtDichVu.Rows[index][0].ToString());
                    //phieudichvu.MaTiecCuoi = ???
                    phieudichvu.SoLuong = Int32.Parse(txtSoLuongDichVuDat.Text);
                    phieudichvu.DonGia = Int32.Parse(txtDonGiaDatDichVu.Text);
                    lstChiTietDichVu.Add(phieudichvu);
                    DTO_DichVu dichvu = new DTO_DichVu();
                    dichvu.MaDichVu = Int32.Parse(dtDichVu.Rows[index][0].ToString());
                    dichvu.TenDichVu = dtDichVu.Rows[index][1].ToString();
                    dichvu.DonGia = phieudichvu.DonGia * phieudichvu.SoLuong;
                    dichvu.HinhAnh = dtDichVu.Rows[index][3].ToString();
                    lstDichVuInsert.Add(dichvu.MaDichVu);
                    InsertNewDichVu(dichvu);
                }
                catch (Exception ex)
                {

                }
            }
            else
                MessageBox.Show("Dịch vụ này đã được đặt ", "Thông báo");
        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {
            //Tính tổng tiền dịch vụ
            decimal sum = 0;
            foreach (var item in lstChiTietDichVu)
            {
                sum += item.SoLuong * item.DonGia;
            }

            if (lstChiTietDichVu.Count > 0)
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập phiếu đặt dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    this.Size = new Size(530, 570);
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    IsCreateService = true;
                    btnPhieuDatDichVu.Enabled = false;
                    SetupStateControlTiecCuoi(true);
                    btnDatTiec.Enabled = true;
                    txtTienDatCoc.ReadOnly = false;

                    //hiển thị tiền đặt cọc tối thiểu
                    decimal money = sum * 5 / 100;
                    TienDatCocToiThieu += money;
                    txtTienDatCoc.Text = TienDatCocToiThieu.ToString();
                    txtTienDatCoc.Focus();
                    MessageBox.Show("Lập phiếu đặt dịch vụ thành công", "Thông báo");
                }            
            }
            else
                MessageBox.Show("Đề nghị thêm dịch vụ trước khi tạo phiếu", "Thông báo");
        }

        private void btnHuyPhieuDichVu_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn hủy phiếu dịch vụ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    lstChiTietDichVu.Clear();
                    imgListDichVu.Images.Clear();
                    imgListDichVu = new ImageList();
                    lstDichVuTiecCuoi.Items.Clear();
                    //lstDichVuTiecCuoi = new ListView();
                    //lstDichVuInsert.Clear();
                    this.Size = new Size(530, 570);
                    btnDatTiec.Enabled = true;
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    SetupStateControlTiecCuoi(false);
                    txtTienDatCoc.ReadOnly = true;

                    //trạng thái của panel dịch vụ và món ăn 

                    //dịch vụ
                    txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
                    txtSoLuongDichVuDat.Text = "1";

                    //món ăn
                    txtSoLuongBan.Text = SoLuongBanToiDa.ToString();
                    txtSoLuongBanDuTru.Text = "0";
                    txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);

                    MessageBox.Show("Hủy thành công", "Thông báo");
                }
                catch(Exception ex)
                {
                    return;
                }
            }
        }

        private void lstDichVuTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region Lập phiếu đặt món ăn
        private void txtDonGiaYeuCau_Click(object sender, EventArgs e)
        {
            //txtDonGiaYeuCau.Text = string.Empty;
        }

        private void cboDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cboDanhSachMonAn.SelectedIndex;
                if (index < 0) return;
                ptrMonAn.ImageLocation = @"DanhSachMonAn\" + dtMonAn.Rows[index][3].ToString();
                ptrMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
                lblDonGiaMacDinh.Text = dtMonAn.Rows[index][2].ToString() + " VNĐ";
                txtDonGiaYeuCau.Text = dtMonAn.Rows[index][2].ToString();
                toolTipInfor.SetToolTip(ptrMonAn, dtMonAn.Rows[index][4].ToString());
            }
            catch(Exception ex)
            {

            }
            //Chưa load số lượng thực tế sau khi người dùng nhập
        }
        private void SetupImageListMonAn()
        {
            //lstDanhSachMonThucDon.View = View;
            //lstDanhSachMonThucDon.TileSize = new Size(250, 90);
        }
        private void InsertNewMonAn(DTO_MonAn monan)
        {
            //Hiển thị hình ảnh 
            try
            {
                imgListMonAn.Images.Add(monan.TenMonAn, Image.FromFile(@"DanhSachMonAn\" + monan.HinhAnh));
                imgListMonAn.ImageSize = new Size(80, 80);
                lstDanhSachMonThucDon.LargeImageList = imgListMonAn;
                lstDanhSachMonThucDon.Refresh();
            }
            catch (Exception ex)
            {

            }
            //Gán vào list
            try
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = lstDanhSachMonThucDon.Items.Count;
                item.Text = monan.TenMonAn + Environment.NewLine + " - Đơn giá: " + monan.DonGia;
                lstDanhSachMonThucDon.Items.Add(item);
                lstDanhSachMonThucDon.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            //kiểm tra box rỗng
            if (txtDonGiaYeuCau.Text == string.Empty)
            {
                txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);
            }
            //Check giá trị món ăn đặt 
            if (!CheckRightTienDatCoc(txtDonGiaYeuCau.Text))
            {
                MessageBox.Show("Đơn giá đặt món ăn phải là bội số của 500 đồng", "Thông báo");
                return;
            }
            if (txtSoLuongBan.Text == "")
            {
                MessageBox.Show("Số lượng bàn không được để trống", "Thông báo");
                return;
            }
            int index = cboDanhSachMonAn.SelectedIndex;
            if (!lstMonAnInsert.Contains(Int32.Parse(dtMonAn.Rows[index][0].ToString())))
            {
                DTO_CT_PhieuDatBan phieudatban = new DTO_CT_PhieuDatBan();
                //phieudatban.MaPhieuDatBan = ???
                //phieudichvu.MaTiecCuoi = ???
                try
                {
                    phieudatban.MaMonAn = Int32.Parse(dtMonAn.Rows[index][0].ToString());
                    if (txtDonGiaYeuCau.Text == string.Empty)
                    {
                        txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);
                        phieudatban.DonGia = Convert.ToDecimal(txtDonGiaYeuCau.Text);
                    }
                    else
                        phieudatban.DonGia = Convert.ToDecimal(txtDonGiaYeuCau.Text);
                    phieudatban.SoLuong = Int32.Parse(txtSoLuongBan.Text);
                    lstChiTietDatBan.Add(phieudatban);
                    //add danh sách món ăn đã chọn
                    DTO_MonAn monan = new DTO_MonAn();
                    monan.MaMonAn = Int32.Parse(dtMonAn.Rows[index][0].ToString());
                    monan.TenMonAn = dtMonAn.Rows[index][1].ToString();
                    monan.DonGia = phieudatban.DonGia;
                    monan.HinhAnh = dtMonAn.Rows[index][3].ToString();
                    lstMonAnInsert.Add(monan.MaMonAn);
                    InsertNewMonAn(monan);
                }
                catch(Exception ex)
                {
                    return;
                }
            }
            else
                MessageBox.Show("Món ăn này đã được đặt ", "Thông báo");
        }

        private void btnLapPhieuDatBan_Click(object sender, EventArgs e)
        {
            //state default
            if (txtSoLuongBan.Text =="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng bàn và số lượng bàn dự trữ đầy đủ", "Thông báo");
                return;
            }
            //state của số bàn và số bàn dự trữ lớn hơn số lượng dự kiến
            int soban, sobandutru;
            try
            {
                soban = Int32.Parse(txtSoLuongBan.Text);
                sobandutru = Int32.Parse(txtSoLuongBanDuTru.Text);
            }
            catch(Exception ex)
            {
                soban = SoLuongBanToiDa;
                sobandutru = 0;
            }
            

            //Check số bàn đặt thực tế
            if (soban > SoLuongBanToiDa)
            {
                MessageBox.Show("Số lượng bàn đặt thực tế và dự trữ phải nhỏ hơn số lượng bàn tối đa của sảnh (" + SoLuongBanToiDa.ToString() + ")", "Thông báo");
                return;
            }
            //Check số bàn dự trữ
            if (soban + sobandutru > SoLuongBanToiDa)
            {
                MessageBox.Show("Số lượng bàn đặt thực tế và dự trữ phải nhỏ hơn số lượng bàn tối đa của sảnh (" + SoLuongBanToiDa.ToString() + ")", "Thông báo");
                return;
            }
            //Check đơn giá bàn
            decimal sum = 0;
            foreach (var item in lstChiTietDatBan)
            {
                sum += item.DonGia;
            }
            DonGiaBanThucTe = sum;
            if (lstChiTietDatBan.Count > 0)
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập phiếu đặt bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (sum < Convert.ToDecimal(lblGiaSanh.Text))
                    {
                        MessageBox.Show("Đơn giá bàn thấp hơn đơn giá bàn tối thiểu của sảnh là : " + lblGiaSanh.Text);
                        return;
                    }
                    this.Size = new Size(530, 570);
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    IsCreateMenu = true;
                    btnPhieuDatBan.Enabled = false;
                    //SetupStateControlTiecCuoi(false);

                    //cho người dùng đặt cọc
                    txtTienDatCoc.ReadOnly = false;
                    txtTienDatCoc.Text = string.Empty;
                    txtTienDatCoc.Focus();

                    btnDatTiec.Enabled = true;

                    sum = sum * soban;
                    //Hiển thị tiền cọc tối thiểu
                    decimal money = sum * 5 / 100;
                    TienDatCocToiThieu += money;
                    txtTienDatCoc.Text = TienDatCocToiThieu.ToString();

                    MessageBox.Show("Lập phiếu đặt bàn thành công", "Thông báo");
                }
            }
            else
                MessageBox.Show("Đề nghị thêm món ăn trước khi tạo phiếu", "Thông báo");
        }

        private void btnHuyPhieuDatBan_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn hủy phiếu đặt bàn? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    lstChiTietDatBan.Clear();
                    imgListMonAn.Images.Clear();
                    imgListMonAn = new ImageList();
                    lstDanhSachMonThucDon.Items.Clear();
                    this.Size = new Size(530, 570);
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    txtSoLuongBan.Text = SoLuongBanToiDa.ToString();
                    txtTienDatCoc.Text = string.Empty;
                    txtTienDatCoc.ReadOnly = true;
                    SetupStateControlTiecCuoi(false);

                    //trạng thái form ban đầu
                    txtTienDatCoc.ReadOnly = true;
                    dtpNgayDatTiec.Enabled = false;
                    lstChiTietDichVu.Clear();
                    //imgListDichVu.Images.Clear();
                    //imgListDichVu = new ImageList();
                    //lstDichVuTiecCuoi = new ListView();
                    //lstDichVuInsert.Clear();
                    this.Size = new Size(530, 570);
                    btnDatTiec.Enabled = true;
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    SetupStateControlTiecCuoi(false);
                    txtTienDatCoc.ReadOnly = true;
                    dtpNgayDatTiec.Enabled = false;
                    //trạng thái của panel dịch vụ và món ăn 

                    //dịch vụ
                    txtDonGiaDatDichVu.Text = lblDonGiaDichVu.Text.Substring(0, lblDonGiaDichVu.Text.Length - 4);
                    txtSoLuongDichVuDat.Text = "1";

                    //món ăn
                    txtSoLuongBan.Text = SoLuongBanToiDa.ToString();
                    txtSoLuongBanDuTru.Text = "0";
                    txtDonGiaYeuCau.Text = lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4);

                    MessageBox.Show("Hủy thành công", "Thông báo");
                }
                catch(Exception ex)
                {
                    return;
                }
            }
        }

        private void lstDanhSachMonThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGiaYeuCau_Enter(object sender, EventArgs e)
        {
            if (txtDonGiaYeuCau.Text == lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4))
                txtDonGiaYeuCau.Text = string.Empty;
        }
        private void txtDonGiaYeuCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtDonGiaYeuCau.Text == lblDonGiaMacDinh.Text.Substring(0, lblDonGiaMacDinh.Text.Length - 4))
            //    txtDonGiaYeuCau.Text = string.Empty;
            if ((sender as TextBox).SelectionStart == 0)
            {
                txtDonGiaYeuCau.Text = string.Empty;
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar == (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDonGiaYeuCau_MouseLeave(object sender, EventArgs e)
        {
            if (txtDonGiaYeuCau.Text == "" || txtDonGiaYeuCau.Text == dtMonAn.Rows[cboDanhSachMonAn.SelectedIndex][2].ToString())
                txtDonGiaYeuCau.Text = dtMonAn.Rows[cboDanhSachMonAn.SelectedIndex][2].ToString();
        }
        private void txtSoLuongBan_MouseLeave(object sender, EventArgs e)
        {
            //không sử dụng
            //if (txtSoLuongBan.Text == "" || (Convert.ToInt32(txtSoLuongBan.Text) > SoLuongBanToiDa)) 
            //    txtSoLuongBan.Text = SoLuongBanToiDa.ToString(); 
        }
        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoLuongBan.Text == SoLuongBanToiDa.ToString())
                txtSoLuongBan.Text = string.Empty;
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar == (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoLuongBanDuTru_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSoLuongBanDuTru.Text == "")
            //    txtSoLuongBanDuTru.Text = "0";
        }
        private void txtSoLuongBanDuTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSoLuongBanDuTru.Text == "0")
                txtSoLuongBanDuTru.Text = string.Empty;
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                //first key = 0
                if (e.KeyChar == (char)Keys.D0)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoLuongBan_Click(object sender, EventArgs e)
        {
            //Không sử dụng
        }

        private void txtSoLuongBanDuTru_Click(object sender, EventArgs e)
        {
            //Không sử dụng
        }

        #endregion

        #region Tra cứu bảng tiệc cưới
        private void btnDanhSachTiecCuoi_Click(object sender, EventArgs e)
        {

        }


        #endregion

    }
}
