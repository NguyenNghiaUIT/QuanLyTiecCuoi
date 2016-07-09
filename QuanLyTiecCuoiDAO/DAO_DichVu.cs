using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_DichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            string query = @"SELECT * FROM DICHVU";
            return DatabaseHelper.GetData(query);
        }

        public static bool InsertDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"INSERT INTO DICHVU (TenDichVu, DonGia, GhiChu, HinhAnh) VALUES (N'{0}', {1}, N'{2}', N'{3}')",
                dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu, dichVu.HinhAnh);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool UpdateDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"UPDATE DICHVU SET TenDichVu=N'{0}', DonGia={1}, GhiChu=N'{2}', HinhAnh=N'{3}' WHERE MaDichVu={4}",
               dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu, dichVu.HinhAnh, dichVu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool DeleteDichVu(DTO_DichVu dichVu)
        {
            string query = String.Format(@"DELETE FROM DICHVU WHERE MaDichVu={0}", dichVu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(query);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static int LastIndex()
        {
            string query = string.Format(@"SELECT TOP 1 MaDichVu FROM DICHVU ORDER BY MaDichVu DESC");
            return (int)DatabaseHelper.GetData(query).Rows[0].ItemArray[0];
        }
    }
}