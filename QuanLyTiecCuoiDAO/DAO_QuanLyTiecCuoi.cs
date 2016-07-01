using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class DAO_QuanLyTiecCuoi
    {
        public static DataTable GetTableDanhSachTiecCuoi()
        {
            string sqlCommand = @"SELECT TenChuRe,TenCoDau,DienThoai,CAST(Ngay AS DATE) AS Ngay,TenCa,TenSanh,TienCoc,SoLuongBan,SoLuongBanDuTru,MaHD
                                FROM KhachHang AS KH 
	                                INNER JOIN HoaDonTiecCuoi AS HD ON KH.MaKH=HD.MaKH  
	                                INNER JOIN Ca ON Ca.MaCa=HD.MaCa
	                                INNER JOIN Sanh ON Sanh.MaSanh=HD.MaSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static void DeleteTiecCuoi(string MaHD)
        {
            string sqlCommand = @"DELETE FROM ChiTietDichVuTiecCuoi WHERE MaHD=" + MaHD;
            DatabaseHelper.ExcuteSql(sqlCommand);
            sqlCommand = @"DELETE FROM ChiTietThucDonTiecCuoi WHERE MaHD=" + MaHD;
            DatabaseHelper.ExcuteSql(sqlCommand);
            sqlCommand = @"DELETE FROM HoaDonTiecCuoi WHERE MaHD=" + MaHD;
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static DataTable GetColumnCa()
        {
            return DatabaseHelper.GetData(@"SELECT TenCa FROM Ca");
        }
        public static DataTable GetColumnSanh()
        {
            return DatabaseHelper.GetData(@"SELECT TenSanh FROM Sanh");
        }
        public static DataTable GetTableMonAn()
        {
            return DatabaseHelper.GetData(@"SELECT MaMonAn,TenMonAn FROM MonAn");
        }
        public static DataTable GetTableDichVu()
        {
            return DatabaseHelper.GetData(@"SELECT MaDichVu,TenDichVu FROM DichVu");
        }
        public static DataTable GetColumnMonAn(string maHD)
        {
            return DatabaseHelper.GetData(@"SELECT TenMonAn FROM MonAn WHERE MaMonAn IN (SELECT MaMonAn FROM ChiTietThucDonTiecCuoi WHERE MaHD=" + maHD + ")");
        }
    }
}
