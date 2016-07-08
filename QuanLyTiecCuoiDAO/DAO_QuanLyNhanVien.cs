using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_QuanLyNhanVien
    {
        public static DataTable LoadChucVu()
        {
            string sTruyVan = "Select * from CHUCVU";
            return DatabaseHelper.GetData(sTruyVan);
        }
        public static DataTable LoadDanhSachNhanVien()
        {
            string sTruyVan = "Select * from NHANVIEN, CHUCVU where NHANVIEN.MaChucVu = CHUCVU.MaChucVu";
            return DatabaseHelper.GetData(sTruyVan);
        }
    }
}
