using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
   public class BUS_ThamSo
    {
     
       public static bool IsLoaded = false;
       public static DataTable ThamSoTable;
       public static DataTable GetAllThamSo()
       {
           //DataTable dataTable = DAO.DAO_ThamSo.GetAllThamSo();
           //if (dataTable != null)
           //{
           //    ThamSos.Add(new DTO_ThamSo(dataTable.Columns[COLUMN_TENQUYDINH], float.Parse(dataTable.Columns[COLUMN_GIATRI])));
           //}
           //IsLoaded = true;
           if (!IsLoaded)
           {
               ThamSoTable = DAO.DAO_ThamSo.GetAllThamSo();
               IsLoaded = true;
           }
          


           return ThamSoTable;
       }

       public static bool InsertThamSo(DTO_ThamSo thamSo)
       {
           IsLoaded = false;
           return DAO.DAO_ThamSo.InsertThamSo(thamSo);


       }

       public static bool UpdateThamSo(DTO_ThamSo thamSo)
       {
           return false;
       }
    }
}
