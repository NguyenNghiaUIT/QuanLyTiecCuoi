using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_NhanDatTiecCuoi
    {
        public static DataTable GetSanh()
        {
            return DAO_NhanDatTiecCuoi.GetSanh();
        }
        public static DataTable GetCa()
        {
            return DAO_NhanDatTiecCuoi.GetCa();
        }
    }
}
