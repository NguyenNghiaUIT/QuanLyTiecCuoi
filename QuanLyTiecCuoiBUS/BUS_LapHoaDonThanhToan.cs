using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_LapHoaDonThanhToan
    {
        private static int mSoLuongBan;
        private static Int64 mDonGiaBan;
        private static DataTable mTableCacDichVu;
        private static Int64 mTongTienBan;
        private static Int64 mTongTienDichVu;
        private static Int64 mTongTienHoaDon;
        private static Int64 mTienDatCoc;
        private static Int64 mTienConLai;


        public static DataTable GetAllTiecCuoi(string ngayDaiTiec)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetAllTiecCuoi(ngayDaiTiec);
        }

       

        public static DTO.DTO_TiecCuoi GetTiecCuoi(String tenChuRe, String tenCoDau, String ngayDaiTiec)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetTiecCuoi(tenChuRe, tenCoDau, ngayDaiTiec);
        }
        public static DataTable GetAllTiecCuoi()
        {
            return DAO.DAO_LapHoaDonThanhToan.GetAllTiecCuoi();
        }

        //public static DTO.DTO_TiecCuoi GetTiecCuoi(String tenChuRe, String tenCoDau)
        //{
        //    return DAO.DAO_LapHoaDonThanhToan.GetTiecCuoi(tenChuRe, tenCoDau);
        //}

      

        public static bool UpdateSoTienConLai(DTO.DTO_HoaDon hoaDon)
        {
            return DAO.DAO_LapHoaDonThanhToan.UpdateSoTienConLai(hoaDon);
        }

        public static DTO.DTO_PhieuDatBan GetPhieuDatBan(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetPhieuDatBan(maTiecCuoi);
        }


         public static decimal GetTongTienDichVu(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetTongTienDichVu(maTiecCuoi);
        }
        public static DataTable GetChiTietDichVu(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetChiTietDichVu(maTiecCuoi);
        }

        public static DataTable GetChiTietDatBan(int maPhieuDatBan)
        {
            return DAO.DAO_LapHoaDonThanhToan.GetChiTietDatBan(maPhieuDatBan);
        }

     
    
        public static List<string> GetListNgayDatTiec(string tenChuRe)
        {
            List<string> listNgayDatTiec = new List<string>();
            DataTable dt = DAO_LapHoaDonThanhToan.GetNgayDatTiec(tenChuRe);
            foreach (DataRow dr in dt.Rows)
                listNgayDatTiec.Add(dr["Ngay"].ToString() + "/" + dr["Thang"].ToString() + "/" + dr["Nam"].ToString());
            return listNgayDatTiec;
        }
        public static string GetSoLuongBan()
        {
            return mSoLuongBan.ToString();
        }
        public static Int64 GetDonGiaBan()
        {
            return mDonGiaBan;
        }
        public static Int64 GetTongTienBan()
        {
            return mTongTienBan;
        }
        public static DataTable GetCacDichVu()
        {
            return mTableCacDichVu;
        }
        public static Int64 GetTongTienDichVu()
        {
            return mTongTienDichVu;
        }
        public static Int64 GetTongTienHoaDon()
        {
            return mTongTienHoaDon;
        }
        public static Int64 GetTienDatCoc()
        {
            return mTienDatCoc;
        }
        public static Int64 GetTienConLai()
        {
            return mTienConLai;
        }


        public static bool UpdateTiecCuoi(DTO.DTO_TiecCuoi tiecCuoiInfo)
        {
           return DAO.DAO_LapHoaDonThanhToan.UpdateTiecCuoi(tiecCuoiInfo);
        }

        public static bool IsLapHoaDonThanhToan(int maTiecCuoi)
        {
            return DAO.DAO_LapHoaDonThanhToan.IsLapHoaDonThanhToan(maTiecCuoi);
        }
    }
}
