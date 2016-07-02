using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using QuanLyTiecCuoiUI.FormFeature.ConfigDatabase;

namespace QuanLyTiecCuoiUI
{
    static class Program
    {
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
<<<<<<< HEAD
                Application.Run(new frmQuanLyDichVuNhaHang());
=======
                Application.Run(new frmManHinhChinh());
                //Application.Run(new frmQuanLyMonAn());
>>>>>>> 5f348d10b08d0592bba2bb14142b0e2f192ff63b
            } 
        }
    }
}
