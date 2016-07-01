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
    public partial class frmQuanLyMonAn : Form
    {
        private DTO_MonAn monAn = new DTO_MonAn();
        private SELECTED selected = SELECTED.WAITING;
        private string IDTable = "MA";
        private DataTable ResultTable;
        enum SELECTED
        {
            WAITING,
            INSERT,
            EDIT,
            CELLSELECTED
        }

        public frmQuanLyMonAn()
        {
            InitializeComponent();
            ResultTable = BUS_MonAn.GetDataTableMonAn();
        }

        //Controls
        private void EnableInputsControl(bool flag)
        {
            txtGhiChu.ReadOnly = txtDonGia.ReadOnly = txtTenMonAn.ReadOnly = !flag;
            //txtTenMonAn.Enabled = txtDonGia.Enabled = txtGhiChu.Enabled = flag;
        }
        private void EnableFunctionsControl()
        {
            if (selected == SELECTED.WAITING)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = btnHuy.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                EnableInputsControl(false);
            }
            else if (selected == SELECTED.INSERT)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = true;
                EnableInputsControl(true);
            }
            else if (selected == SELECTED.EDIT)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = true;
                EnableInputsControl(true);
            }
            else if (selected == SELECTED.CELLSELECTED)
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHuy.Enabled = true;
                EnableInputsControl(false);
            }
        }
        private void ClearInputs()
        {
            txtDonGia.Text = txtTenMonAn.Text = txtGhiChu.Text = "";
        }
        private bool InputsAreNull()
        {
            if (txtTenMonAn.Text == "" || txtDonGia.Text == "")
                return true;
            return false;
        }

        //Buttons Action
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.selected = SELECTED.INSERT;

            ClearInputs();
            EnableFunctionsControl();
            txtTenMonAn.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            this.selected = SELECTED.EDIT;

            EnableFunctionsControl();
            //txtTenMonAn.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có muốn xóa món ăn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int selectedRow = dgvDanhSachMonAn.SelectedRows[0].Index;
                monAn.MaMonAn = int.Parse(dgvDanhSachMonAn[0, selectedRow].Value.ToString());
                BUS_MonAn.DeleteMonAn(monAn);
                ResultTable = BUS_MonAn.GetDataTableMonAn();
                dgvDanhSachMonAn.DataSource = ResultTable;

                this.selected = SELECTED.WAITING;
                EnableFunctionsControl();
                ClearInputs();

                MessageBox.Show("Xóa thành công!");
            }
            else if (confirm == DialogResult.No)
            {
                return;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (InputsAreNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
            }
            //INSERT
            else if (selected == SELECTED.INSERT)
            {
                //Check txtDonGia
                double parsedValue;
                if (!double.TryParse(txtDonGia.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá - chỉ chấp nhận định dạng số!");
                    txtDonGia.ResetText();
                    return;
                }
                else if (txtDonGia.Text.Length > 18)
                {
                    MessageBox.Show("Đơn giá - không vượt quá 18 chữ số!");
                    txtDonGia.ResetText();
                    return;
                }
                // monAn.MaMonAn = GetNextID(ResultTable);
                monAn.TenMonAn = txtTenMonAn.Text;
                monAn.DonGia = Convert.ToDecimal(txtDonGia.Text.ToString());
                monAn.GhiChu = txtGhiChu.Text;
                BUS_MonAn.InsertMonAn(monAn);
                ResultTable = BUS_MonAn.GetDataTableMonAn();
                dgvDanhSachMonAn.DataSource = ResultTable;

                this.selected = SELECTED.WAITING;
                EnableFunctionsControl();
                ClearInputs();
                MessageBox.Show("Thêm thành công!");
            }
            //UPDATE
            else if (selected == SELECTED.EDIT)
            {
                //Check txtDonGia
                double parsedValue;
                if (!double.TryParse(txtDonGia.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá - chỉ chấp nhận định dạng số!");
                    txtDonGia.ResetText();
                    return;
                }
                monAn.TenMonAn = txtTenMonAn.Text;
                monAn.DonGia = Convert.ToDecimal(txtDonGia.Text.ToString());
                monAn.GhiChu = txtGhiChu.Text;
                BUS_MonAn.UpdateMonAn(monAn);
                ResultTable = BUS_MonAn.GetDataTableMonAn();
                dgvDanhSachMonAn.DataSource = ResultTable;

                this.selected = SELECTED.WAITING;
                EnableFunctionsControl();
                EnableInputsControl(false);
                ClearInputs();
                MessageBox.Show("Cập nhật thành công!");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (this.selected == SELECTED.INSERT || this.selected == SELECTED.EDIT)
            {
                DialogResult confirm = MessageBox.Show("Bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    this.selected = SELECTED.WAITING;
                    EnableFunctionsControl();
                    ClearInputs();
                    dgvDanhSachMonAn.ClearSelection();
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            this.selected = SELECTED.WAITING;
            EnableFunctionsControl();
            ClearInputs();
            dgvDanhSachMonAn.ClearSelection();
        }
        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            this.selected = SELECTED.CELLSELECTED;
            EnableFunctionsControl();

            int row = e.RowIndex;
            txtTenMonAn.Text = dgvDanhSachMonAn[1, row].Value.ToString();
            txtDonGia.Text = dgvDanhSachMonAn[2, row].Value.ToString();
            txtGhiChu.Text = dgvDanhSachMonAn[3, row].Value.ToString();
            monAn.MaMonAn = int.Parse(dgvDanhSachMonAn["MaMonAn", row].Value.ToString());
        }

        //On Loading
        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            EnableInputsControl(false);
            EnableFunctionsControl();

            dgvDanhSachMonAn.DataSource = BUS_MonAn.GetDataTableMonAn();
            dgvDanhSachMonAn.Columns["MaMonAn"].Visible = false;
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvDanhSachMonAn.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachMonAn.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        private void dgvDanhSachMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachMonAn.ClearSelection();
        }

        //Chỉ nhập số
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}