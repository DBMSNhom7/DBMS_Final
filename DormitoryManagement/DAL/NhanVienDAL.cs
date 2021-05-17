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
    public class NhanVienDAL
    {
        DataProvider db;

        public NhanVienDAL()
        {
            db = new DataProvider();
        }

        public DataTable layNhanVien_DGV()
        {
            return db.ExecuteQueryDataTable("spLayNhanVien_DGV", CommandType.StoredProcedure);
        }

        public DataTable layNhanVien_TheoMaNV(string maNV)
        {
            return db.ExecuteQueryDataTable("spLayNhanVien_TheoMaNV", CommandType.StoredProcedure,
                new SqlParameter("@maNV", maNV));
        }

        public DataTable layNhanVien_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLayNhanVien_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public DataTable layLoaiChucVu()
        {
            return db.ExecuteQueryDataTable("spLayLoaiChucVu", CommandType.StoredProcedure);
        }

        public bool xoaNhanVien_TheoMaNV(string maNV, ref string error)
        {
            return db.MyExecuteNonQuery("spXoaNhanVien_TheoMaNV", CommandType.StoredProcedure,
                ref error, new SqlParameter("@maNV", maNV));
        }

        public bool themNhanVien(string hoTen, string ngaySinh, string diaChi,
            string dienThoai, string tenToa, string maChucVu, string ngayBatDau,
            string ngayKetThuc, string ngayLap, string luongThang, ref string error)
        {
            return db.MyExecuteNonQuery("spThemNhanVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@hoTen", hoTen), new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@diaChi", diaChi), new SqlParameter("@dienThoai", dienThoai),
                new SqlParameter("@tenToa", tenToa), new SqlParameter("@maChucVu", maChucVu),
                new SqlParameter("@ngayBatDau", ngayBatDau), new SqlParameter("@ngayKetThuc", ngayKetThuc),
                new SqlParameter("@ngayLap", ngayLap), new SqlParameter("@luongThang", luongThang));
        }

        public bool suaNhanVien(string maNV, string hoTen, string ngaySinh, string diaChi,
            string dienThoai, string tenToa, string maChucVu, string ngayBatDau,
            string ngayKetThuc, string ngayLap, string luongThang, ref string error)
        {
            return db.MyExecuteNonQuery("spSuaNhanVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@maNV", maNV), new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@ngaySinh", ngaySinh), new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@dienThoai", dienThoai), new SqlParameter("@tenToa", tenToa),
                new SqlParameter("@maChucVu", maChucVu), new SqlParameter("@ngayBatDau", ngayBatDau),
                new SqlParameter("@ngayKetThuc", ngayKetThuc), new SqlParameter("@ngayLap", ngayLap),
                new SqlParameter("@luongThang", luongThang));
        }
    }
}
