using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiecCuoiUI.Properties;
using QuanLyTiecCuoiUI.ucControlFeature;
using System.Threading;
using System.Diagnostics;

namespace QuanLyTiecCuoiUI
{
    public partial class frmManHinhChinh : Form
    {
        private int StateClickMenuItem = -1;
        private ItemQuanLy itemQuanly = new ItemQuanLy();
        private ItemTraCuu itemTraCuu = new ItemTraCuu();
        private ItemBaoCao itemBaoCao = new ItemBaoCao();
        private ItemQuyDinh itemQuyDinh = new ItemQuyDinh();
        private string NavigationStatus = string.Empty;

        public void UpdateNavigation(string ActionName)
        {

        }
        public frmManHinhChinh()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            ptrLoGo.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            if (label1.Text.Length > 18) label1.Text = "Xin chào, " + label1.Text.Substring(0, 18) + "...";
            else
                label1.Text = "      Xin chào, " + label1.Text;
            //Setup status 
            lblNavigation.Text = "QUẢN LÝ - Nhận đặt tiệc cưới, Quản lý khách hàng";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng xuất");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label3.ForeColor = Color.AntiqueWhite;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            label3.ForeColor = Color.Black;
        }

        private void EnablePanel(Panel temp, bool a)
        {
            temp.Enabled = a;
            temp.Show();            
        }

