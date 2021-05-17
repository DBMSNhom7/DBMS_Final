using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class SinhVienDTO
    {
        private string _maSV;
        private string _CMND;
        private string _hoTen;
        private string _gioiTinh;
        private string _ngaySinh;
        private string _diaChi;
        private string _dienThoai;
        private string _maHD;
        private string _CMNDTN;
        private string _maPhong;

        public SinhVienDTO() { }

        public SinhVienDTO(string maSV, string CMND, string hoTen, string gioiTinh, string ngaySinh,
            string diaChi, string dienThoai, string maHD, string CMNDTN, string maPhong)
        {
            this.MaSV = maSV;
            this.CMND = CMND;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.MaHD = maHD;
            this.CMNDTN = CMNDTN;
            this.MaPhong = maPhong;
        }

        public SinhVienDTO(DataRow dr)
        {
            this.MaSV = dr["MaSV"].ToString();
            this.CMND = dr["CMND"].ToString();
            this.HoTen = dr["HoTen"].ToString();
            this.GioiTinh = dr["GioiTinh"].ToString();
            this.NgaySinh = dr["NgaySinh"].ToString();
            this.DiaChi = dr["DiaChi"].ToString();
            this.DienThoai = dr["DienThoai"].ToString();
            this.MaHD = dr["MaHD"].ToString();
            this.CMNDTN = dr["CMND_TN"].ToString();
            this.MaPhong = dr["MaPhong"].ToString();
        }

        public string MaSV { get => _maSV; set => _maSV = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string MaHD { get => _maHD; set => _maHD = value; }
        public string CMNDTN { get => _CMNDTN; set => _CMNDTN = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
