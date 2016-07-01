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
    public partial class frmQuanLyTiecCuoi : Form
    {
        private List<string> mListCa = new List<string>();
        private List<string> mListSanh = new List<string>();

        private MODE mCurrentMode = MODE.NORMAL;
        private Size NORMAL_SIZE = new Size(900, 500);
        private Size EXTEND_SIZE = new Size(1200, 500);
        public frmQuanLyTiecCuoi()
        {
            InitializeComponent();
        }
        enum MODE
        {
            NORMAL,
            INSERT,
            EDIT
        }
        private void frmQuanLyTiecCuoi_Load(object sender, EventArgs e)
        {
            this.MaximumSize = NORMAL_SIZE;
            SetDisplayControls(MODE.NORMAL);
            dgvDanhSachTiecCuoi.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            //TenChuRe,TenCoDau,DienThoai,Ngay,TenCa,TenSanh,TienCoc,SoLuongBan,SoLuongBanDuTru,MaHD
            dgvDanhSachTiecCuoi.Columns["TenChuRe"].HeaderText = "Tên chú rể";
            dgvDanhSachTiecCuoi.Columns["TenCoDau"].HeaderText = "Tên cô dâu";
            dgvDanhSachTiecCuoi.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvDanhSachTiecCuoi.Columns["Ngay"].HeaderText = "Ngày đặt tiệc";
            dgvDanhSachTiecCuoi.Columns["TenCa"].HeaderText = "Ca";
            dgvDanhSachTiecCuoi.Columns["TenSanh"].HeaderText = "Sảnh";
            dgvDanhSachTiecCuoi.Columns["TienCoc"].HeaderText = "Tiền cọc";
            dgvDanhSachTiecCuoi.Columns["SoLuongBan"].HeaderText = "Số lượng bàn";
            dgvDanhSachTiecCuoi.Columns["SoLuongBanDuTru"].HeaderText = "Số lượng bàn dự trữ";
            dgvDanhSachTiecCuoi.Columns["MaHD"].Visible = false;
            mListCa = BUS_QuanLyTiecCuoi.GetListCa();
            cbbCa.DataSource = mListCa;
            mListSanh = BUS_QuanLyTiecCuoi.GetListSanh();
            cbbSanh.DataSource = mListSanh;
        }
        private void DisableAllInputs()
        {
            txtTenChuRe.Enabled = false;
            txtTenCoDau.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtNgayDatTiec.Enabled = false;
            txtSoLuongBan.Enabled = false;
            txtSoLuongBanDT.Enabled = false;
            txtTienDatCoc.Enabled = false;
            cbbCa.Enabled = false;
            cbbSanh.Enabled = false;
            btnChonKhach.Enabled = false;
            btnThemKhach.Enabled = false;
            btnThemDichVu.Enabled = false;
            btnThemMon.Enabled = false;
        }
        private void EnableAllInputs()
        {
            txtTenChuRe.Enabled = true;
            txtTenCoDau.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtNgayDatTiec.Enabled = true;
            txtSoLuongBan.Enabled = true;
            txtSoLuongBanDT.Enabled = true;
            txtTienDatCoc.Enabled = true;
            cbbCa.Enabled = true;
            cbbSanh.Enabled = true;
            btnChonKhach.Enabled = true;
            btnThemKhach.Enabled = true;
            btnThemDichVu.Enabled = true;
            btnThemMon.Enabled = true;
        }
        private void SetDisplayControls(MODE mode)
        {
            switch (mode)
            {
                case MODE.NORMAL:
                    {
                        DisableAllInputs();
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        break;
                    }
                case MODE.INSERT:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        btnChonKhach.Focus();
                        txtNgayDatTiec.Text = "dd/mm/yyyy";
                        break;
                    }
                case MODE.EDIT:
                    {
                        EnableAllInputs();
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        btnChonKhach.Enabled = false;
                        btnThemKhach.Enabled = false;
                        txtTenChuRe.Focus();
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.INSERT);
            mCurrentMode = MODE.INSERT;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.EDIT);
            mCurrentMode = MODE.EDIT;

            dgvDanhSachTiecCuoi.Focus();
            txtTenChuRe.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["TenChuRe"].Value.ToString();
            txtTenCoDau.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["TenCoDau"].Value.ToString();
            txtSoDienThoai.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtTienDatCoc.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["TienCoc"].Value.ToString();
            txtSoLuongBan.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["SoLuongBan"].Value.ToString();
            txtSoLuongBanDT.Text = dgvDanhSachTiecCuoi.CurrentRow.Cells["SoLuongBanDuTru"].Value.ToString();
            cbbCa.SelectedIndex = mListCa.IndexOf(dgvDanhSachTiecCuoi.CurrentRow.Cells["TenCa"].Value.ToString());
            cbbSanh.SelectedIndex = mListSanh.IndexOf(dgvDanhSachTiecCuoi.CurrentRow.Cells["TenSanh"].Value.ToString());
            LoadNgayDatTiec();
        }

        private void LoadNgayDatTiec()
        {
            string date = dgvDanhSachTiecCuoi.CurrentRow.Cells["Ngay"].Value.ToString();
            DateTime dt = DateTime.Parse(date);
            txtNgayDatTiec.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDanhSachTiecCuoi.Focus();
            string maHD = dgvDanhSachTiecCuoi.CurrentRow.Cells["MaHD"].Value.ToString();

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa tiệc cưới này không?", "Xóa tiệc cưới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            BUS_QuanLyTiecCuoi.DeleteTiecCuoi(maHD);
            dgvDanhSachTiecCuoi.DataSource = BUS_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi();
            MessageBox.Show("Xóa tiệc cưới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.NORMAL);
            ClearAllInputs();
        }

        private void ClearAllInputs()
        {
            txtTenChuRe.Text = txtTenCoDau.Text = txtSoDienThoai.Text = "";
            txtNgayDatTiec.Text = txtTienDatCoc.Text = txtSoLuongBan.Text = txtSoLuongBanDT.Text = "";

            if (cbbCa.Items.Count > 0 && cbbSanh.Items.Count > 0)
                cbbCa.SelectedIndex = cbbSanh.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (txtMaLoaiSanh.Text == "" || txtDonGiaBanTT.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //int temp;
            //if (!int.TryParse(txtDonGiaBanTT.Text, out temp))
            //{
            //    MessageBox.Show("'Số lượng bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDonGiaBanTT.Focus();
            //    txtDonGiaBanTT.SelectAll();
            //    return;
            //}

            //switch (mCurrentMode)
            //{
            //    case MODE.NORMAL:
            //        break;
            //    case MODE.INSERT:
            //        {
            //            DialogResult dr = MessageBox.Show("Bạn có muốn thêm loại sảnh mới này không?", "Thêm loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //            if (dr == DialogResult.No)
            //                return;
            //            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtMaLoaiSanh.Text[0], txtDonGiaBanTT.Text);
            //            if (BUS_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh))
            //            {
            //                dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            //                ClearAllInputs();
            //                MessageBox.Show("Thêm loại sảnh " + loaiSanh.maLoaiSanh + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                SetDisplayControls(MODE.NORMAL);
            //                mCurrentMode = MODE.NORMAL;
            //            }
            //            else
            //                MessageBox.Show("Loại sảnh " + loaiSanh.maLoaiSanh + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            break;
            //        }
            //    case MODE.EDIT:
            //        {
            //            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtMaLoaiSanh.Text[0], txtDonGiaBanTT.Text);
            //            BUS_QuanLyLoaiSanh.UpdateLoaiSanh(loaiSanh);
            //            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            //            ClearAllInputs();
            //            MessageBox.Show("Sửa loại sảnh " + loaiSanh.maLoaiSanh + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            SetDisplayControls(MODE.NORMAL);
            //            mCurrentMode = MODE.NORMAL;

            //            break;
            //        }
            //    default:
            //        break;
            //}
        }

        private void ShowThemMonDichVu(bool toggle)
        {
            btnThemMon.Enabled = !toggle;
            btnThemDichVu.Enabled = !toggle;
            btnLuu.Enabled = !toggle;
            btnHuy.Enabled = !toggle;
            if (toggle)
            {
                this.MinimumSize = EXTEND_SIZE;
            }
            else
            {
                this.MaximumSize = NORMAL_SIZE;
            }
        }
        private void LoadDataMonAnToListLuaChon(string maHD)
        {
            //lvDanhSachLuaChon.Items.Clear();
            List<string> listDaLuaChon = BUS_QuanLyTiecCuoi.GetListMonAn(maHD);
            foreach (string item in BUS_QuanLyTiecCuoi._listTenMonAn)
            {
                //lvDanhSachLuaChon.Items.Add(item).SubItems.Add("0");
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            ShowThemMonDichVu(true);
            grpThem.Text = "Thêm món";
            //lblLuaChon.Text = "Lựa chọn món";
            dgvDanhSachTiecCuoi.Focus();
            LoadDataMonAnToListLuaChon(dgvDanhSachTiecCuoi.CurrentRow.Cells["MaHD"].Value.ToString());
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ShowThemMonDichVu(true);
            grpThem.Text = "Thêm dịch vụ";
            //lblLuaChon.Text = "Lựa chọn dịch vụ";
        }

        private void btnLuuLuaChon_Click(object sender, EventArgs e)
        {
            ShowThemMonDichVu(false);
        }

        private void btnHuyLuaChon_Click(object sender, EventArgs e)
        {
            ShowThemMonDichVu(false);
        }
    }
}
