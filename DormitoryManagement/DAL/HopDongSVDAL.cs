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
    public class HopDongSVDAL
    {
        DataProvider db;

        public HopDongSVDAL()
        {
            db = new DataProvider();
        }

        public DataTable layHDSV_TheoMaHD(string maHD)
        {
            return db.ExecuteQueryDataTable("spLayHDSV_TheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
    }
}
