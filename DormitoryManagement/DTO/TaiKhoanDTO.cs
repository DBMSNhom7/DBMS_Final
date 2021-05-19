using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _tenTaiKhoan;
        private string _matKhau;
        private string _IDLoaiQuyen;
        private string _TenLoaiQuyen;
        private string _moTa;

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau,
            string IDLoaiQuyen, string TenLoaiQuyen, string moTa)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.IDLoaiQuyen = IDLoaiQuyen;
            this.TenLoaiQuyen = TenLoaiQuyen;
            this.MoTa = moTa;
        }

        public TaiKhoanDTO(DataRow dr)
        {
            this.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            this.MatKhau = dr["MatKhau"].ToString();
            this.IDLoaiQuyen = dr["IDLoaiQuyen"].ToString();
            this.TenLoaiQuyen = dr["TenLoaiQuyen"].ToString();
            this.MoTa = dr["MoTa"].ToString();
        }

        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string IDLoaiQuyen { get => _IDLoaiQuyen; set => _IDLoaiQuyen = value; }
        public string TenLoaiQuyen { get => _TenLoaiQuyen; set => _TenLoaiQuyen = value; }
        public string MoTa { get => _moTa; set => _moTa = value; }
    }
}
