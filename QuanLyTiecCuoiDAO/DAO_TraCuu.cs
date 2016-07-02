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
            string query = String.Format(@"SELECT TenChuRe AS 'Tên chú rể', TenCoDau AS 'Tên cô dâu', TenSanh AS 'Sảnh', Ngay AS 'Ngày', TenCa AS 'Ca', SoLuongBan AS 'Số lượng bàn' 
FROM ((HoaDonTiecCuoi INNER JOIN KhachHang ON HoaDonTiecCuoi.MaKH = KhachHang.MaKH)
 INNER JOIN Ca ON HoaDonTiecCuoi.MaCa = Ca.MaCa) INNER JOIN Sanh ON HoaDonTiecCuoi.MaSanh = Sanh.MaSanh");
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuTenChuRe(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TenChuRe AS 'Tên chú rể', TenCoDau AS 'Tên cô dâu', TenSanh AS 'Sảnh', Ngay AS 'Ngày', TenCa AS 'Ca', SoLuongBan AS 'Số lượng bàn' 
FROM ((HoaDonTiecCuoi INNER JOIN KhachHang ON HoaDonTiecCuoi.MaKH =KhachHang.MaKH)
 INNER JOIN Ca ON HoaDonTiecCuoi.MaCa = Ca.MaCa) INNER JOIN Sanh ON HoaDonTiecCuoi.MaSanh = Sanh.MaSanh 
WHERE TenChuRe = N'{0}'", key.key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuTenCoDau(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TenChuRe AS 'Tên chú rể', TenCoDau AS 'Tên cô dâu', TenSanh AS 'Sảnh', Ngay AS 'Ngày', TenCa AS 'Ca', SoLuongBan AS 'Số lượng bàn' 
FROM ((HoaDonTiecCuoi INNER JOIN KhachHang ON HoaDonTiecCuoi.MaKH =KhachHang.MaKH)
 INNER JOIN Ca ON HoaDonTiecCuoi.MaCa = Ca.MaCa) INNER JOIN Sanh ON HoaDonTiecCuoi.MaSanh = Sanh.MaSanh 
WHERE TenCoDau = N'{0}'", key.key);
            return DatabaseHelper.GetData(query);
        }
        public static DataTable TraCuuNgay(DTO_TraCuu key)
        {
            string query = String.Format(@"SELECT TenChuRe AS 'Tên chú rể', TenCoDau AS 'Tên cô dâu', TenSanh AS 'Sảnh', Ngay AS 'Ngày', TenCa AS 'Ca', SoLuongBan AS 'Số lượng bàn' 
FROM ((HoaDonTiecCuoi INNER JOIN KhachHang ON HoaDonTiecCuoi.MaKH =KhachHang.MaKH)
 INNER JOIN Ca ON HoaDonTiecCuoi.MaCa = Ca.MaCa) INNER JOIN Sanh ON HoaDonTiecCuoi.MaSanh = Sanh.MaSanh 
WHERE Ngay = '{0}'", key.key);
            return DatabaseHelper.GetData(query);
        }
    }
}
