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
    public class SinhVienBLL
    {
        private SinhVienDAL _sinhVienDAL;

        public SinhVienBLL()
        {
            _sinhVienDAL = new SinhVienDAL();
        }

        public DataTable laySinhVien_DGV()
        {
            return _sinhVienDAL.laySinhVien_DGV();
        }

        public DataTable laySinhVien_TheoPhong_DGV(string maPhong)
        {
            return _sinhVienDAL.laySinhVien_TheoPhong_DGV(maPhong);
        }

        public SinhVienDTO laySinhVien_TheoMaSV(string maSV)
        {
            DataTable dt = _sinhVienDAL.laySinhVien_TheoMaSV(maSV);
            return new SinhVienDTO(dt.Rows[0]);
        }

        public DataTable laySinhVien_TimKiem_DGV(string str)
        {
            return _sinhVienDAL.laySinhVien_TimKiem_DGV(str);
        }

        public bool xoaSinhVien_TheoMaSV(string maSV, ref string error)
        {
            return _sinhVienDAL.xoaSinhVien_TheoMaSV(maSV, ref error);
        }

        public bool themSinhVien(SinhVienDTO sv, ThanNhanDTO tn,
            HopDongSVDTO hd, ref string error)
        {
            return _sinhVienDAL.themSinhVien(sv.MaSV, sv.CMND, sv.HoTen, sv.GioiTinh,
                sv.NgaySinh, sv.DiaChi, sv.DienThoai, tn.CMND, tn.HoTen, tn.GioiTinh,
                tn.QuanHeVoiSV, tn.DiaChi, tn.DienThoai, sv.MaPhong, hd.NgayBatDau,
                hd.NgayKetThuc, hd.NgayLap, hd.ThanhTien, ref error);
        }

        public bool suaSinhVien(SinhVienDTO sv, ThanNhanDTO tn,
            HopDongSVDTO hd, ref string error)
        {
            return _sinhVienDAL.suaSinhVien(sv.MaSV, sv.CMND, sv.HoTen, sv.GioiTinh,
                sv.NgaySinh, sv.DiaChi, sv.DienThoai, tn.CMND, tn.HoTen, tn.GioiTinh,
                tn.QuanHeVoiSV, tn.DiaChi, tn.DienThoai, sv.MaPhong, hd.NgayBatDau,
                hd.NgayKetThuc, hd.NgayLap, hd.ThanhTien, ref error);
        }

        public int layTongSoSinhVien()
        {
            return _sinhVienDAL.layTongSoSinhVien();
        }
    }
}