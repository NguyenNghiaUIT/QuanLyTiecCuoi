using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LapHoaDonThanhToan
    {
        public static DataTable GetTableTenChuReAndTenCoDau()
        {
            string sqlCommand = @"SELECT MaKH, TenChuRe, TenCoDau FROM KhachHang";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable GetNgayDatTiec(string tenChuRe)
        {
            string sqlCommand = string.Format(
                "SELECT DATEPART(DAY, Ngay) 'Ngay', DATEPART(MONTH, Ngay) 'Thang', DATEPART(YEAR, Ngay) 'Nam' FROM HoaDonTiecCuoi WHERE MaKH = ("
                + " SELECT MaKH FROM KhachHang WHERE TenChuRe=N'{0}')"
                , tenChuRe
            );

            return DatabaseHelper.GetData(sqlCommand);
        }
        public static DataTable GetTableHDTCCustom(string MaKH, string ngayDatTiec)
        {
            string sqlCommand = string.Format(
                "SELECT MaSanh,SoLuongBan,MaHD,TienCoc FROM HoaDonTiecCuoi WHERE MaKH={0} AND CAST(Ngay AS DATE)='{1}'"
                , MaKH, ngayDatTiec
            );

            return DatabaseHelper.GetData(sqlCommand);
        }
        public static string GetDonGiaBanTT(string maSanh)
        {
            DataTable dt = DatabaseHelper.GetData(@"SELECT DonGiaBanToiThieu FROM LoaiSanh WHERE MaLoaiSanh=(SELECT MaLoaiSanh FROM Sanh WHERE MaSanh='"+maSanh+"')");
            return dt.Rows[0]["DonGiaBanToiThieu"].ToString();
        }
        public static DataTable GetCacDichVu(string MaHD)
        {
            string sqlCommand = string.Format(
               "SELECT TenDichVu,SoLuong,DonGia,SoLuong*DonGia AS 'ThanhTien' FROM ChiTietDichVuTiecCuoi INNER JOIN DichVu ON ChiTietDichVuTiecCuoi.MaDichVu = DichVu.MaDichVu WHERE MaHD={0}"
               , MaHD
           );

            return DatabaseHelper.GetData(sqlCommand);
        }
    }
}
