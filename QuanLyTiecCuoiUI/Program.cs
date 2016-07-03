<<<<<<< HEAD
﻿using System;
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
                Application.Run(new frmNhanDatTiecCuoi());
                //Application.Run(new frmManHinhChinh());
                //Application.Run(new frmQuanLyMonAn());
            } 
        }
    }
}
=======
﻿using System;
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
                //Application.Run(new frmQuanLyDichVuNhaHang());
                //Application.Run(new frmThayDoiQuyDinh());
                Application.Run(new frmManHinhChinh());
            } 
        }
    }
}
>>>>>>> 5feb8d9e1ccfed141fd2bbf6ffb2e1872b8cea78
