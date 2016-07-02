using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_MonAn
    {
        public static DataTable GetDataTableMonAn()
        {
            string query = @"SELECT * FROM MonAn";
            return DatabaseHelper.GetData(query);
        }

        public static int InsertMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"INSERT INTO MonAn (TenMonAn, DonGia, GhiChu) VALUES (N'{0}', {1}, N'{2}')",
                monAn.TenMonAn, monAn.DonGia, monAn.GhiChu);
            return DatabaseHelper.ExcuteSql(query);
        }
        public static int UpdateMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"UPDATE MonAn SET TenMonAn=N'{0}', DonGia={1}, GhiChu=N'{2}' WHERE MaMonAn={3}",
                monAn.TenMonAn, monAn.DonGia, monAn.GhiChu, monAn.MaMonAn);
            return DatabaseHelper.ExcuteSql(query);
        }
        public static int DeleteMonAn(DTO_MonAn monAn)
        {
            string query = String.Format(@"DELETE FROM MonAn WHERE MaMonAn={0}", monAn.MaMonAn);
            return DatabaseHelper.ExcuteSql(query);
        }
    }
}
