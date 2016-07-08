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
    public partial class frmQuanLyNhanVien : Form
    {
        #region parameters 
        private DataTable dtChucVu;
        #endregion

        #region load form and state, load data combobox, event gridview

        private void LoadChucVu()
        {
            try
            {
                dtChucVu = BUS_QuanLyNhanVien.LoadChucVu();
                cboChucVuNhanVien.DataSource = dtChucVu;
                cboChucVuNhanVien.DisplayMember = dtChucVu.Columns["TenChucVu"].ToString();
                cboChucVuNhanVien.ValueMember = dtChucVu.Columns["MaChucVu"].ToString();
                cboChucVuNhanVien.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                return;
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                dgvDanhSachNhanVien.DataSource = BUS_QuanLyNhanVien.LoadDanhSachNhanVien();
                dgvDanhSachNhanVien.Columns[0].Visible = false;
                dgvDanhSachNhanVien.Columns[1].HeaderText = "Họ và tên";
                dgvDanhSachNhanVien.Columns[2].HeaderText = "Địa chỉ";
                dgvDanhSachNhanVien.Columns[3].HeaderText = "Điện thoại";
                dgvDanhSachNhanVien.Columns[4].HeaderText = "Username";
                dgvDanhSachNhanVien.Columns[5].HeaderText = "Password";
                dgvDanhSachNhanVien.Columns[6].Visible = false;
                dgvDanhSachNhanVien.Columns[7].HeaderText = "Tình trạng";
                dgvDanhSachNhanVien.Columns[8].Visible = false;
                dgvDanhSachNhanVien.Columns[9].Visible = false;
                dgvDanhSachNhanVien.Columns[10].HeaderText = "Chức vụ";
                dgvDanhSachNhanVien.Columns[11].Visible = false;
                dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachNhanVien.ReadOnly = true;
                dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Load danh sách nhân viên thất bại");
            }
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            //Load state
            LoadDefaultState();
            LoadChucVu();
            LoadDataGridView();
        }

        private void LoadDefaultState()
        {
            pnlThaoTacNhanVien.Visible = false;
            btnThongTinNhanVien.BackColor = Color.Teal;
            btnThaoTacQuanLy.BackColor = Color.FromArgb(0, 64, 64);
            btnThemNhanVien.Enabled = btnLuu.Enabled = btnSuaNhanVien.Enabled = btnHuy.Enabled = btnXoaNhanVien.Enabled = false;
        }

        private void LoadDefaultStateForButton()
        {
            btnLuu.Enabled = btnSuaNhanVien.Enabled = btnHuy.Enabled = btnXoaNhanVien.Enabled = false;
            btnThemNhanVien.Enabled = true;
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowselect = e.RowIndex;
            if (rowselect < 0)
                return;
            try
            {
                //nội dung tab thông tin 
                lblHoTenNhanVien.Text = dgvDanhSachNhanVien.DataSource
                //nội dung tab thao tác
            }
            catch(Exception ex)
            {
                return;
            }
        }
        #endregion

        #region Click tab menu
        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            pnlThaoTacNhanVien.Visible = false;
            btnThongTinNhanVien.BackColor = Color.Teal;
            btnThaoTacQuanLy.BackColor = Color.FromArgb(0, 64, 64);
            LoadDefaultState();
        }

        private void btnThaoTacQuanLy_Click(object sender, EventArgs e)
        {
            pnlThaoTacNhanVien.Visible = true;
            btnThaoTacQuanLy.BackColor = Color.Teal;
            btnThongTinNhanVien.BackColor = Color.FromArgb(0, 64, 64);
            LoadDefaultStateForButton();
        }

        #endregion

        #region Quản lý trạng thái
        #endregion


    }
}
