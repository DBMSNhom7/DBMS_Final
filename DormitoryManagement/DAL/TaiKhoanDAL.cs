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
    public class TaiKhoanDAL
    {
        DataProvider db;

        public TaiKhoanDAL()
        {
            db = new DataProvider();
        }

        public bool dangNhap(string taiKhoan, string matKhau)
        {
            DataTable dt = db.ExecuteQueryDataTable("spLayTaiKhoan_TheoTKMK", CommandType.StoredProcedure,
                new SqlParameter("@taiKhoan", taiKhoan), new SqlParameter("@matKhau", matKhau));
            return dt.Rows.Count > 0;
        }

        public DataTable layTaiKhoan_TheoTenTK(string taiKhoan)
        {
            return db.ExecuteQueryDataTable("spLayTaiKhoan_TheoTenTK", CommandType.StoredProcedure,
                new SqlParameter("@taiKhoan", taiKhoan));
        }
    }
}
