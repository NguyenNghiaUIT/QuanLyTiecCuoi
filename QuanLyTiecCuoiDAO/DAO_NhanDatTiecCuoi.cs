using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_NhanDatTiecCuoi
    {
        public static DataTable GetMaKH()
        {
            string sTruyVan = "Select * from KhachHang";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetSanh()
        {
            string sTruyVan = "Select * from Sanh";
            return DatabaseHelper.GetData(sTruyVan);
        }
    }
}
