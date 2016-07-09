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
using DTO;

namespace QuanLyTiecCuoiUI.FormFeature.QuyDinh
{
    public partial class frmThayDoiQuyDinh : Form
    {
        private STATE_MODE mStateMode = STATE_MODE.EDIT;
        enum STATE_MODE
        {
            EDIT,
            SAVE
        }
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            this.Load += frmThayDoiQuyDinh_Load;
            txtGiaTri.KeyPress += txtGiaTri_KeyPress;
        }

        void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtGiaTri.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    
        void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            txtTenQuyDinh.ReadOnly = true;
            txtGiaTri.ReadOnly = true;
            cbApDung.Enabled = false;
            
           
            DTO_ThamSo thamSo = BUS.BUS_ThamSo.GetThamSo();
            txtTenQuyDinh.Text = thamSo.TenQuyDinh;
            txtGiaTri.Text = thamSo.GiaTri.ToString();

            cbApDung.Checked = QuanLyTiecCuoiUI.Properties.Settings.Default.ApplyQuyDinh;
         
        }

        private void btnEditQuyDinh_Click(object sender, EventArgs e)
        {
            if (mStateMode == STATE_MODE.EDIT)
            {
                txtGiaTri.ReadOnly = false;
                cbApDung.Enabled = true;
                mStateMode = STATE_MODE.SAVE;
                btnEditQuyDinh.Text = "Lưu";
               mStateMode = STATE_MODE.SAVE;
            }
            else
            {
                Console.WriteLine("SAVE");
                DialogResult dr = MessageBox.Show("Bạn có muốn thay đổi quy định này hay không?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    if (String.IsNullOrWhiteSpace(txtGiaTri.Text))
                    {
                        MessageBox.Show("Giá trị không được để trống", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    float giaTri = 0.0f;

                    try
                    {
                        giaTri = float.Parse(txtGiaTri.Text);
                        if (giaTri > 10.0f)
                            return;
                        if (BUS.BUS_ThamSo.UpdateThamSo(new DTO.DTO_ThamSo(txtTenQuyDinh.Text, giaTri)))
                        {

                            txtGiaTri.ReadOnly = true;
                            cbApDung.Enabled = false;
                            QuanLyTiecCuoiUI.Properties.Settings.Default.ApplyQuyDinh = cbApDung.Checked;
                            QuanLyTiecCuoiUI.Properties.Settings.Default.Save();
                            mStateMode = STATE_MODE.EDIT;
                            btnEditQuyDinh.Text = "Sửa";

                            DTO_ThamSo thamSo = BUS.BUS_ThamSo.GetThamSo();
                            txtGiaTri.Text = thamSo.GiaTri.ToString();
                            cbApDung.Checked = cbApDung.Checked;
                        }

                    }
                    catch
                    {

                    }
                }
                else
                {
                    btnEditQuyDinh.Text = "Sửa";
                    mStateMode = STATE_MODE.EDIT;
                    txtGiaTri.ReadOnly = true;
                    cbApDung.Enabled = false;
                }
                
                
              
            }
        }

     

       

      

      
      
       
    }
}
