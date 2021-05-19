using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDonDienNuocDTO
    {
        private string _maHoaDon;
        private string _soDien;
        private string _soNuoc;
        private string _thanhTien;
        private string _ngayLap;
        private string _trangThai;
        private string _maPhong;

        public HoaDonDienNuocDTO() { }

        public HoaDonDienNuocDTO(string maHoaDon, string soDien, string soNuoc,
            string thanhTien, string ngayLap, string trangThai, string maPhong)
        {
            this.MaHoaDon = maHoaDon;
            this.SoDien = soDien;
            this.SoNuoc = soNuoc;
            this.ThanhTien = thanhTien;
            this.NgayLap = ngayLap;
            this.TrangThai = trangThai;
            this.MaPhong = maPhong;
        }

        public HoaDonDienNuocDTO(DataRow dr)
        {
            this.MaHoaDon = dr["MaHoaDon"].ToString();
            this.SoDien = dr["SoDien"].ToString();
            this.SoNuoc = dr["SoNuoc"].ToString();
            this.ThanhTien = dr["ThanhTien"].ToString();
            this.NgayLap = DateTime.Parse(dr["NgayLap"].ToString()).ToString("yyyy-MM-dd");
            this.TrangThai = dr["TrangThai"].ToString();
            this.MaPhong = dr["MaPhong"].ToString();
        }

        public string MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
        public string SoDien { get => _soDien; set => _soDien = value; }
        public string SoNuoc { get => _soNuoc; set => _soNuoc = value; }
        public string ThanhTien { get => _thanhTien; set => _thanhTien = value; }
        public string NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public string TrangThai { get => _trangThai; set => _trangThai = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
