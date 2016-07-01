using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI
{
    public partial class frmQuanLyLoaiSanh : Form
    {
        private MODE mCurrentMode = MODE.NORMAL;
        public frmQuanLyLoaiSanh()
        {
            InitializeComponent();
        }
        enum MODE
        {
            NORMAL,
            INSERT,
            EDIT
        }
        private void frmQuanLyLoaiSanh_Load(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.NORMAL);
            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            dgvQuanLyLoaiSanh.Columns["MaLoaiSanh"].HeaderText = "Mã loại sảnh";
            dgvQuanLyLoaiSanh.Columns["DonGiaBanToiThieu"].HeaderText = "Đơn giá bàn tối thiểu";
            
        }
        private void DisableAllInputs()
        {
            txtMaLoaiSanh.Enabled = false;
            txtDonGiaBanTT.Enabled = false;
        }
        private void EnableAllInputs()
        {
            txtMaLoaiSanh.Enabled = true;
            txtDonGiaBanTT.Enabled = true;
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
                        txtMaLoaiSanh.Focus();
                        break;
                    }
                case MODE.EDIT:
                    {
                        EnableAllInputs();
                        txtMaLoaiSanh.Enabled = false;
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
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

            dgvQuanLyLoaiSanh.Focus();
            txtMaLoaiSanh.Text = dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString();
            txtDonGiaBanTT.Text = dgvQuanLyLoaiSanh.CurrentRow.Cells["DonGiaBanToiThieu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvQuanLyLoaiSanh.Focus();
            DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh();
            loaiSanh.maLoaiSanh = dgvQuanLyLoaiSanh.CurrentRow.Cells["MaLoaiSanh"].Value.ToString()[0];

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa loại sảnh '" + loaiSanh.maLoaiSanh + "' không?", "Xóa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
                return;
            if (BUS_QuanLyLoaiSanh.DeleteLoaiSanh(loaiSanh))
            {
                dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                MessageBox.Show("Xóa loại sảnh " + loaiSanh.maLoaiSanh + " thành công!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(string.Format("Lỗi, loại sảnh '{0}' là khóa ngoại đang tồn tại trong bảng 'Sảnh'.\n\nVui lòng xóa các loại sảnh '{1}' trong bảng 'Sảnh' trước.",
                    loaiSanh.maLoaiSanh, loaiSanh.maLoaiSanh),
                    "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetDisplayControls(MODE.NORMAL);
            ClearAllInputs();
        }

        private void ClearAllInputs()
        {
            txtMaLoaiSanh.Text = "";
            txtDonGiaBanTT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSanh.Text == "" || txtDonGiaBanTT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp;
            if (!int.TryParse(txtDonGiaBanTT.Text, out temp))
            {
                MessageBox.Show("'Số lượng bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBanTT.Focus();
                txtDonGiaBanTT.SelectAll();
                return;
            }

            switch (mCurrentMode)
            {
                case MODE.NORMAL:
                    break;
                case MODE.INSERT:
                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn thêm loại sảnh mới này không?", "Thêm loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                            return;
                        DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtMaLoaiSanh.Text[0], txtDonGiaBanTT.Text);
                        if (BUS_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh))
                        {
                            dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                            ClearAllInputs();
                            MessageBox.Show("Thêm loại sảnh " + loaiSanh.maLoaiSanh + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetDisplayControls(MODE.NORMAL);
                            mCurrentMode = MODE.NORMAL;
                        }
                        else
                            MessageBox.Show("Loại sảnh " + loaiSanh.maLoaiSanh + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    }
                case MODE.EDIT:
                    {
                        DTO_LoaiSanh loaiSanh = new DTO_LoaiSanh(txtMaLoaiSanh.Text[0], txtDonGiaBanTT.Text);
                        BUS_QuanLyLoaiSanh.UpdateLoaiSanh(loaiSanh);
                        dgvQuanLyLoaiSanh.DataSource = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
                        ClearAllInputs();
                        MessageBox.Show("Sửa loại sảnh " + loaiSanh.maLoaiSanh + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetDisplayControls(MODE.NORMAL);
                        mCurrentMode = MODE.NORMAL;

                        break;
                    }
                default:
                    break;
            }
        }

        private void txtDonGiaBanTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
