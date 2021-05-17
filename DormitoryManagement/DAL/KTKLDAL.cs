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
    public class KTKLDAL
    {
        DataProvider db;

        public KTKLDAL()
        {
            db = new DataProvider();
        }

        public DataTable layKTKL_DGV()
        {
            return db.ExecuteQueryDataTable("spLayKTKL_DGV", CommandType.StoredProcedure);
        }

        public DataTable layKTKL_TheoMaSV_DGV(string maSV)
        {
            return db.ExecuteQueryDataTable("spLayKTKL_TheoMaSV_DGV", CommandType.StoredProcedure,
                new SqlParameter("@maSV", maSV));
        }

        public DataTable layKTKL_TheoMaKTKL(string maKTKL)
        {
            return db.ExecuteQueryDataTable("spLayKTKL_TheoMaKTKL", CommandType.StoredProcedure,
                new SqlParameter("@maKTKL", maKTKL));
        }

        public DataTable layKTKL_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLayKTKL_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public bool xoaKTKL_TheoMaKTKL(string maKTKL, ref string error)
        {
            return db.MyExecuteNonQuery("spXoaKTKL_TheoMaKTKL", CommandType.StoredProcedure,
                ref error, new SqlParameter("@maKTKL", maKTKL));
        }

        public bool themKTKL(string hinhThuc, string moTa, string ngayTao, string maSV,
            ref string error)
        {
            return db.MyExecuteNonQuery("spThemKTKL", CommandType.StoredProcedure, ref error,
                new SqlParameter("@hinhThuc", hinhThuc), new SqlParameter("@moTa", moTa),
                new SqlParameter("@ngayTao", ngayTao), new SqlParameter("@maSV", maSV));
        }
    }
}