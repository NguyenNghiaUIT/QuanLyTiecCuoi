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
using System.Threading;

namespace QuanLyTiecCuoiUI
{
    public partial class frmLoginForm : Form
    {
        public delegate void runMainHinhChinh(int PhanQuyen);
        public runMainHinhChinh PhanQuyenForm;

        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            lblNotification.Text = string.Empty;
            txtUser.Focus();
            txtUser.Select(0, 0);
        }

        private void txtUser_MouseEnter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username...")
            {
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Black;
            }
        }
        public void SetFormStart()
        {
            txtUser.Text = "Username...";
            txtUser.ForeColor = Color.LightGray;
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Password...";
            txtPassword.ForeColor = Color.LightGray;
        }
        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                txtUser.Text = "Username...";
                txtUser.ForeColor = Color.LightGray;
            }               
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }                
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.LightGray;
            }        
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Black;
            }                
            else
                e.Handled = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }                
            else
                e.Handled = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUser.Text == "Username..." || txtUser.Text == "")
            {
                lblNotification.Text = "Tên đăng nhập còn trống" + Environment.NewLine;
                return;
            }
            if (txtPassword.Text == "Password..." || txtPassword.Text == "")
            {
                lblNotification.Text = "Mật khẩu còn trống" + Environment.NewLine;
                return;
            }

            DTO_DangNhap dangnhap = new DTO_DangNhap();
            dangnhap.Username = txtUser.Text;
            dangnhap.Password = txtPassword.Text;
            bool state = BUS_DangNhap.KiemTraDangNhap(dangnhap);
            if (state)
            {
                DataTable nhanvienLogin = BUS_DangNhap.GetPhanQuyen(dangnhap);
                Program.chaouser.SetAvatar(@"DanhSachNhanVien\" + nhanvienLogin.Rows[0][8].ToString(), nhanvienLogin.Rows[0][1].ToString(), nhanvienLogin.Rows[0][10].ToString());
                Program.chaouser.CurrentNhanVien = nhanvienLogin;
                Program.chaouser.ShowDialog();
            }
            else
            {
                lblNotification.Text = "Đăng nhập thất bại! ";
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUser.Text == "Username...") txtUser.Text = string.Empty;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text == "Password...") txtPassword.Text = string.Empty;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Select(0, 0);
        }

        private void frmLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //duyệt qua tất cả các form 
            e.Cancel = true;
            Program.dangnhapform.Dispose();
            Program.manhinhchinh.Dispose();
            Program.chaouser.Dispose();
            Application.Exit();
        }
    }
}
