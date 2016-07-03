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
        public static DataTable GetSanh()
        {
            string sTruyVan = "Select MaSanh, TenSanh, DonGiaBanToiThieu from Sanh, LoaiSanh where Sanh.MaLoaiSanh = LoaiSanh.MaLoaiSanh";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable GetCa()
        {
            string sTruyVan = "Select * from Ca";
            return DatabaseHelper.GetData(sTruyVan);
        }
    }
}
