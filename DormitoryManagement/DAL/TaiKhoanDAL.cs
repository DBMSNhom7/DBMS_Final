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

        public DataTable layTaiKhoan_DGV()
        {
            return db.ExecuteQueryDataTable("spLayTaiKhoan_DGV", CommandType.StoredProcedure);
        }

        public DataTable layLoaiTK()
        {
            return db.ExecuteQueryDataTable("spLayLoaiTK", CommandType.StoredProcedure);
        }

        public bool themTaiKhoan(string tenTK, string matKhau,
            string IDLoaiQuyen, ref string error)
        {
            return db.MyExecuteNonQuery("spThemTaiKhoan", CommandType.StoredProcedure, ref error,
                new SqlParameter("@tenTK", tenTK), new SqlParameter("@matKhau", matKhau),
                new SqlParameter("@IDLoaiQuyen", IDLoaiQuyen));
        }

        public bool xoaTaiKhoan_TheoTenTK(string tenTK, ref string error)
        {
            return db.MyExecuteNonQuery("spXoaTaiKhoan_TheoTenTK", CommandType.StoredProcedure, ref error,
                new SqlParameter("@tenTK", tenTK));
        }

        public DataTable layTaiKhoan_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLayTaiKhoan_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public bool suaTaiKhoan_TheoTenTK(string tenTK, string matKhau,
            string IDLoaiQuyen, ref string error)
        {
            return db.MyExecuteNonQuery("spSuaTaiKhoan_TheoTenTK", CommandType.StoredProcedure, ref error,
                new SqlParameter("@tenTK", tenTK), new SqlParameter("@matKhau", matKhau),
                new SqlParameter("@IDLoaiQuyen", IDLoaiQuyen));
        }
    }
}
