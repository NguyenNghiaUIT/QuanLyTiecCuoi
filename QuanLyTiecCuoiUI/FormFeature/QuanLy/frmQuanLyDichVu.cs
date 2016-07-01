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
    public partial class frmQuanLyDichVu : Form
    {
        private DTO_DichVu dichVu = new DTO_DichVu();
        private SELECTED selected = SELECTED.WAITING;
        private string IDTable = "DV";
        private DataTable ResultTable;
        enum SELECTED
        {
            WAITING,
            INSERT,
            EDIT,
            CELLSELECTED
        }

        //Get next ID 
        //Convert Number to string for index
        private string ConvertNumber(int state)
        {
            if (state <= 9) return '0' + state.ToString();
            else
                return state.ToString();
        }
        //Get next index in table
        private string GetNextID(DataTable result)
        {
            try
            {
                return IDTable + (ConvertNumber(Int32.Parse(result.Rows[ResultTable.Rows.Count - 1].ItemArray[0].ToString().Substring(2)) + 1));
            }
            catch (Exception ex)
            {
                return IDTable + "01";
            }
        }
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            ResultTable = BUS_DichVu.GetData();
        }
        private void EnableInputsControl(bool flag)
        {
            txtTenDichVu.Enabled = txtDonGia.Enabled = txtGhiChu.Enabled = flag;
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
                btnThem.Enabled = btnLuu.Enabled = false;
                btnSua.Enabled = btnXoa.Enabled = btnHuy.Enabled = true;
                EnableInputsControl(false);
            }
        }
        private void ClearInputs()
        {
            txtTenDichVu.Text = txtDonGia.Text = txtGhiChu.Text = "";
        }
        private bool InputsAreNull()
        {
            if (txtTenDichVu.Text == "" || txtDonGia.Text == "")
                return true;
            return false;
        }

        //Buttons Action
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.selected = SELECTED.INSERT;

            ClearInputs();
            EnableFunctionsControl();
            txtTenDichVu.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            this.selected = SELECTED.EDIT;

            EnableFunctionsControl();
            //txtTenDichVu.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int selectedRow = dgvDanhSachDichVu.SelectedRows[0].Index;
                dichVu.MaDichVu = dgvDanhSachDichVu[0, selectedRow].Value.ToString();
                BUS_DichVu.Delete(dichVu);
                ResultTable = BUS_DichVu.GetData();
                dgvDanhSachDichVu.DataSource = ResultTable;
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
                dichVu.MaDichVu = GetNextID((DataTable)dgvDanhSachDichVu.DataSource);
                dichVu.TenDichVu = txtTenDichVu.Text;
                dichVu.DonGia = Convert.ToDecimal(txtDonGia.Text.ToString());
                dichVu.GhiChu = txtGhiChu.Text;
                BUS_DichVu.Insert(dichVu);
                ResultTable = BUS_DichVu.GetData();
                dgvDanhSachDichVu.DataSource = ResultTable;

                this.selected = SELECTED.WAITING;
                EnableFunctionsControl();
                ClearInputs();
                MessageBox.Show("Thêm thành công!");
            }
            //UPDATE
            else if (selected == SELECTED.EDIT)
            {
                //Check txtDonGia
                int parsedValue;
                if (!int.TryParse(txtDonGia.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá - chỉ chấp nhận định dạng số!");
                    txtDonGia.ResetText();
                    return;
                }
                dichVu.TenDichVu = txtTenDichVu.Text;
                dichVu.DonGia = Convert.ToDecimal(txtDonGia.Text.ToString());
                dichVu.GhiChu = txtGhiChu.Text;
                BUS_DichVu.Update(dichVu);
                ResultTable = BUS_DichVu.GetData();
                dgvDanhSachDichVu.DataSource = ResultTable;

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
                    dgvDanhSachDichVu.ClearSelection();
                }
                else if (confirm == DialogResult.No)
                {
                    return;
                }
            }
            this.selected = SELECTED.WAITING;
            EnableFunctionsControl();
            ClearInputs();
            dgvDanhSachDichVu.ClearSelection();
        }

        private void dgvDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            this.selected = SELECTED.CELLSELECTED;
            EnableFunctionsControl();

            int row = e.RowIndex;
            txtTenDichVu.Text = dgvDanhSachDichVu[1, row].Value.ToString();
            txtDonGia.Text = dgvDanhSachDichVu[2, row].Value.ToString();
            txtGhiChu.Text = dgvDanhSachDichVu[3, row].Value.ToString();
            dichVu.MaDichVu = dgvDanhSachDichVu[0, row].Value.ToString();
        }

        //On Loading
        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            EnableInputsControl(false);
            EnableFunctionsControl();

            dgvDanhSachDichVu.DataSource = BUS_DichVu.GetData();
            dgvDanhSachDichVu.Columns["MaDichVu"].Visible = false;
            dgvDanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgvDanhSachDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachDichVu.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        private void dgvDanhSachDichVu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachDichVu.ClearSelection();
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
