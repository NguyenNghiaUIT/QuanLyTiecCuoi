using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DichVu
    {
        public static DataTable GetData()
        {
            return DAO_DichVu.GetData();
        }
        public static int Insert(DTO_DichVu dichVu)
        {
            return DAO_DichVu.Insert(dichVu);
        }
        public static int Update(DTO_DichVu dichVu)
        {
            return DAO_DichVu.Update(dichVu);
        }
        public static int Delete(DTO_DichVu dichVu)
        {
            return DAO_DichVu.Delete(dichVu);
        }
    }
}
