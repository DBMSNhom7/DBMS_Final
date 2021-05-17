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
    public class ThanNhanDAL
    {
        DataProvider db;

        public ThanNhanDAL()
        {
            db = new DataProvider();
        }

        public DataTable layThanNhan_TheoCMNDTN(string CMND_TN)
        {
            return db.ExecuteQueryDataTable("spLayThanNhan_TheoCMNDTN", CommandType.StoredProcedure,
                new SqlParameter("@CMNDTN", CMND_TN));
        }
    }
}
