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
    public class SinhVienDAL
    {
        DataProvider db;

        public SinhVienDAL()
        {
            db = new DataProvider();
        }

        public DataTable laySinhVien_DGV()
        {
            return db.ExecuteQueryDataTable("spLaySinhVien_DGV", CommandType.StoredProcedure);
        }

        public DataTable laySinhVien_TheoPhong_DGV(string maPhong)
        {
            return db.ExecuteQueryDataTable("spLaySinhVien_TheoPhong_DGV", CommandType.StoredProcedure,
                new SqlParameter("@maPhong", maPhong));
        }

        public DataTable laySinhVien_TheoMaSV(string maSV)
        {
            return db.ExecuteQueryDataTable("spLaySinhVien_TheoMaSV", CommandType.StoredProcedure,
                new SqlParameter("@maSV", maSV));
        }

        public DataTable laySinhVien_TimKiem_DGV(string str)
        {
            return db.ExecuteQueryDataTable("spLaySinhVien_TimKiem_DGV", CommandType.StoredProcedure,
                new SqlParameter("@str", str));
        }

        public bool xoaSinhVien_TheoMaSV(string maSV, ref string error)
        {
            return db.MyExecuteNonQuery("spXoaSinhVien_TheoMaSV", CommandType.StoredProcedure,
                ref error, new SqlParameter("@maSV", maSV));
        }

        public bool themSinhVien(string maSV, string CMND, string hoTen, string gioiTinh,
            string ngaySinh, string diaChi, string dienThoai, string CMND_TN, string hoTen_TN,
            string gioiTinh_TN, string quanHeSV, string diaChi_TN, string dienThoai_TN,
            string maPhong, string ngayBatDau, string ngayKetThuc, string ngayLap, string thanhTien,
            ref string error)
        {
            return db.MyExecuteNonQuery("spThemSinhVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@maSV", maSV), new SqlParameter("@CMND", CMND),
                new SqlParameter("@hoTen", hoTen), new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh), new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@dienThoai", dienThoai), new SqlParameter("@CMND_TN", CMND_TN),
                new SqlParameter("@hoTen_TN", hoTen_TN), new SqlParameter("@gioiTinh_TN", gioiTinh_TN),
                new SqlParameter("@quanHeSV", quanHeSV), new SqlParameter("@diaChi_TN", diaChi_TN),
                new SqlParameter("@dienThoai_TN", dienThoai_TN), new SqlParameter("@maPhong", maPhong),
                new SqlParameter("@ngayBatDau", ngayBatDau), new SqlParameter("@ngayKetThuc", ngayKetThuc),
                new SqlParameter("@ngayLap", ngayLap), new SqlParameter("@thanhTien", thanhTien));
        }

        public bool suaSinhVien(string maSV, string CMND, string hoTen, string gioiTinh,
            string ngaySinh, string diaChi, string dienThoai, string CMND_TN, string hoTen_TN,
            string gioiTinh_TN, string quanHeSV, string diaChi_TN, string dienThoai_TN,
            string maPhong, string ngayBatDau, string ngayKetThuc, string ngayLap, string thanhTien,
            ref string error)
        {
            return db.MyExecuteNonQuery("spSuaSinhVien", CommandType.StoredProcedure, ref error,
                new SqlParameter("@maSV", maSV), new SqlParameter("@CMND", CMND),
                new SqlParameter("@hoTen", hoTen), new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh), new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@dienThoai", dienThoai), new SqlParameter("@CMND_TN", CMND_TN),
                new SqlParameter("@hoTen_TN", hoTen_TN), new SqlParameter("@gioiTinh_TN", gioiTinh_TN),
                new SqlParameter("@quanHeSV", quanHeSV), new SqlParameter("@diaChi_TN", diaChi_TN),
                new SqlParameter("@dienThoai_TN", dienThoai_TN), new SqlParameter("@maPhong", maPhong),
                new SqlParameter("@ngayBatDau", ngayBatDau), new SqlParameter("@ngayKetThuc", ngayKetThuc),
                new SqlParameter("@ngayLap", ngayLap), new SqlParameter("@thanhTien", thanhTien));
        }

        public int layTongSoSinhVien()
        {
            try
            {
                return (int)db.ExecuteScalar("spLayTongSoSinhVien", CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}