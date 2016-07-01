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
    public partial class frmQuanLyKhachHang : Form
    {
        enum ActionState
        {
            INSERT,
            UPDATE,
            REMOVE,
            SAVE,
        }
        private string IDTable = "KH";
        private ActionState state;
        private DataTable ResultTable;
        private int rowSelect = -1;
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
        public frmQuanLyKhachHang(string TableID)
        {
            InitializeComponent();
            IDTable = TableID;
            ResultTable = BUS_KhachHang.GetDataTable();
        }
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            ResultTable = BUS_KhachHang.GetDataTable();
        }
        //Load DatagridView
        private void LoadDataGridView()
        {
            dgvDanhSachKhachHang.DataSource = ResultTable;
            dgvDanhSachKhachHang.Columns[0].Visible = false;
            dgvDanhSachKhachHang.Columns[1].HeaderText = "Tên chú rể";
            dgvDanhSachKhachHang.Columns[2].HeaderText = "Tên cô dâu";
            dgvDanhSachKhachHang.Columns[3].HeaderText = "Điện thoại";
            dgvDanhSachKhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgvDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachKhachHang.ReadOnly = true;
            dgvDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhachHang.MultiSelect = false;
        }
        //Update datagridview
        private void UpDateDataGridView()
        {
            ResultTable = BUS_KhachHang.GetDataTable();
            dgvDanhSachKhachHang.DataSource = ResultTable;
        }
        private void DisableButton(bool state)
        {
            btnLuu.Enabled = btnHuy.Enabled = state;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = !state;
        }
        private void DisableThongTinKhachHang(bool state)
        {
            txtTenChuRe.ReadOnly = txtTenCoDau.ReadOnly = txtDienThoai.ReadOnly = txtDiaChi.ReadOnly = state;
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            //Disable button Update and load
            DisableThongTinKhachHang(true);
            DisableButton(false);
            //Options Display
            LoadDataGridView();
            btnThem.Focus();          
            lblThongTinMaKhachHang.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Display menu insert khach hang
            DisableThongTinKhachHang(false);
            DisableButton(true);
            txtDiaChi.Text = txtDienThoai.Text = txtTenChuRe.Text = txtTenCoDau.Text = string.Empty;
            txtTenChuRe.Focus();
            lblThongTinMaKhachHang.Text = GetNextID(ResultTable);
            state = ActionState.INSERT;        
        }

        private void ShowDataCell()
        {            
            lblThongTinMaKhachHang.Text = dgvDanhSachKhachHang[0, rowSelect].Value.ToString();
            txtTenChuRe.Text = dgvDanhSachKhachHang[1, rowSelect].Value.ToString();
            txtTenCoDau.Text = dgvDanhSachKhachHang[2, rowSelect].Value.ToString();
            txtDienThoai.Text = dgvDanhSachKhachHang[3, rowSelect].Value.ToString();
            txtDiaChi.Text = dgvDanhSachKhachHang[4, rowSelect].Value.ToString();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {          
            try
            {
                rowSelect = dgvDanhSachKhachHang.CurrentCell.RowIndex;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chưa chọn khách hàng cập nhật", "Thông báo");
                return;
            }

            ShowDataCell();
            DisableThongTinKhachHang(false);
            DisableButton(true);
            state = ActionState.UPDATE;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                rowSelect = dgvDanhSachKhachHang.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa chọn khách hàng cần xóa ", "Thông báo");
                return;
            }

            DTO_KhachHang khachhang = new DTO_KhachHang();
            khachhang.MaKH = dgvDanhSachKhachHang[0, rowSelect].Value.ToString();
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool RemoveState = BUS_KhachHang.DeleteKhachHang(khachhang);
                if (RemoveState)
                {
                    UpDateDataGridView();
                    rowSelect = 0;
                    ShowDataCell();
                    DisableButton(false);
                    DisableThongTinKhachHang(true);
                    MessageBox.Show("Xóa thành công");                   
                }
                else
                    MessageBox.Show("Xóa thất bại, thử lại");
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {         
            //state Insert
            if (state == ActionState.INSERT)
            {
                DTO_KhachHang khachhang = new DTO_KhachHang();
                if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Thêm thất bại, thông tin còn trống", "Thông báo");
                    return;
                }
                
                khachhang.MaKH = lblThongTinMaKhachHang.Text;
                khachhang.TenChuRe = txtTenChuRe.Text;
                khachhang.TenCoDau = txtTenCoDau.Text;
                khachhang.DienThoai = txtDienThoai.Text;
                khachhang.DiaChi = txtDiaChi.Text;

                DialogResult resultDialog = MessageBox.Show("Bạn có muốn thêm dữ liệu khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultDialog == DialogResult.Yes)
                {
                    bool InsertState = BUS_KhachHang.InsertKhachHang(khachhang);
                    if (InsertState)
                    {
                        UpDateDataGridView();
                        dgvDanhSachKhachHang.ClearSelection();
                        rowSelect = 0;
                        ShowDataCell();
                        DisableThongTinKhachHang(true);
                        DisableButton(false);
                        MessageBox.Show("Thêm thành công");         
                    }
                    else
                        MessageBox.Show("Thêm thất bại, thử lại");
                }

                return;               
            } 
            else
            if (state == ActionState.UPDATE)
            {
                DTO_KhachHang khachhang = new DTO_KhachHang();
                if (txtTenChuRe.Text == "" || txtTenCoDau.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Sửa thất bại, thông tin còn trống ", "Thông báo");
                    return;
                }

                khachhang.MaKH = lblThongTinMaKhachHang.Text;
                khachhang.TenChuRe = txtTenChuRe.Text;
                khachhang.TenCoDau = txtTenCoDau.Text;
                khachhang.DienThoai = txtDienThoai.Text;
                khachhang.DiaChi = txtDiaChi.Text;

                DialogResult resultDialog = MessageBox.Show("Bạn có muốn sửa dữ liệu khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultDialog == DialogResult.Yes)
                {
                    bool UpdateState = BUS_KhachHang.UpdateKhachHang(khachhang);
                    if (UpdateState)
                    {
                        UpDateDataGridView();
                        rowSelect = 0;
                        ShowDataCell();
                        DisableThongTinKhachHang(true);
                        DisableButton(false);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa thất bại, thử lại");
                }
                return;
            }   
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtDienThoai.Text = txtTenChuRe.Text = txtTenCoDau.Text = string.Empty;
            lblThongTinMaKhachHang.Text = string.Empty;
            if (rowSelect >= 0)
                ShowDataCell();
            DisableButton(false);
            DisableThongTinKhachHang(true);
        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = e.RowIndex;
            if (rowSelected >= 0)
            {
                lblThongTinMaKhachHang.Text = dgvDanhSachKhachHang[0, rowSelected].Value.ToString();
                txtTenChuRe.Text = dgvDanhSachKhachHang[1, rowSelected].Value.ToString();
                txtTenCoDau.Text = dgvDanhSachKhachHang[2, rowSelected].Value.ToString();
                txtDienThoai.Text = dgvDanhSachKhachHang[3, rowSelected].Value.ToString();
                txtDiaChi.Text = dgvDanhSachKhachHang[4, rowSelected].Value.ToString();
            }          
        }
    }
}
