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
    public partial class frmTraCuuTiecCuoi : Form
    {
        private DTO_TraCuu traCuu = new DTO_TraCuu();
        private SELECTED selected = SELECTED.TenChuRe;
        enum SELECTED
        {
            TenChuRe,
            TenCoDau,
            Ngay
        }

        public frmTraCuuTiecCuoi()
        {
            InitializeComponent();
            rbTenChuRe.Select();
            //txtTuKhoa.Focus();
        }

        private bool InputIsNull()
        {
            if (txtTuKhoa.Text == "")
            {
                if (this.selected == SELECTED.Ngay)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private void dgvKetQuaTraCuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Events
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (InputIsNull())
            {
                MessageBox.Show("Từ khóa không hợp lệ!");
            }
            else if (this.selected == SELECTED.TenChuRe)
            {
                traCuu.key = txtTuKhoa.Text;
                dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuTenChuRe(traCuu);
            }
            else if (this.selected == SELECTED.TenCoDau)
            {
                traCuu.key = txtTuKhoa.Text;
                dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuTenCoDau(traCuu);
            }
            else if (this.selected == SELECTED.Ngay)
            {
                //Chưa check điều kiện Ngay hợp lệ nhá ku!
                txtTuKhoa.Text = dtpNgay.Value.ToString("yyyy-MM-dd");
                traCuu.key = txtTuKhoa.Text;
                dgvKetQuaTraCuu.DataSource = BUS_TraCuu.TraCuuNgay(traCuu);
            }
        }

        private void rbTenChuRe_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.TenChuRe;
            dtpNgay.Visible = false;
            txtTuKhoa.Visible = true;
            txtTuKhoa.Focus();
        }

        private void rbTenCoDau_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.TenCoDau;
            dtpNgay.Visible = false;
            txtTuKhoa.Visible = true;
            txtTuKhoa.Focus();
        }

        private void rbNgay_CheckedChanged(object sender, EventArgs e)
        {
            this.selected = SELECTED.Ngay;
            txtTuKhoa.Visible = false;
            dtpNgay.Visible = true;
            dtpNgay.Focus();
        }
    }
}