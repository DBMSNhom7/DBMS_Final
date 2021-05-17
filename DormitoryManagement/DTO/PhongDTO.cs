using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class PhongDTO
    {
        private string _maPhong;
        private string _sucChuaSV;
        private string _SLDangO;
        private string _maLoai;
        private string _tenLoai;
        private string _toa;

        public PhongDTO() { }

        public PhongDTO(string maPhong, string sucChuaSV,
            string SLDangO, string maLoai, string tenLoai, string toa)
        {
            this.MaPhong = maPhong;
            this.SucChuaSV = sucChuaSV;
            this.SLDangO = SLDangO;
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
            this.Toa = toa;
        }

        public PhongDTO(DataRow dr)
        {
            this.MaPhong = dr["MaPhong"].ToString();
            this.SucChuaSV = dr["SucChuaSV"].ToString();
            this.SLDangO = dr["SLDangO"].ToString();
            this.MaLoai = dr["MaLoai"].ToString();
            this.TenLoai = dr["TenLoai"].ToString();
            this.Toa = dr["TenToa"].ToString();
        }

        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string SucChuaSV { get => _sucChuaSV; set => _sucChuaSV = value; }
        public string SLDangO { get => _SLDangO; set => _SLDangO = value; }
        public string MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }
        public string Toa { get => _toa; set => _toa = value; }
    }
}
