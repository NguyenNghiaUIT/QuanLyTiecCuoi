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
            txtGiaTri.ReadOnly = true;
            btnEditQuyDinh.Enabled = false;
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

      

      
      
       
    }
}
