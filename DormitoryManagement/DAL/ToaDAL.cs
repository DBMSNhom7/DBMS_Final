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
    public class ToaDAL
    {
        DataProvider db;
        
        public ToaDAL()
        {
            db = new DataProvider();
        }

        public DataTable layToa()
        {
            return db.ExecuteQueryDataTable("spLayToa", CommandType.StoredProcedure);
        }

        public int layTongSoToa()
        {
            try
            {
                return (int)db.ExecuteScalar("spLayTongSoToa", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
