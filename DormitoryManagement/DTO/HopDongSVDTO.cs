using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HopDongSVDTO
    {
        private string _maHD;
        private string _ngayBatDau;
        private string _ngayKetThuc;
        private string _ngayLap;
        private string _thanhTien;

        public HopDongSVDTO() { }

        public HopDongSVDTO(string maHD, string ngayBatDau, string ngayKetThuc,
            string ngayLap, string thanhTien, string maSV)
        {
            this.MaHD = maHD;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.NgayLap = ngayLap;
            this.ThanhTien = thanhTien;
        }

        public HopDongSVDTO(DataRow dr)
        {
            this.MaHD = dr["MaHD"].ToString();
            this.NgayBatDau = DateTime.Parse(dr["NgayBatDau"].ToString()).ToString("yyyy-MM-dd");
            this.NgayKetThuc = DateTime.Parse(dr["NgayKetThuc"].ToString()).ToString("yyyy-MM-dd");
            this.NgayLap = DateTime.Parse(dr["NgayLap"].ToString()).ToString("yyyy-MM-dd");
            this.ThanhTien = dr["ThanhTien"].ToString();
        }

        public string MaHD { get => _maHD; set => _maHD = value; }
        public string NgayBatDau { get => _ngayBatDau; set => _ngayBatDau = value; }
        public string NgayKetThuc { get => _ngayKetThuc; set => _ngayKetThuc = value; }
        public string NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public string ThanhTien { get => _thanhTien; set => _thanhTien = value; }
    }
}
