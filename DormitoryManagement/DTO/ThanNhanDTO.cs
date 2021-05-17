using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ThanNhanDTO
    {
        private string _CMND;
        private string _hoTen;
        private string _gioiTinh;
        private string _quanHeVoiSV;
        private string _diaChi;
        private string _dienThoai;
        private string _maSV;

        public ThanNhanDTO() { }

        public ThanNhanDTO(string CMND, string hoTen, string gioiTinh,
            string quanHeVoiSV, string diaChi, string dienThoai, string maSV)
        {
            this.CMND = CMND;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.QuanHeVoiSV = quanHeVoiSV;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.MaSV = maSV;
        }

        public ThanNhanDTO(DataRow dr)
        {
            this.CMND = dr["CMND"].ToString();
            this.HoTen = dr["HoTen"].ToString();
            this.GioiTinh = dr["GioiTinh"].ToString();
            this.QuanHeVoiSV = dr["QuanHeVoiSV"].ToString();
            this.DiaChi = dr["DiaChi"].ToString();
            this.DienThoai = dr["DienThoai"].ToString();
            this.MaSV = dr["MaSV"].ToString();
        }

        public string CMND { get => _CMND; set => _CMND = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string QuanHeVoiSV { get => _quanHeVoiSV; set => _quanHeVoiSV = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string MaSV { get => _maSV; set => _maSV = value; }
    }
}
