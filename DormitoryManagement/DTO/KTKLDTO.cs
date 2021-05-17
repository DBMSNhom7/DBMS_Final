using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class KTKLDTO
    {
        private string _maKTKL;
        private string _hinhThuc;
        private string _moTa;
        private string _ngayTao;
        private string _maSV;
        private string _tenSV;

        public KTKLDTO() { }

        public KTKLDTO(string maKTKL, string hinhThuc, string moTa,
            string ngayTao, string maSV, string tenSV)
        {
            this.MaKTKL = maKTKL;
            this.HinhThuc = hinhThuc;
            this.MoTa = moTa;
            this.NgayTao = ngayTao;
            this.MaSV = maSV;
            this.TenSV = tenSV;
        }

        public KTKLDTO(DataRow dr)
        {
            this.MaKTKL = dr["MaKTKL"].ToString();
            this.HinhThuc = dr["HinhThuc"].ToString();
            this.MoTa = dr["MoTa"].ToString();
            this.NgayTao = dr["NgayTao"].ToString();
            this.MaSV = dr["MaSV"].ToString();
            this.TenSV = dr["TenSV"].ToString();
        }

        public string MaKTKL { get => _maKTKL; set => _maKTKL = value; }
        public string HinhThuc { get => _hinhThuc; set => _hinhThuc = value; }
        public string MoTa { get => _moTa; set => _moTa = value; }
        public string NgayTao { get => _ngayTao; set => _ngayTao = value; }
        public string MaSV { get => _maSV; set => _maSV = value; }
        public string TenSV { get => _tenSV; set => _tenSV = value; }
    }
}
