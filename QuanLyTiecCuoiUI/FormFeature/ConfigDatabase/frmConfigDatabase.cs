using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QuanLyTiecCuoiUI.FormFeature.ConfigDatabase
{
    public partial class frmConfigDatabase : Form
    {
        public frmConfigDatabase()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            String dataSouce = txtDataSouce.Text;
           
            DatabaseHelper.CONNECTION_STRING = DatabaseHelper.CreateConnectionString(dataSouce);
            Debug.WriteLine(DatabaseHelper.CONNECTION_STRING);
            QuanLyTiecCuoiUI.Properties.Settings.Default.ConnectionString = DatabaseHelper.CONNECTION_STRING;
            QuanLyTiecCuoiUI.Properties.Settings.Default.Save();
            bool openSucess = DatabaseHelper.OpenConnection();
            if (openSucess)
            {
                DatabaseHelper.CloseConnection();
                frmManHinhChinh frmMain = new frmManHinhChinh();
                frmMain.ShowDialog();
                this.Close();
              
               
            }
            else
            {
              DialogResult result =   MessageBox.Show("Kết nối không thành công vui lòng thử lại!", "Lỗi connect", MessageBoxButtons.OKCancel);
              if (result == DialogResult.OK)
              {
                  txtDataSouce.Text = "";
              }
            }
        }

      
    }
}
