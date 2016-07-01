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
        public static DataTable GetData()
        {
            string query = @"SELECT * FROM DichVu";
            return DatabaseHelper.GetData(query);
        }

        public static int Insert(DTO_DichVu dichVu)
        {
            string query = String.Format(@"INSERT INTO DichVu (MaDichVu, TenDichVu, DonGia, GhiChu) VALUES (N'{0}', N'{1}', {2}, N'{3}')",
                dichVu.MaDichVu,dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu);
            return DatabaseHelper.ExcuteSql(query);
        }
        public static int Update(DTO_DichVu dichVu)
        {
            string query = String.Format(@"UPDATE DichVu SET TenDichVu=N'{0}', DonGia={1}, GhiChu=N'{2}' WHERE MaDichVu='{3}'",
                dichVu.TenDichVu, dichVu.DonGia, dichVu.GhiChu, dichVu.MaDichVu);
            return DatabaseHelper.ExcuteSql(query);
        }
        public static int Delete(DTO_DichVu dichVu)
        {
            string query = String.Format(@"DELETE FROM DichVu WHERE MaDichVu=N'{0}'", dichVu.MaDichVu);
            return DatabaseHelper.ExcuteSql(query);
        }
    }
}