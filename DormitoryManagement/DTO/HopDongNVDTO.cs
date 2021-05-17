using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HopDongNVDTO
    {
        private string _maHD;
        private string _ngayBatDau;
        private string _ngayKetThuc;
        private string _ngayLap;
        private string _luongThang;

        public HopDongNVDTO() { }

        public HopDongNVDTO(string maHD, string ngayBatDau,
            string ngayKetThuc, string ngayLap, string luongThang)
        {
            this.MaHD = maHD;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.NgayLap = ngayLap;
            this.LuongThang = luongThang;
        }

        public HopDongNVDTO(DataRow dr)
        {
            this.MaHD = dr["MaHD"].ToString();
            this.NgayBatDau = dr["NgayBatDau"].ToString();
            this.NgayKetThuc = dr["NgayKetThuc"].ToString();
            this.NgayLap = dr["NgayLap"].ToString();
            this.LuongThang = dr["LuongThang"].ToString();
        }

        public string MaHD { get => _maHD; set => _maHD = value; }
        public string NgayBatDau { get => _ngayBatDau; set => _ngayBatDau = value; }
        public string NgayKetThuc { get => _ngayKetThuc; set => _ngayKetThuc = value; }
        public string NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public string LuongThang { get => _luongThang; set => _luongThang = value; }
    }
}
