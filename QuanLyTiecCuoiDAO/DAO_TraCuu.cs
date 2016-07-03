using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_TraCuu
    {
        public static DataTable GetData(DTO_TraCuu key)
        {
            //            string query = String.Format(@"SELECT TenChuRe AS 'Tên chú rể', TenCoDau AS 'Tên cô dâu', TenSanh AS 'Sảnh', Ngay AS 'Ngày', TenCa AS 'Ca', SoLuongBan AS 'Số lượng bàn' 
            //FROM ((HoaDonTiecCuoi INNER JOIN KhachHang ON HoaDonTiecCuoi.MaKH = KhachHang.MaKH)
            // INNER JOIN Ca ON HoaDonTiecCuoi.MaCa = Ca.MaCa) INNER JOIN Sanh ON HoaDonTiecCuoi.MaSanh = Sanh.MaSanh");
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh)
 INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi)");
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuTenChuRe(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh)
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE TIECCUOI.TenChuRe = N'{0}'", key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuTenCoDau(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh)
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE TenCoDau = N'{0}'", key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuNgay(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TIECCUOI.TenChuRe AS 'Tên chú rể', TIECCUOI.TenCoDau AS 'Tên cô dâu', SANH.TenSanh AS 'Sảnh', TIECCUOI.NgayDaiTiec AS 'Ngày đãi tiệc', CA.TenCa AS 'Ca', PHIEUDATBAN.SoBan AS 'Số bàn' 
FROM (((TIECCUOI INNER JOIN SANH ON TIECCUOI.MaSanh = SANH.MaSanh)
    INNER JOIN Ca ON TIECCUOI.MaCa = CA.MaCa) 
    INNER JOIN PHIEUDATBAN ON TIECCUOI.MaTiecCuoi = PHIEUDATBAN.MaTiecCuoi) 
WHERE Ngay = '{0}'", key);
            return DatabaseHelper.GetData(query);
        }
    }
}