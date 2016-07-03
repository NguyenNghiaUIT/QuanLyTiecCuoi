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
        public static DTO_ThamSo ThamSo;
        public static DTO_ThamSo GetAllThamSo()
        {
            //DataTable dataTable = DAO.DAO_ThamSo.GetAllThamSo();
            //if (dataTable != null)
            //{
            //    ThamSos.Add(new DTO_ThamSo(dataTable.Columns[COLUMN_TENQUYDINH], float.Parse(dataTable.Columns[COLUMN_GIATRI])));
            //}
            //IsLoaded = true;
            if (!IsLoaded)
            {
                DataTable dataTable = DAO.DAO_ThamSo.GetAllThamSo();
                if (dataTable != null)
                {
                    if (ThamSo == null)
                        ThamSo = new DTO_ThamSo();
                    try
                    {
                        //ThamSo.TenQuyDinh = dataTable.Rows[0].ClColumns[0].ToString();
                        //ThamSo.GiaTri = float.Parse(dataTable.Rows[0].Columns[1].ToString());
                        DataRow row = dataTable.Rows[0];
                        ThamSo.TenQuyDinh = row.ItemArray[0].ToString();
                        ThamSo.GiaTri = float.Parse(row.ItemArray[1].ToString());

                        IsLoaded = true;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                   
                }

            }

            return ThamSo;
        }

        public static bool InsertThamSo(DTO_ThamSo thamSo)
        {
            IsLoaded = false;
            return DAO.DAO_ThamSo.InsertThamSo(thamSo);


        }

        public static bool UpdateThamSo(DTO_ThamSo thamSo)
        {
            IsLoaded = false;
            return DAO.DAO_ThamSo.UpdateThamSo(thamSo);
        }
    }
}
