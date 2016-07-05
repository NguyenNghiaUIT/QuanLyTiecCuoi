using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_LapHoaDonThanhToan
    {


        public static DataTable GetAllTiecCuoi()
        {
            String sqlCommand = @"select * from TiecCuoi";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static DTO.DTO_TiecCuoi GetTiecCuoi(String tenChuRe, String tenCoDau)
        {
            DTO_TiecCuoi tiecCuoi = null;
            String sqlCommand = String.Format("Select * form TiecCuoi where TenChuRe = N'{0}' AND TenCoDau = N'{1}'", tenChuRe, tenCoDau);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null)
            {
                tiecCuoi = new DTO_TiecCuoi();

                DataRow dataRow = dataTable.Rows[0];
                tiecCuoi.MaTiecCuoi = int.Parse(dataRow["MaTiecCuoi"].ToString());
                tiecCuoi.TenChuRe = dataRow["TenChuRe"].ToString();
                tiecCuoi.TenCoDau = dataRow["TenCoDau"].ToString();
                tiecCuoi.DienThoai = dataRow["DienThoai"].ToString();
                tiecCuoi.NgayDatTiec = dataRow["NgayDatTiec"].ToString();
                tiecCuoi.NgayDaiTiec = dataRow["NgayDaiTiec"].ToString();
                tiecCuoi.MaCa = int.Parse(dataRow["MaCa"].ToString());
                tiecCuoi.MaSanh = int.Parse(dataRow["MaSanh"].ToString());
                tiecCuoi.TienCoc = decimal.Parse(dataRow["TienCoc"].ToString());
                tiecCuoi.GhiChu = dataRow["GhiChu"].ToString();
                tiecCuoi.MaNV = int.Parse(dataRow["MaNV"].ToString());
            }
            return tiecCuoi;
        }

        public static DataTable GetAllHoaDon()
        {
            String sqlCommand = @"Select * from HoaDon";
            return DatabaseHelper.GetData(sqlCommand);
        }

        public static bool InsertHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format(@"INSERT INTO HoaDon (SoHoadon, MaTiecCuoi, NgayThanhToan, TongTienBan, TongTienDichVu, TongTienHoaDon, ConLai)" +
                "VALUES ({0}, {1}, '{2}', {3}, {4}, {5}, {6})", hoaDon.SoHoaDon, hoaDon.MaTiecCuoi, hoaDon.NgayThanhToan, hoaDon.TongTienBan, hoaDon.TongTienDichVu, hoaDon.TongTienHoaDon, hoaDon.ConLai);

            if (DatabaseHelper.ExcuteSql(sqlCommand) == 1)
                return true;
            return false;
        }

        public static bool UpdateHoaDon(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format("UPDATE HoaDon set MATIECCUOI ={0}, NgayThanhToan = {1}, TongTienBan = {2}, TongTienDichVu = {3}, TongTienHoaDon = {4} ConLai = {5} WHERE SoHoaDon = {6}", hoaDon.MaTiecCuoi, hoaDon.NgayThanhToan, hoaDon.TongTienBan, hoaDon.TongTienDichVu, hoaDon.TongTienHoaDon, hoaDon.ConLai, hoaDon.SoHoaDon);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static bool UpdateSoTienConLai(DTO.DTO_HoaDon hoaDon)
        {
            String sqlCommand = String.Format(@"UPDATE HoaDon SET ConLai = {0} WHERE SoHoaDon = {1}", hoaDon.ConLai, hoaDon.SoHoaDon);
            if (DatabaseHelper.ExcuteSql(sqlCommand) > 0)
                return true;
            return false;
        }

        public static DataTable GetChiTietDichVu(int maTiecCuoi)
        {
            String sqlCommand = @"Select * from DICHVU INNER JOIN CT_PHIEUDATDICHVU ON DICHVU.MaDichVu = CT_PHIEUDATDICHVU.MaDichVu WHERE CT_PHIEUDATDICHVU.MaTiecCuoi = " + maTiecCuoi + "";
            return DatabaseHelper.GetData(sqlCommand);
        }


        public static DTO.DTO_PhieuDatBan GetPhieuDatBan(int maTiecCuoi)
        {
            DTO.DTO_PhieuDatBan phieuDatBan = null;
            String sqlCommand = String.Format(@"SELECT * FROM PHIEUDATBAN WHERE MaTiecCuoi = {0}", maTiecCuoi);
            DataTable dataTable = DatabaseHelper.GetData(sqlCommand);
            if (dataTable != null)
            {
                DataRow dataRow = dataTable.Rows[0];
                phieuDatBan = new DTO_PhieuDatBan();
                phieuDatBan.MaTiecCuoi = maTiecCuoi;
                phieuDatBan.MaPhieuDatBan = int.Parse(dataRow["MaPhieuDatBan"].ToString());
                phieuDatBan.SoBan = int.Parse(dataRow["SoBan"].ToString());
                phieuDatBan.SoBanDuTru = int.Parse(dataRow["SoBanDuTru"].ToString());
                phieuDatBan.GhiChu = dataRow["GhiChu"].ToString();
                phieuDatBan.DonGiaBan = decimal.Parse(dataRow["DonGiaBan"].ToString());

            }
            return phieuDatBan;
        }

        public static DataTable GetChiTietDatBan(int maPhieuDatBan)
        {
            String sqlCommand = String.Format(@"SELECT * FROM CT_PHIEUDATBAN INNER JOIN MONAN ON CT_PHIEUDATBAN.MaMonAn = MonAn.MaMonAn WHERE CT_PHIEUDATBAN.MaPhieuDatBan = {0}", maPhieuDatBan);
            return DatabaseHelper.GetData(sqlCommand);
        }

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
            DataTable dt = DatabaseHelper.GetData(@"SELECT DonGiaBanToiThieu FROM LoaiSanh WHERE MaLoaiSanh=(SELECT MaLoaiSanh FROM Sanh WHERE MaSanh='" + maSanh + "')");
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
