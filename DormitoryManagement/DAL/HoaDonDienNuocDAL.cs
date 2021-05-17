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
    public class HoaDonDienNuocDAL
    {
        DataProvider db;

        public HoaDonDienNuocDAL()
        {
            db = new DataProvider();
        }

        public DataTable layHoaDonDienNuoc_DGV()
        {
            return db.ExecuteQueryDataTable("spLayHoaDonDienNuoc_DGV", CommandType.StoredProcedure);
        }

        public DataTable layHoaDonDienNuoc_TheoPhong_DGV(string maPhong)
        {
            return db.ExecuteQueryDataTable("spLayHoaDonDienNuoc_TheoPhong_DGV", CommandType.StoredProcedure,
                new SqlParameter("@maPhong", maPhong));
        }

        public DataTable layHoaDonDienNuoc_TheoMaHoaDon(string maHoaDon)
        {
            return db.ExecuteQueryDataTable("spLayHoaDonDienNuoc_TheoMaHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@maHoaDon", maHoaDon));
        }

        public DataTable layHoaDonDienNuoc_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLayHoaDonDienNuoc_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public bool xoaHoaDonDienNuoc_TheoMaHoaDon(string maHoaDon, ref string error)
        {
            return db.MyExecuteNonQuery("spXoaHoaDonDienNuoc_TheoMaHoaDon", CommandType.StoredProcedure,
                ref error, new SqlParameter("@maHoaDon", maHoaDon));
        }

        public bool themHoaDonDienNuoc(string soDien, string soNuoc, string thanhTien,
            string ngayLap, string trangThai, string maPhong, ref string error)
        {
            return db.MyExecuteNonQuery("spThemHoaDonDienNuoc", CommandType.StoredProcedure, ref error,
                new SqlParameter("@soDien", soDien), new SqlParameter("@soNuoc", soNuoc),
                new SqlParameter("@thanhTien", thanhTien), new SqlParameter("@ngayLap", ngayLap),
                new SqlParameter("@trangthai", trangThai), new SqlParameter("@maPhong", maPhong));
        }

        public bool suaHoaDonDienNuoc(string maHoaDon, string trangThai,
            ref string error)
        {
            return db.MyExecuteNonQuery("spSuaHoaDonDienNuoc", CommandType.StoredProcedure, ref error,
                new SqlParameter("@maHoaDon", maHoaDon), new SqlParameter("@trangThai", trangThai));
        }
    }
}
