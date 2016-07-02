using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class DAO_DichVuNhaHang
    {
        public static DataTable GetDataDichVu()
        {
            string sTruyVan = @"Select * from DichVu";
            return DatabaseHelper.GetData(sTruyVan);
        }

        public static bool Insert(DTO_DichVu dichvu)
        {
            string sTruyVan = string.Format(@"Insert into DichVu(TenDichVu,DonGia,GhiChu,HinhAnh) values(N'{0}',{1},N'{2}',N'{3}')",dichvu.TenDichVu, dichvu.DonGia, dichvu.GhiChu, dichvu.HinhAnh);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static bool Delete(DTO_DichVu dichvu)
        {
            string sTruyVan = string.Format(@"Delete DichVu where MaDichVu={0}", dichvu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public static int DeleteRecordEffect(DTO_DichVu dichvu)
        {
            string sTruyVan = string.Format(@"Select MaDichVu from dichvu where HinhAnh=N'{0}'", dichvu.HinhAnh);
            return DatabaseHelper.GetData(sTruyVan).Rows.Count;
        }
        public static bool Update(DTO_DichVu dichvu)
        {
            string sTruyVan = string.Format("Update DichVu set TenDichVu=N'{0}', DonGia='{1}', GhiChu=N'{2}', HinhAnh = N'{3}' where MaDichVu='{4}'", dichvu.TenDichVu, dichvu.DonGia, dichvu.GhiChu, dichvu.HinhAnh, dichvu.MaDichVu);
            try
            {
                int state = DatabaseHelper.ExcuteSql(sTruyVan);
                if (state > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
