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
    public class BUS_TraCuu
    {
        public static DataTable GetData(DTO_TraCuu key)
        {
            return DAO_TraCuu.GetData(key);
        }
        public static DataTable TraCuuTenChuRe(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuTenChuRe(key);
        }
        public static DataTable TraCuuTenCoDau(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuTenCoDau(key);
        }
        public static DataTable TraCuuNgay(DTO_TraCuu key)
        {
            return DAO_TraCuu.TraCuuNgay(key);
        }
    }
}
