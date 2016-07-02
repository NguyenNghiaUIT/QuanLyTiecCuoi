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
                Application.Run(new frmQuanLyDichVuNhaHang());
            } 
        }
    }
}
