using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_QuanLyNhanVien
    {
        public static DataTable LoadChucVu()
        {
            return DAO_QuanLyNhanVien.LoadChucVu();
        }
        public static DataTable LoadDanhSachNhanVien()
        {
            return DAO_QuanLyNhanVien.LoadDanhSachNhanVien();
        }
    }
}
