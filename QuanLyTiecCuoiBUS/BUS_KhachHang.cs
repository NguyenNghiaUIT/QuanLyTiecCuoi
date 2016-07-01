using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_KhachHang
    {
        public static DataTable GetDataTable()
        {
            return DAO_KhachHang.GetDataTable();
        }
        public static bool InsertKhachHang(DTO_KhachHang khachhang)
        {
            return DAO_KhachHang.InsertKhachHang(khachhang);
        }
        public static bool UpdateKhachHang(DTO_KhachHang khachhang)
        {
            return DAO_KhachHang.UpdateKhachHang(khachhang);
        }
        public static bool DeleteKhachHang(DTO_KhachHang khachhang)
        {
            return DAO_KhachHang.DeleteKhachHang(khachhang);
        }
    }
}
