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
        //parameters
        private DataTable KHTableResult;
        public frmNhanDatTiecCuoi()
        {
            InitializeComponent();
            
        }
        //Thêm món ăn
        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            //resize form when load panel themmonan
            this.Size = new Size(900, 500);
            this.MaximumSize = this.MinimumSize = new Size(900, 500);
            this.pnlRightDichVu.Visible = false;
        }
        
        //Thêm dịch vụ
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            //resize form when load panel themdichvu
            this.Size = new Size(900, 500);
            this.MaximumSize = this.MinimumSize = new Size(900, 500);
            this.pnlRightDichVu.Visible = true;
        }

        #region Thao tác nhập
        //Load comboBox Sanh
        private void LoadSanh()
        {
            try
            {
                DataTable result = BUS_NhanDatTiecCuoi.GetSanh();
                cboSanh.DataSource = result;
                cboSanh.DisplayMember = "TenSanh";
                cboSanh.ValueMember = "MaSanh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load dữ liệu Sảnh thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Load combobox Dich vu
        private void LoadDichVu()
        {
            try
            {
                DataTable result = BUS_DichVu.GetData();
                cboDichVu.DataSource = result;
                cboDichVu.DisplayMember = "TenDichVu";
                cboDichVu.ValueMember = "MaDichVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load dữ liệu Dịch Vụ thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //load combobox MonAn
        private void LoadMonAn()
        {
            try
            {
                DataTable result = BUS_MonAn.GetDataTableMonAn();
                cboMon.DataSource = result;
                cboMon.DisplayMember = "TenMonAn";
                cboMon.ValueMember = "MaMonAn";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load dữ liệu Món ăn thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Load comboBox Ca
        private void LoadCa()
        {
            try
            {
                DataTable result = BUS_Ca.GetDataTable();
                cboCa.DataSource = result;
                cboCa.DisplayMember = "TenCa";
                cboCa.ValueMember = "MaCa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load dữ liệu Ca thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Load comboBox MaKH
        private void LoadMaKH()
        {
            try
            {
                KHTableResult = BUS_NhanDatTiecCuoi.GetMaKH();
                cboMaKH.DataSource = KHTableResult;
                cboMaKH.DisplayMember = "MaKH";
                cboMaKH.ValueMember = "MaKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load dữ liệu Mã KH thất bại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //CboDichVu change
        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //cbo MAkh Changed name
        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CurrentValue = cboMaKH.SelectedIndex;
            lblThongTinTenChuRe.Text = KHTableResult.Rows[CurrentValue][1].ToString();
            lblThongTinTenCoDau.Text = KHTableResult.Rows[CurrentValue][2].ToString();
            lblThongTinDienThoai.Text = KHTableResult.Rows[CurrentValue][3].ToString();
            lblThongTinDiaChi.Text = KHTableResult.Rows[CurrentValue][4].ToString();
        }
        //load form 
        private void frmNhanDatTiecCuoi_Load(object sender, EventArgs e)
        {
            //resize form when unload panel themmonan
            this.Size = new Size(690, 500);
            this.MaximumSize = this.MinimumSize = new Size(690, 500);

            //Load Data
            LoadMaKH();
            LoadCa();
            LoadSanh();
            LoadMonAn();
            LoadDichVu();
        }
        //Chọn khách hàng 
        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            //Active infor method 
        }

        private void btnHuyKhachHang_Click(object sender, EventArgs e)
        {
            //Active infor method 
        }
        private void btnThemKhach_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
