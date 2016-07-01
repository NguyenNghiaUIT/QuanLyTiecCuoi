using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuanLyLoaiSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LoaiSanh";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static void InsertLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"INSERT INTO LoaiSanh (MaLoaiSanh,DonGiaBanToiThieu) VALUES ('{0}',{1})", loaiSanh.maLoaiSanh, loaiSanh.donGiaBanToiThieu);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static void UpdateLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"UPDATE LoaiSanh SET DonGiaBanToiThieu={0} WHERE MaLoaiSanh='{1}'", loaiSanh.donGiaBanToiThieu, loaiSanh.maLoaiSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static void DeleteLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"DELETE FROM LoaiSanh WHERE MaLoaiSanh='{0}'", loaiSanh.maLoaiSanh);
            DatabaseHelper.ExcuteSql(sqlCommand);
        }
        public static int NumbersOfMaLoaiSanhInSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"SELECT COUNT(*) FROM Sanh WHERE MaLoaiSanh='{0}'", loaiSanh.maLoaiSanh);
            return DatabaseHelper.CountRecord(sqlCommand);
        }
        public static int NumbersOfMaLoaiSanhInLoaiSanh(DTO_LoaiSanh loaiSanh)
        {
            string sqlCommand = string.Format(@"SELECT COUNT(*) FROM LoaiSanh WHERE MaLoaiSanh='{0}'", loaiSanh.maLoaiSanh);
            return DatabaseHelper.CountRecord(sqlCommand);
        }
    }
}
