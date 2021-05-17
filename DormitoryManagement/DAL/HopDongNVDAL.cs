using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class HopDongNVDAL
    {
        DataProvider db;

        public HopDongNVDAL()
        {
            db = new DataProvider();
        }

        public DataTable layHDNV_TheoMaHD(string maHD)
        {
            return db.ExecuteQueryDataTable("spLayHDNV_TheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
    }
}
