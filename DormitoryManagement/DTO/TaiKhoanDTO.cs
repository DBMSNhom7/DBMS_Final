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

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }

        public TaiKhoanDTO(DataRow dr)
        {
            this.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            this.MatKhau = dr["MatKhau"].ToString();
        }

        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
    }
}
