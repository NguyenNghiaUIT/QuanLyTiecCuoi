using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_QuanLyTiecCuoi
    {
        public static List<string> _listMaMonAn = new List<string>();
        public static List<string> _listTenMonAn = new List<string>();
        public static List<string> _listMaDichVu = new List<string>();
        public static List<string> _listTenDichVu = new List<string>();
        static BUS_QuanLyTiecCuoi()
        {
            DataTable dt = DAO_QuanLyTiecCuoi.GetTableMonAn();
            foreach (DataRow dr in dt.Rows)
            {
                _listMaMonAn.Add(dr["MaMonAn"].ToString());
                _listTenMonAn.Add(dr["TenMonAn"].ToString());
            } 
            dt = DAO_QuanLyTiecCuoi.GetTableDichVu();
            foreach (DataRow dr in dt.Rows)
            {
                _listMaDichVu.Add(dr["MaDichVu"].ToString());
                _listTenDichVu.Add(dr["TenDichVu"].ToString());
            }

        }
        public static DataTable GetTableDanhSachTiecCuoi()
        {
            return DAO_QuanLyTiecCuoi.GetTableDanhSachTiecCuoi(); 
        }
        public static void DeleteTiecCuoi(string MaHD)
        {
            DAO_QuanLyTiecCuoi.DeleteTiecCuoi(MaHD);
        }
        public static List<string> GetListCa()
        {
            DataTable dt = DAO_QuanLyTiecCuoi.GetColumnCa();
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
                list.Add(dr["TenCa"].ToString());
            return list;
        }
        public static List<string> GetListSanh()
        {
            DataTable dt = DAO_QuanLyTiecCuoi.GetColumnSanh();
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
                list.Add(dr["TenSanh"].ToString());
            return list;
        }
        public static List<string> GetListMonAn(string maHD)
        {
            DataTable dt = DAO_QuanLyTiecCuoi.GetColumnMonAn(maHD);
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["TenMonAn"].ToString());
            }
            return list;
        }
    }
}
