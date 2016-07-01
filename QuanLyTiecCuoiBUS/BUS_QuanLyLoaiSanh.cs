using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_QuanLyLoaiSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            return DAO_QuanLyLoaiSanh.GetLoaiSanhTable();
        }
        public static bool InsertLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            if (DAO_QuanLyLoaiSanh.NumbersOfMaLoaiSanhInLoaiSanh(loaiSanh) == 1)
                return false;
            DAO_QuanLyLoaiSanh.InsertLoaiSanh(loaiSanh);
            return true;
        }
        public static void UpdateLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            DAO_QuanLyLoaiSanh.UpdateLoaiSanh(loaiSanh);
        }
        public static bool DeleteLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            if (DAO_QuanLyLoaiSanh.NumbersOfMaLoaiSanhInSanh(loaiSanh) > 0)
                return false;

            DAO_QuanLyLoaiSanh.DeleteLoaiSanh(loaiSanh);
            return true;
        }
    }
}
