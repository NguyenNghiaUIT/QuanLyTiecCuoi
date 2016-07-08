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
using System.IO;

namespace QuanLyTiecCuoiUI
{
    public partial class frmChaoUser : Form
    {
        public DataTable CurrentNhanVien;
        private DTO_NhanVien nhanviendangnhap = new DTO_NhanVien();
        private int MaPhanQuyenNhanVien;
        public frmChaoUser(DataTable nhanvien)
        {
            CurrentNhanVien = nhanvien;
            InitializeComponent();
        }

        public frmChaoUser()
        {
            InitializeComponent();
            lblTenNhanVien.Text = string.Empty;
            lblChucVu.Text = string.Empty;
            this.ControlBox = false;
        }     
        private void frmChaoUser_Load(object sender, EventArgs e)
        {
            lblTenNhanVien.Text = CurrentNhanVien.Rows[0][1].ToString();
            lblChucVu.Text = CurrentNhanVien.Rows[0][10].ToString();
            ptrAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void SetAvatar(string path, string user, string roles)
        {
            ptrAvatar.Image = Image.FromFile(path);
            lblTenNhanVien.Text = user;
            lblChucVu.Text = roles;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            nhanviendangnhap.MaNV = Int32.Parse(CurrentNhanVien.Rows[0][0].ToString());
            nhanviendangnhap.HoTen = CurrentNhanVien.Rows[0][1].ToString();
            nhanviendangnhap.DiaChi = CurrentNhanVien.Rows[0][2].ToString();
            nhanviendangnhap.DienThoai = CurrentNhanVien.Rows[0][3].ToString();
            nhanviendangnhap.Username = CurrentNhanVien.Rows[0][4].ToString();
            nhanviendangnhap.Password = CurrentNhanVien.Rows[0][5].ToString();
            nhanviendangnhap.MaChucVu = Int32.Parse(CurrentNhanVien.Rows[0][6].ToString());
            nhanviendangnhap.TinhTrang = Int32.Parse(CurrentNhanVien.Rows[0][7].ToString());
            nhanviendangnhap.AnhDaiDien = CurrentNhanVien.Rows[0][8].ToString();
            MaPhanQuyenNhanVien = Int32.Parse(CurrentNhanVien.Rows[0][11].ToString());
            Program.manhinhchinh.SetRolesUser(nhanviendangnhap, MaPhanQuyenNhanVien);
            Program.chaouser.Hide();
            Program.dangnhapform.Hide();
            Program.manhinhchinh.Show();
        }
    }
}
