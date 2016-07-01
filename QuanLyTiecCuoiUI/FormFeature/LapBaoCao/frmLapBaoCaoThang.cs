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

namespace QuanLyTiecCuoiUI
{
    public partial class frmLapBaoCaoThang : Form
    {
        private List<List<string>> mListMonths;
        public frmLapBaoCaoThang()
        {
            InitializeComponent();
        }

        private void frmLapBaoCaoThang_Load(object sender, EventArgs e)
        {
            BUS_LapBaoCaoThang.LoadLapBaoCaoThang();

            mListMonths = BUS_LapBaoCaoThang.GetListOfListMonths();
            if (mListMonths.Count != 0)
            {
                cbbNam.DataSource = BUS_LapBaoCaoThang.GetListYears();
                cbbThang.DataSource = mListMonths[0];

                if (cbbThang.Items.Count > 0)
                    cbbThang.SelectedIndex = 0;
                if (cbbNam.Items.Count > 0)
                    cbbNam.SelectedIndex = 0;
            }

        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.DataSource = mListMonths[cbbNam.SelectedIndex];
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbbNam.Text) && String.IsNullOrEmpty(cbbThang.Text))
                return;

            DataTable dt = BUS_LapBaoCaoThang.GetBaoCaoThang(cbbThang.Text, cbbNam.Text);
            dgvBaoCaoChiTiet.DataSource = dt;
            int tongDT = 0;
            foreach (DataRow dr in dt.Rows)
            {
                tongDT += int.Parse(dr["DoanhThu"].ToString());
            }
            lblTongDoanhThu.Text = tongDT.ToString();
        }
    }
}
