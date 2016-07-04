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
        private DataTable dtMonAn;
        private DataTable dtDichVu;
        private ImageList imgListDichVu = new ImageList();
        private ImageList imgListMonAn = new ImageList();
        private List<int> lstDichVuInsert = new List<int>();
        private List<int> lstMonAnInsert = new List<int>();
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
            btnDatTiec.Enabled = false;
            dtpNgayDatTiec.Value = DateTime.Now;
            dtpNgayDaiTiec.Value = DateTime.Now.AddDays(1);
        }
        private void SetupStateControlTiecCuoi(bool state)
        {
            txtTenCoDau.ReadOnly = txtTenChuRe.ReadOnly = txtDienThoai.ReadOnly = txtTienDatCoc.ReadOnly = txtGhiChuThongTinTiecCuoi.ReadOnly = state;
            dtpNgayDatTiec.Enabled = dtpNgayDaiTiec.Enabled = cboCa.Enabled = cboSanh.Enabled = !state;
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
            }
            catch(Exception ex)
            {
                
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
            imgListDichVu = null;
            imgListMonAn = null;
            lstDichVuTiecCuoi.Clear();
            lstDanhSachMonThucDon.Clear();
            btnPhieuDatDichVu.Enabled = true;
            btnPhieuDatBan.Enabled = true;
            IsCreateContract = IsCreateMenu = IsCreateService = IsTakeWedding = false;
            lstDichVuInsert.Clear();
            lstMonAnInsert.Clear();
            ShowNotification(false);
        }
        private void btnDatTiec_Click(object sender, EventArgs e)
        {
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
            dattieccuoi.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
            dattieccuoi.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
            dattieccuoi.MaNV = 2; //Chưa thêm mã NV
            
            //Kiểm tra thông tin phiếu;
            DTO_TiecCuoi tiec = new DTO_TiecCuoi();
            tiec.MaCa = Convert.ToInt32(cboCa.SelectedValue.ToString());
            tiec.MaSanh = Convert.ToInt32(cboSanh.SelectedValue.ToString());
            MessageBox.Show(dattieccuoi.MaSanh.ToString());
            tiec.NgayDaiTiec = dtpNgayDaiTiec.Value.ToString("MM/dd/yyyy");
            DataTable re = BUS_NhanDatTiecCuoi.GetDate(tiec);
            if (re.Rows.Count > 0)  
            {
                MessageBox.Show("Chọn lại thời gian tổ chức tiệc: Ca, ngày đãi tiệc, vì thời gian đã bị trùng", "Thông báo");
                return;
            }

            //Thêm vào bảng tiệc cưới
            bool state = BUS_NhanDatTiecCuoi.InsertTiecCuoi(dattieccuoi);
            if (state)
            {
                DataTable r = BUS_NhanDatTiecCuoi.GetLastID();
                DTO_PhieuDatBan phieudatban = new DTO_PhieuDatBan();
                phieudatban.MaTiecCuoi = Int32.Parse(r.Rows[0][0].ToString());
                phieudatban.SoBan = Int32.Parse(txtSoLuongBan.Text);
                phieudatban.SoBanDuTru = Int32.Parse(txtSoLuongBanDuTru.Text);
                phieudatban.GhiChu = txtGhiChuThongTinTiecCuoi.Text;
                //tính đơn giá bàn
                decimal sum = 0;
                foreach (var item in lstChiTietDatBan)
                {
                    sum += item.DonGia;
                }
                phieudatban.DonGiaBan = sum;
                bool statePhieu = BUS_NhanDatTiecCuoi.InsertPhieuDatBan(phieudatban);
                if (statePhieu)
                {
                    DataTable f = BUS_NhanDatTiecCuoi.GetLastIDPhieu();
                    int IDPhieuDatBan = Int32.Parse(f.Rows[0][0].ToString());
                    foreach (var item in lstChiTietDatBan)
                    {
                        item.MaPhieuDatBan = IDPhieuDatBan;
                        BUS_NhanDatTiecCuoi.InsertChiTietDatBan(item);
                    }
                }
                else
                    MessageBox.Show("Thêm phiếu đặt bàn ăn thất bại ", "Thông Báo");
                MessageBox.Show("Đặt tiệc cưới thành công ");

                SetupDefaultControlState();
                SetupFormSizeDefault(true);
                LoadSanhAndCa();
                IsCreateContract = IsCreateMenu = IsTakeWedding = false;
                lstChiTietDatBan = new List<DTO_CT_PhieuDatBan>();
                lstChiTietDichVu = new List<DTO_CT_PhieuDatDichVu>();
                imgListDichVu = null;
                imgListMonAn = null;
                lstDichVuTiecCuoi.Clear();
                lstDanhSachMonThucDon.Clear();
                btnPhieuDatDichVu.Enabled = true;
                btnPhieuDatBan.Enabled = true;
                IsCreateContract = IsCreateMenu = IsCreateService = IsTakeWedding = false;
                lstDichVuInsert.Clear();
                lstMonAnInsert.Clear();
                ShowNotification(false);
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
                pnlPhieuDichVu.Visible = false;
                txtSoLuongBan.Text = txtSoLuongBanDuTru.Text = "0";
                lstMonAnInsert.Clear();
                lstChiTietDatBan.Clear();
            }
            else
            {
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                ShowNotification(true);
                MessageBox.Show("Thông tin khách hàng phải được nhập đầy đủ trước", "Thông báo");
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
            }
            else
            {
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                ShowNotification(true);
                MessageBox.Show("Thông tin khách hàng phải được nhập đầy đủ trước", "Thông báo");
            }
        }
        #endregion

        #region Lập phiếu đặt dịch vụ
        private void cboDanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboDanhSachDichVu.SelectedIndex;
            if (index < 0) return;
            ptrDichVu.ImageLocation = @"DanhSachDichVu\" + dtDichVu.Rows[index][3].ToString();
            ptrDichVu.SizeMode = PictureBoxSizeMode.StretchImage;
            lblDonGiaDichVu.Text = dtDichVu.Rows[index][2].ToString() + " VNĐ";
            txtSoLuongDichVuDat.Text = "1";
            toolTipInfor.SetToolTip(ptrDichVu, dtDichVu.Rows[index][4].ToString());
            //Chưa load số lượng thực tế sau khi người dùng nhập
        }
        private void txtSoLuongDichVuDat_Click(object sender, EventArgs e)
        {
            if (txtSoLuongDichVuDat.Text == "1") 
                txtSoLuongDichVuDat.Text = string.Empty;
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
                item.Text = dichvu.TenDichVu + " - Đơn giá: " + Environment.NewLine + dichvu.DonGia;
                lstDichVuTiecCuoi.Items.Add(item);
                lstDichVuTiecCuoi.Refresh();
            }
            catch (Exception ex)
            {

            }      
        }

        private void btnChonDatDichVu_Click(object sender, EventArgs e)
        {
            //Add chưa có mã tiệc cưới
            int index = cboDanhSachDichVu.SelectedIndex;
            if (!lstDichVuInsert.Contains(Int32.Parse(dtDichVu.Rows[index][0].ToString())))
            {
                DTO_CT_PhieuDatDichVu phieudichvu = new DTO_CT_PhieuDatDichVu();
                phieudichvu.MaDichVu = Int32.Parse(dtDichVu.Rows[index][0].ToString());
                //phieudichvu.MaTiecCuoi = ???
                phieudichvu.SoLuong = Int32.Parse(txtSoLuongDichVuDat.Text);
                phieudichvu.DonGia = phieudichvu.SoLuong * Int32.Parse(dtDichVu.Rows[index][2].ToString());
                lstChiTietDichVu.Add(phieudichvu);
                DTO_DichVu dichvu = new DTO_DichVu();
                dichvu.MaDichVu = Int32.Parse(dtDichVu.Rows[index][0].ToString());
                dichvu.TenDichVu = dtDichVu.Rows[index][1].ToString();
                dichvu.DonGia = phieudichvu.DonGia;
                dichvu.HinhAnh = dtDichVu.Rows[index][3].ToString();
                lstDichVuInsert.Add(dichvu.MaDichVu);
                InsertNewDichVu(dichvu);
            }
            else
                MessageBox.Show("Dịch vụ này đã được đặt ", "Thông báo");
        }

        private void btnLapPhieuDichVu_Click(object sender, EventArgs e)
        {
            if (lstChiTietDichVu.Count > 0)
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập phiếu đặt dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    this.Size = new Size(530, 570);
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    IsCreateService = true;
                    btnPhieuDatDichVu.Enabled = false;
                    SetupStateControlTiecCuoi(false);
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
                lstChiTietDichVu.Clear();
                imgListDichVu.Images.Clear();
                lstDichVuTiecCuoi.Clear();
                //lstDichVuInsert.Clear();
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                SetupStateControlTiecCuoi(false);
                MessageBox.Show("Hủy thành công", "Thông báo");
            }
        }

        private void lstDichVuTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongDichVuDat_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoLuongDichVuDat.Text == "" || txtSoLuongDichVuDat.Text == "1")
                txtSoLuongDichVuDat.Text = "1";
        }
        #endregion

        #region Lập phiếu đặt món ăn
        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBanDuTru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDonGiaYeuCau_Click(object sender, EventArgs e)
        {
            txtDonGiaYeuCau.Text = string.Empty;
        }

        private void cboDanhSachMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboDanhSachMonAn.SelectedIndex;
            if (index < 0) return;
            ptrMonAn.ImageLocation = @"DanhSachMonAn\" + dtMonAn.Rows[index][3].ToString();
            ptrMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            lblDonGiaMacDinh.Text = dtMonAn.Rows[index][2].ToString() + " VNĐ";
            txtDonGiaYeuCau.Text = dtMonAn.Rows[index][2].ToString();
            toolTipInfor.SetToolTip(ptrMonAn, dtMonAn.Rows[index][4].ToString());
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
                phieudatban.MaMonAn = Int32.Parse(dtMonAn.Rows[index][0].ToString());
                phieudatban.DonGia = Int32.Parse(txtDonGiaYeuCau.Text);
                phieudatban.SoLuong = Int32.Parse(txtSoLuongBan.Text);
                lstChiTietDatBan.Add(phieudatban);
                DTO_MonAn monan = new DTO_MonAn();
                monan.MaMonAn= Int32.Parse(dtMonAn.Rows[index][0].ToString());
                monan.TenMonAn = dtMonAn.Rows[index][1].ToString();
                monan.DonGia = phieudatban.DonGia;
                monan.HinhAnh = dtMonAn.Rows[index][3].ToString();
                lstMonAnInsert.Add(monan.MaMonAn);
                InsertNewMonAn(monan);
            }
            else
                MessageBox.Show("Món ăn này đã được đặt ", "Thông báo");
        }

        private void btnLapPhieuDatBan_Click(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text =="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng bàn và số lượng bàn dự trữ đầy đủ", "Thông báo");
                return;
            }

            //Check đơn giá bàn
            decimal sum = 0;
            foreach (var item in lstChiTietDatBan)
            {
                sum += item.DonGia;
            }

            if (lstChiTietDatBan.Count > 0)
            {
                DialogResult r = MessageBox.Show("Bạn muốn lập phiếu đặt bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (sum < Convert.ToDecimal(lblGiaSanh.Text))
                    {
                        MessageBox.Show("Đơn giá bàn thấp hơn đơn giá bàn tối thiểu của sảnh " + cboSanh.DisplayMember + " là : " + lblGiaSanh.Text);
                        return;
                    }
                    this.Size = new Size(530, 570);
                    this.MaximumSize = this.MinimumSize = new Size(530, 570);
                    IsCreateMenu = true;
                    btnPhieuDatBan.Enabled = false;
                    SetupStateControlTiecCuoi(false);
                    btnDatTiec.Enabled = btnXuatHopDong.Enabled = true;
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
                lstChiTietDatBan.Clear();
                imgListMonAn.Images.Clear();
                lstDanhSachMonThucDon.Clear();
                this.Size = new Size(530, 570);
                this.MaximumSize = this.MinimumSize = new Size(530, 570);
                SetupStateControlTiecCuoi(false);
                MessageBox.Show("Hủy thành công", "Thông báo");
            }
        }

        private void lstDanhSachMonThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGiaYeuCau_MouseLeave(object sender, EventArgs e)
        {
            if (txtDonGiaYeuCau.Text == "" || txtDonGiaYeuCau.Text == dtMonAn.Rows[cboDanhSachMonAn.SelectedIndex][2].ToString())
                txtDonGiaYeuCau.Text = dtMonAn.Rows[cboDanhSachMonAn.SelectedIndex][2].ToString();
        }
        private void txtSoLuongBan_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text == "")
                txtSoLuongBan.Text = "0"; 
        }

        private void txtSoLuongBanDuTru_MouseLeave(object sender, EventArgs e)
        {
            if (txtSoLuongBanDuTru.Text == "")
                txtSoLuongBanDuTru.Text = "0";
        }
        private void txtSoLuongBan_Click(object sender, EventArgs e)
        {
            txtSoLuongBan.Text = string.Empty;
        }

        private void txtSoLuongBanDuTru_Click(object sender, EventArgs e)
        {
            txtSoLuongBanDuTru.Text = string.Empty;
        }

        #endregion

        #region Lập hợp đồng 
        private void btnXuatHopDong_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
