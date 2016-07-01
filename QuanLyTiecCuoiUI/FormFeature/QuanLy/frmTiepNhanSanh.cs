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
        public frmTiepNhanSanh()
        {
            InitializeComponent();
        }

        private void frmTiepNhanSanh_Load(object sender, EventArgs e)
        {
            txtTenSanh.Focus();

            // Load Loai Sanh vao ComboBox
            cbbLoaiSanh.DataSource = BUS_TiepNhanSanh.GetListMaLoaiSanh();
            // Load Don Gia Ban Toi Thieu vao Combobox 
            cbbDonGiaBanTT.DataSource = BUS_TiepNhanSanh.GetListDonGiaBanTT();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == "" || txtSoLuongBanTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ! (có thể không nhập phần Ghi Chú)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DTO_Sanh sanh = new DTO_Sanh(txtTenSanh.Text, cbbLoaiSanh.Text[0], int.Parse(txtSoLuongBanTD.Text), txtGhiChu.Text);
            BUS_TiepNhanSanh.InsertSanh(sanh);
            MessageBox.Show("Thêm sảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSoLuongBanTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
