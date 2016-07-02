using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTiecCuoiUI
{
    public partial class frmCa : Form
    {
        public frmCa()
        {
            InitializeComponent();
        } 
        private void LoadDataGridView()
        {
            dgvTableShow.DataSource = BUS_Ca.GetDataTable();
            dgvTableShow.Columns[0].HeaderText = "Mã ca";
            dgvTableShow.Columns[1].HeaderText = "Tên ca";
            dgvTableShow.Columns[0].Visible = false;
            dgvTableShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTableShow.ReadOnly = true;
            dgvTableShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                                  
        }
        private void frmCa_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            //get Index          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_Ca ca = new DTO_Ca();
            //verified infor
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Thêm thất bại, tên ca còn trống");
                return;
            }
            //get infor to object
            ca.TenCa = txtTenCa.Text;

            DialogResult resultDialog = MessageBox.Show("Bạn có muốn thêm dữ liệu ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool InsertState = BUS_Ca.InsertCa(ca);
                if (InsertState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại, thử lại");
            }
            else
                return;
        }

        private void dgvTableShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = e.RowIndex;
            lblMaCa.Text = dgvTableShow[0, rowSelected].Value.ToString();
            txtTenCa.Text = dgvTableShow[1, rowSelected].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowSelect = -1;
            rowSelect = dgvTableShow.CurrentCell.RowIndex;
            //rowSelect = dgvTableShow.GetCellCount(DataGridViewElementStates.Selected);
            DTO_Ca ca = new DTO_Ca();
            ca.MaCa = Int32.Parse(dgvTableShow[0, rowSelect].Value.ToString());
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa dữ liệu ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool InsertState = BUS_Ca.DeleteCa(ca);
                if (InsertState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xóa thất bại, thử lại");
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowSelect = -1;
            rowSelect = dgvTableShow.CurrentCell.RowIndex;
            DTO_Ca ca = new DTO_Ca();
            //verified infor 
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Sửa thất bại, tên ca còn trống");
                return;
            }
            //get new object 
            ca.TenCa = txtTenCa.Text;
            ca.MaCa = Int32.Parse(dgvTableShow[0, rowSelect].Value.ToString());
            DialogResult resultDialog = MessageBox.Show("Bạn có muốn sửa dữ liệu ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                bool UpdateState = BUS_Ca.UpdateCa(ca);
                if (UpdateState)
                {
                    dgvTableShow.DataSource = BUS_Ca.GetDataTable();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
        }
    }
}
