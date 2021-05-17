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
    public class HoaDonDienNuocBLL
    {
        private HoaDonDienNuocDAL _hoaDonDienNuocDAL;

        public HoaDonDienNuocBLL()
        {
            _hoaDonDienNuocDAL = new HoaDonDienNuocDAL();
        }

        public DataTable layHoaDonDienNuoc_DGV()
        {
            return _hoaDonDienNuocDAL.layHoaDonDienNuoc_DGV();
        }

        public DataTable layHoaDonDienNuoc_TheoPhong_DGV(string maPhong)
        {
            return _hoaDonDienNuocDAL.layHoaDonDienNuoc_TheoPhong_DGV(maPhong);
        }

        public HoaDonDienNuocDTO layHoaDonDienNuoc_TheoMaHoaDon(string maHoaDon)
        {
            DataTable dt = _hoaDonDienNuocDAL.layHoaDonDienNuoc_TheoMaHoaDon(maHoaDon);
            return new HoaDonDienNuocDTO(dt.Rows[0]);
        }

        public DataTable layHoaDonDienNuoc_TimKiem_DGV(string str)
        {
            return _hoaDonDienNuocDAL.layHoaDonDienNuoc_TimKiem_DGV(str);
        }

        public bool xoaHoaDonDienNuoc_TheoMaHoaDon(string maHoaDon, ref string error)
        {
            return _hoaDonDienNuocDAL.xoaHoaDonDienNuoc_TheoMaHoaDon(maHoaDon, ref error);
        }

        public bool themHoaDonDienNuoc(HoaDonDienNuocDTO hd, ref string error)
        {
            return _hoaDonDienNuocDAL.themHoaDonDienNuoc(hd.SoDien, hd.SoNuoc, hd.ThanhTien,
                hd.NgayLap, hd.TrangThai, hd.MaPhong, ref error);
        }

        public bool suaHoaDonDienNuoc(HoaDonDienNuocDTO hd, ref string error)
        {
            return _hoaDonDienNuocDAL.suaHoaDonDienNuoc(hd.MaHoaDon, hd.TrangThai,
                ref error);
        }
    }
}
