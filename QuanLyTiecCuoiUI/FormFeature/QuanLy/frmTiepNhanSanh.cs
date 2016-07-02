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
    public partial class frmTiepNhanSanh : Form
    {
        private const int MaxSoLuongBanTD = 300;
        public frmTiepNhanSanh()
        {
            InitializeComponent();
        }

        private void frmTiepNhanSanh_Load(object sender, EventArgs e)
        {
            BUS_TiepNhanSanh.Init();
            myTooltip.SetToolTip(txtSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSoLuongBanTD);
            myTooltip.SetToolTip(lblSoLuongBanTD, "Số lượng bàn tối đa từ 1 đến " + MaxSoLuongBanTD);
            txtTenSanh.Focus();

            // Load Loai Sanh vao ComboBox
            cbbLoaiSanh.DataSource = BUS_TiepNhanSanh.GetListTenLoaiSanh();
            // Load Don Gia Ban Toi Thieu vao Combobox 
            cbbDonGiaBanTT.DataSource = BUS_TiepNhanSanh.GetListDonGiaBanTT();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text != "" || txtSoLuongBanTD.Text != "")
            {
                DialogResult dr = MessageBox.Show("Dữ liệu sẽ không được lưu, bạn có muốn hủy không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    btnLuu.Focus();
                    return;
                }
            }
            this.Close();
        }

        private void cbbLoaiSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDonGiaBanTT.Items.Count > 0)
                cbbDonGiaBanTT.SelectedIndex = cbbLoaiSanh.SelectedIndex;
        }

        private void cbbDonGiaBanTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSanh.Items.Count > 0)
                cbbLoaiSanh.SelectedIndex = cbbDonGiaBanTT.SelectedIndex;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == "" || txtSoLuongBanTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSanh.Focus();
                return;
            }
            int temp;
            if (!int.TryParse(txtSoLuongBanTD.Text, out temp))
            {
                MessageBox.Show("'Số lượng bàn tối đa' phải là số nguyên, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongBanTD.Focus();
                txtSoLuongBanTD.SelectAll();
                return;
            }
            if (BUS_TiepNhanSanh.TenSanhIsExistInSanh(txtTenSanh.Text))
            {
                MessageBox.Show("Sảnh '" + txtTenSanh.Text +"' đã tồn tại, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSanh.Focus();
                txtTenSanh.SelectAll();
                return;
            }
            int maloaiSanh = int.Parse(BUS_TiepNhanSanh.GetListMaLoaiSanh()[cbbLoaiSanh.SelectedIndex]);
            DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, maloaiSanh, int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
            BUS_TiepNhanSanh.InsertSanh(sanh);
            MessageBox.Show("Thêm sảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTenSanh.Focus();
        }

        private void txtSoLuongBanTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmTiepNhanSanh_Shown(object sender, EventArgs e)
        {
            if (BUS_TiepNhanSanh.mIsLoaiSanhDataEmpty)
            {
                MessageBox.Show("Không có dữ liệu Loại Sảnh nào, vui lòng thêm vào để sử dụng chức năng này!\n\nĐể thêm, truy cập: QUY ĐỊNH > Quản lý loại sảnh", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void txtTenSanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == " ")
                txtTenSanh.Text = "";
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == " ")
                txtGhiChu.Text = "";
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtGhiChu.SelectAll();
            }
        }

        private void txtSoLuongBanTD_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBanTD.Text == "0")
            {
                txtSoLuongBanTD.Text = "";
                return;
            }
            if (txtSoLuongBanTD.Text != "" && int.Parse(txtSoLuongBanTD.Text) > MaxSoLuongBanTD)
            {
                txtSoLuongBanTD.Text = MaxSoLuongBanTD.ToString();
                txtSoLuongBanTD.SelectionStart = txtSoLuongBanTD.Text.Length;
            }
        }
    }
}
