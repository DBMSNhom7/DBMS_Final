using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL _nhanVienDAL;

        public NhanVienBLL()
        {
            _nhanVienDAL = new NhanVienDAL();
        }

        public DataTable layNhanVien_DGV()
        {
            return _nhanVienDAL.layNhanVien_DGV();
        }

        public NhanVienDTO layNhanVien_TheoMaNV(string maNV)
        {
            DataTable dt = _nhanVienDAL.layNhanVien_TheoMaNV(maNV);
            return new NhanVienDTO(dt.Rows[0]);
        }

        public DataTable layNhanVien_TimKiem_DGV(string str)
        {
            return _nhanVienDAL.layNhanVien_TimKiem_DGV(str);
        }

        public DataTable layLoaiChucVu()
        {
            return _nhanVienDAL.layLoaiChucVu();
        }

        public bool xoaNhanVien_TheoMaNV(string maNV, ref string error)
        {
            return _nhanVienDAL.xoaNhanVien_TheoMaNV(maNV, ref error);
        }

        public bool themNhanVien(NhanVienDTO nv, HopDongNVDTO hd, ref string error)
        {
            return _nhanVienDAL.themNhanVien(nv.HoTen, nv.NgaySinh, nv.DiaChi,
            nv.DienThoai, nv.TenToa, nv.MaChucVu, hd.NgayBatDau,
            hd.NgayKetThuc, hd.NgayLap, hd.LuongThang, ref error);
        }

        public bool suaNhanVien(NhanVienDTO nv, HopDongNVDTO hd, ref string error)
        {
            return _nhanVienDAL.suaNhanVien(nv.MaNV, nv.HoTen, nv.NgaySinh,
            nv.DiaChi, nv.DienThoai, nv.TenToa, nv.MaChucVu,
            hd.NgayBatDau, hd.NgayKetThuc, hd.NgayLap, hd.LuongThang, ref error);
        }
    }
}