        #region Load form and load event,check form load
        private bool IsOpened(string name)
        {
            bool check = false;
            foreach(var frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void LoadEventSelected()
        {
            //Quản lý Container
            itemQuanly.Controls["btnNhanDatTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnNhanDatTiecCuoi_MouseClick);
            itemQuanly.Controls["btnQuanLyKhachHang"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyKhachHang_MouseClick);
            itemQuanly.Controls["btnTiepNhanSanh"].MouseClick += new MouseEventHandler(this.OnbtnTiepNhanSanh_MouseClick);
            itemQuanly.Controls["btnQuanLySanh"].MouseClick += new MouseEventHandler(this.OnbtnQuanLySanh_MouseClick);
            itemQuanly.Controls["btnQuanLyTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyTiecCuoi_MouseClick);
            itemQuanly.Controls["btnLapHoaDonThanhToan"].MouseClick += new MouseEventHandler(this.OnbtnLapHoaDonThanhToan_MouseClick);
            itemQuanly.Controls["btnQuanLyMonAn"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyMonAn_MouseClick);
            itemQuanly.Controls["btnQuanLyDichVu"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyDichVu_MouseClick);
            //Tra Cứu Container
            itemTraCuu.Controls["btnTraCuuTiecCuoi"].MouseClick += new MouseEventHandler(this.OnbtnTraCuuTiecCuoi_MouseClick);
            //Lập Báo Cáo Container 
            itemBaoCao.Controls["btnLapBaoCaoDoanhSo"].MouseClick += new MouseEventHandler(this.OnbtnLapBaoCaoDoanhSo_MouseClick);
            //Quy Định Container
            itemQuyDinh.Controls["btnThayDoiQuyDinh"].MouseClick += new MouseEventHandler(this.OnbtnThayDoiQuyDinh_MouseClick);
            itemQuyDinh.Controls["btnQuanLyLoaiSanh"].MouseClick += new MouseEventHandler(this.OnbtnQuanLyLoaiSanh_MouseClick);
            itemQuyDinh.Controls["btnQuanLyCa"].MouseClick += new MouseEventHandler(this.OnQuanLyCa_MouseClick);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //load event
            LoadEventSelected();
            //Set parents form
            this.IsMdiContainer = true;
        }

        #endregion
        #region Events control 
        private void OnbtnThayDoiQuyDinh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTraCuuTiecCuoi"))
            {
                frmTraCuuTiecCuoi tracuutieccuoi = new frmTraCuuTiecCuoi();
                tracuutieccuoi.MdiParent = this;
                tracuutieccuoi.Name = "frmTraCuuTiecCuoi";
                tracuutieccuoi.Show();
            }
        }
        private void OnbtnTraCuuTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmTraCuuTiecCuoi"))
            {
                frmTraCuuTiecCuoi tracuutieccuoi = new frmTraCuuTiecCuoi();
                tracuutieccuoi.MdiParent = this;
                tracuutieccuoi.Name = "frmTraCuuTiecCuoi";
                tracuutieccuoi.Show();
            }
        }
        private void OnQuanLyCa_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmCa"))
            {
                frmCa ca = new frmCa();
                ca.MdiParent = this;
                ca.Name = "frmCa";
                ca.Show();
            }
        }

        private void OnbtnLapBaoCaoDoanhSo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmLapBaoCaoThang"))
            {
                frmLapBaoCaoThang lapbaocaothang = new frmLapBaoCaoThang();
                lapbaocaothang.MdiParent = this;
                lapbaocaothang.Name = "frmLapBaoCaoThang";
                lapbaocaothang.Show();
            }
        }
        private void OnbtnTiepNhanSanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLySanh"))
            {
                Debug.WriteLine("OPEN"); 
                frmTiepNhanSanh tiepnhansanh = new frmTiepNhanSanh();
                tiepnhansanh.MdiParent = this;
                tiepnhansanh.Name = "frmTiepNhanSanh";
                tiepnhansanh.Show();
            }
        }

        private void OnbtnQuanLySanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLySanh"))
            {
                frmQuanLySanh quanlysanh = new frmQuanLySanh();
                quanlysanh.MdiParent = this;
                quanlysanh.Name = "frmQuanLySanh";
                quanlysanh.Show();
            }         
        }

        private void OnbtnQuanLyLoaiSanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyLoaiSanh"))
            {
                frmQuanLyLoaiSanh quanlyloaisanh = new frmQuanLyLoaiSanh();
                quanlyloaisanh.MdiParent = this;
                quanlyloaisanh.Name = "frmQuanLyLoaiSanh";
                quanlyloaisanh.Show();
            }
        }

        private void OnbtnQuanLyTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyTiecCuoi"))
            {
                frmQuanLyTiecCuoi quanlytieccuoi = new frmQuanLyTiecCuoi();
                quanlytieccuoi.MdiParent = this;
                quanlytieccuoi.Name = "frmQuanLyTiecCuoi";
                quanlytieccuoi.Show();
            }                
        }

        private void OnbtnLapHoaDonThanhToan_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmLapHoaDonThanhToan"))
            {
                frmLapHoaDonThanhToan laphoadonthanhtoan = new frmLapHoaDonThanhToan();
                laphoadonthanhtoan.MdiParent = this;
                laphoadonthanhtoan.Name = "frmLapHoaDonThanhToan";
                laphoadonthanhtoan.Show();
            }
        }

        private void OnbtnQuanLyMonAn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyMonAn"))
            {
                frmQuanLyMonAn quanlymonan = new frmQuanLyMonAn();
                quanlymonan.MdiParent = this;
                quanlymonan.Name = "frmQuanLyMonAn";
                quanlymonan.Show();
            }
        }

        private void OnbtnQuanLyDichVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyDichVu"))
            {
                frmQuanLyDichVu quanlydichvu = new frmQuanLyDichVu();
                quanlydichvu.MdiParent = this;
                quanlydichvu.Name = "frmQuanLyDichVu";
                quanlydichvu.Show();
            }
        }
        private void OnbtnNhanDatTiecCuoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmNhanDatTiecCuoi"))
            {
                frmNhanDatTiecCuoi nhandattieccuoi = new frmNhanDatTiecCuoi();
                nhandattieccuoi.MdiParent = this;
                nhandattieccuoi.Name = "frmNhanDatTiecCuoi";
                nhandattieccuoi.Show();
            }
        }

        private void OnbtnQuanLyKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsOpened("frmQuanLyKhachHang"))
            {
                frmQuanLyKhachHang quanlykhachhang = new frmQuanLyKhachHang();
                quanlykhachhang.MdiParent = this;
                quanlykhachhang.Name = "frmQuanLyKhachHang";
                quanlykhachhang.Show();
            }
        }
        #endregion

        #region Menu Item events


        private void SelectButtonUnCheck(int type)
        {
            if (type == 1)
            {
                btnQuanLy.Image = Resources.button_quanly_default;
            }
            else
                if (type == 3)
            {
                btnTraCuu.Image = Resources.button_tracuu_default;
            }
            else
                if (type == 5)
            {
                btnBaoCao.Image = Resources.button_BaoCao_Default1;
            }
            else
                if (type == 7)
            {
                btnQuyDinh.Image = Resources.button_QuyDinh_Default;
            }
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            //Change button style && show dropdownlist
            //first click
            if (StateClickMenuItem == -1)
            {               
                btnQuanLy.Image = Resources.HoverQuanLy;

                tlpMenu.RowStyles[1].Height = 55;
                tlpMenu.RowStyles[8].Height = 5;
                tlpMenu.Controls.Add(itemQuanly, 0, 1);
                itemQuanly.Enabled = true;
                StateClickMenuItem = 1;
                return;
            }
            //double click
            if (StateClickMenuItem == 1) 
            {
                tlpMenu.RowStyles[StateClickMenuItem].Height = 0;
                tlpMenu.RowStyles[8].Height = 60;

                btnQuanLy.Image = Resources.button_quanly_default;

                itemQuanly.Enabled = false;
                StateClickMenuItem = -1;
                return;
            }

            //Another click
            SelectButtonUnCheck(StateClickMenuItem);
            tlpMenu.RowStyles[StateClickMenuItem].Height = 0;
            tlpMenu.RowStyles[8].Height = 5;
            tlpMenu.RowStyles[1].Height = 55;
            itemQuanly.Enabled = true;
            btnQuanLy.Image = Resources.HoverQuanLy;
            tlpMenu.Controls.Add(itemQuanly, 0, 1);
            StateClickMenuItem = 1;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            //Change button style && show dropdownlist
            //first click
            if (StateClickMenuItem == -1)
            {               
                btnTraCuu.Image = Resources.HoverTraCuu;
                tlpMenu.RowStyles[3].Height = 10;
                tlpMenu.RowStyles[8].Height = 50;
                tlpMenu.Controls.Add(itemTraCuu, 0, 3);
                itemTraCuu.Enabled = true;
                StateClickMenuItem = 3;
                return;
            }
            //double click
            if (StateClickMenuItem == 3)
            {
                tlpMenu.RowStyles[3].Height = 0;
                tlpMenu.RowStyles[8].Height = 60;
                itemTraCuu.Enabled = false;
                btnTraCuu.Image = Resources.button_tracuu_default;
                StateClickMenuItem = -1;
                return;
            }

            //Another click
            SelectButtonUnCheck(StateClickMenuItem);
            tlpMenu.RowStyles[StateClickMenuItem].Height = 0;
            tlpMenu.RowStyles[8].Height = 50;
            tlpMenu.RowStyles[3].Height = 10;
            tlpMenu.Controls.Add(itemTraCuu, 0, 3);
            itemTraCuu.Enabled = true;
            btnTraCuu.Image = Resources.HoverTraCuu;
            StateClickMenuItem = 3;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //Change button style && show dropdownlist
            //first click
            if (StateClickMenuItem == -1)
            {               
                btnBaoCao.Image = Resources.HoverBaoCao;
                tlpMenu.RowStyles[5].Height = 10;
                tlpMenu.RowStyles[8].Height = 50;
                tlpMenu.Controls.Add(itemBaoCao, 0, 5);
                itemBaoCao.Enabled = true;
                StateClickMenuItem = 5;
                return;
            }
            //double click
            if (StateClickMenuItem == 5)
            {
                btnBaoCao.Image = Resources.button_BaoCao_Default1;
                tlpMenu.RowStyles[5].Height = 0;
                tlpMenu.RowStyles[8].Height = 60;
                itemBaoCao.Enabled = false;
                StateClickMenuItem = -1;
                return;
            }

            //Another click
            SelectButtonUnCheck(StateClickMenuItem);
            tlpMenu.RowStyles[StateClickMenuItem].Height = 0;
            tlpMenu.RowStyles[8].Height = 50;
            tlpMenu.RowStyles[5].Height = 10;
            tlpMenu.Controls.Add(itemBaoCao, 0, 5);
            itemBaoCao.Enabled = true;
            btnBaoCao.Image = Resources.HoverBaoCao;
            StateClickMenuItem = 5;
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            //Change button style && show dropdownlist
            //first click
            if (StateClickMenuItem == -1)
            {               
                btnQuyDinh.Image = Resources.HoverQuyDInh;
                tlpMenu.RowStyles[7].Height = 30;
                tlpMenu.RowStyles[8].Height = 30;
                tlpMenu.Controls.Add(itemQuyDinh, 0, 7);
                itemQuyDinh.Enabled = true;
                StateClickMenuItem = 7;
                return;
            }
            //double click
            if (StateClickMenuItem == 7)
            {
                btnQuyDinh.Image = Resources.button_QuyDinh_Default;
                tlpMenu.RowStyles[7].Height = 0;
                tlpMenu.RowStyles[8].Height = 60;
                itemQuyDinh.Enabled = false;
                StateClickMenuItem = -1;
                return;
            }

            //Another click
            SelectButtonUnCheck(StateClickMenuItem);
            tlpMenu.RowStyles[StateClickMenuItem].Height = 0;
            tlpMenu.RowStyles[8].Height = 30;
            tlpMenu.RowStyles[7].Height = 30;
            tlpMenu.Controls.Add(itemQuyDinh, 0, 7);
            itemQuyDinh.Enabled = true;
            btnQuyDinh.Image = Resources.HoverQuyDInh;
            StateClickMenuItem = 7;
        }
        #endregion
    }
}







