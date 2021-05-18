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
    public class PhongDAL
    {
        DataProvider db;

        public PhongDAL()
        {
            db = new DataProvider();
        }

        public DataTable layPhong_DGV()
        {
            return db.ExecuteQueryDataTable("spLayPhong_DGV", CommandType.StoredProcedure);
        }

        public DataTable layPhong_TheoMaPhong(string maPhong)
        {
            return db.ExecuteQueryDataTable("spLayPhong_TheoMaPhong", CommandType.StoredProcedure,
                new SqlParameter("@maPhong", maPhong));
        }

        public DataTable layPhong_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLayPhong_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public DataTable layPhong_TheoToa(string tenToa)
        {
            return db.ExecuteQueryDataTable("spLayPhong_TheoToa", CommandType.StoredProcedure,
                new SqlParameter("@tenToa", tenToa));
        }

        public DataTable layLoaiPhong()
        {
            return db.ExecuteQueryDataTable("spLayLoaiPhong", CommandType.StoredProcedure);
        }

        public bool suaPhong(string maPhong, string maLoai, string sucChua, ref string error)
        {
            return db.MyExecuteNonQuery("spSuaPhong", CommandType.StoredProcedure, ref error,
                new SqlParameter("@maPhong", maPhong), new SqlParameter("@maLoai", maLoai),
                new SqlParameter("@sucChua", sucChua));
        }

        public int layTongSoPhong()
        {
            try
            {
                return (int)db.ExecuteScalar("spLayTongSoPhong", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int laySoPhongConTrong()
        {
            try
            {
                return (int)db.ExecuteScalar("spLaySoPhongConTrong", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int layTongSucChua()
        {
            try
            {
                return (int)db.ExecuteScalar("spLayTongSucChua", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
