using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NhanVienDTO
    {
        private string _maNV;
        private string _hoTen;
        private string _ngaySinh;
        private string _diaChi;
        private string _dienThoai;
        private string _tenToa;
        private string _maChucVu;
        private string _tenChucVu;
        private string _maHD;

        public NhanVienDTO() { }

        public NhanVienDTO(string maNV, string hoTen, string ngaySinh,
            string diaChi, string dienThoai, string tenToa, string tenChucVu, string maHD)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.TenToa = tenToa;
            this.TenChucVu = tenChucVu;
            this.MaHD = maHD;
        }

        public NhanVienDTO(DataRow dr)
        {
            this.MaNV = dr["MaNV"].ToString();
            this.HoTen = dr["HoTen"].ToString();
            this.NgaySinh = dr["NgaySinh"].ToString();
            this.DiaChi = dr["DiaChi"].ToString();
            this.DienThoai = dr["DienThoai"].ToString();
            this.TenToa = dr["TenToa"].ToString();
            this.MaChucVu = dr["MaChucVu"].ToString();
            this.TenChucVu = dr["TenChucVu"].ToString();
            this.MaHD = dr["MaHD"].ToString();
        }

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string TenToa { get => _tenToa; set => _tenToa = value; }
        public string MaChucVu { get => _maChucVu; set => _maChucVu = value; }
        public string TenChucVu { get => _tenChucVu; set => _tenChucVu = value; }
        public string MaHD { get => _maHD; set => _maHD = value; }
    }
}
