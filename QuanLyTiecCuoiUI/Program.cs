using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using QuanLyTiecCuoiUI.FormFeature.ConfigDatabase;
using QuanLyTiecCuoiUI.FormFeature.QuyDinh;

namespace QuanLyTiecCuoiUI
{
    static class Program
    {
        public static frmManHinhChinh manhinhchinh;
        public static frmLoginForm dangnhapform;
        public static frmChaoUser chaouser;
        static void KhoiTaoForm()
        {
            manhinhchinh = new frmManHinhChinh();
            dangnhapform = new frmLoginForm();
            chaouser = new frmChaoUser();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            DatabaseHelper.CONNECTION_STRING = QuanLyTiecCuoiUI.Properties.Settings.Default.ConnectionString;
            Console.WriteLine(DatabaseHelper.CONNECTION_STRING);
            bool openSuscess = DatabaseHelper.OpenConnection();
            DatabaseHelper.CloseConnection();
            if(!openSuscess){
                 Application.Run(new frmConfigDatabase());
            }else{
                frmManHinhChinh.CurrentNhanVienLogin.MaNV = 2;
                //KhoiTaoForm();
                //Application.Run(new frmNhanDatTiecCuoi());
                //Application.Run(new frmThayDoiQuyDinh());
                //Application.Run(dangnhapform);
                //Application.Run(new frmManHinhChinh());
                Application.Run(new frmQuanLyNhanVien());
            } 
        }
    }
}
