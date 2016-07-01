using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_DichVuNhaHang
    {
        public static DataTable GetDataDichVu()
        {
            return DAO_DichVuNhaHang.GetDataDichVu();
        }
        public static bool Insert(DTO_DichVu dichvu)
        {
            return DAO_DichVuNhaHang.Insert(dichvu);
        }
        public static bool Delete(DTO_DichVu dichvu)
        {
            return DAO_DichVuNhaHang.Delete(dichvu);
        }
        public static int DeleteRecordEffect(DTO_DichVu dichvu)
        {
            return DAO_DichVuNhaHang.DeleteRecordEffect(dichvu);
        }
        public static bool Update(DTO_DichVu dichvu)
        {
            return DAO_DichVuNhaHang.Update(dichvu);
        }
    }
}
