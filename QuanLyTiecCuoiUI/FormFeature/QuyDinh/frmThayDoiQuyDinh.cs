using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoiUI.FormFeature.QuyDinh
{
    public partial class frmThayDoiQuyDinh : Form
    {

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            this.Load += frmThayDoiQuyDinh_Load;
        }

        void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            txtTenQuyDinh.Enabled = false;
            txtGiaTri.Enabled = false;

            int width = (int)Math.Round(dgvQuyDinh.Width / 2.0f);
            dgvQuyDinh.DataSource = BUS.BUS_ThamSo.GetAllThamSo();
            dgvQuyDinh.Columns[0].Width = width;
            dgvQuyDinh.Columns[0].HeaderText = "Tên Quy Định";
            dgvQuyDinh.Columns[1].Width = width;
            dgvQuyDinh.Columns[1].HeaderText = "Giá Trị";



            //dgvQuyDinh.Columns[0].Visible = false;
            //dgvQuyDinh.Columns[1].HeaderText = "Tên Quy Định";
            //dgvQuyDinh.Columns[2].HeaderText = "Giá Trị";
          


         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiaTri.Enabled = true;
            txtTenQuyDinh.Enabled = true;
        }



        private void btnEditQuyDinh_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String tenQuyDinh = txtTenQuyDinh.Text;
            float giaTri = 0.0f;
            try
            {
                giaTri = float.Parse(txtGiaTri.Text.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Giá trị bạn vừa nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
            }

            Console.WriteLine("Chay nua");
            if (BUS.BUS_ThamSo.InsertThamSo(new DTO.DTO_ThamSo(tenQuyDinh, giaTri)))
                MessageBox.Show("Insert Thành công", "Thông báo", MessageBoxButtons.OK);

            Thread thread = new Thread(() =>
            {
                dgvQuyDinh.Invoke(new Action(() =>
                {
                    dgvQuyDinh.DataSource = BUS.BUS_ThamSo.GetAllThamSo();
                }
                ));
            });
            thread.Start();

        }
    }
}
