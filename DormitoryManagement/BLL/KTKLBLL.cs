using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class KTKLBLL
    {
        private KTKLDAL _KTKLDAL;

        public KTKLBLL()
        {
            _KTKLDAL = new KTKLDAL();
        }

        public DataTable layKTKL_DGV()
        {
            return _KTKLDAL.layKTKL_DGV();
        }

        public DataTable layKTKL_TheoMaSV_DGV(string maSV)
        {
            return _KTKLDAL.layKTKL_TheoMaSV_DGV(maSV);
        }

        public KTKLDTO layKTKL_TheoMaKTKL(string maKTKL)
        {
            DataTable dt = _KTKLDAL.layKTKL_TheoMaKTKL(maKTKL);
            return new KTKLDTO(dt.Rows[0]);
        }

        public DataTable layKTKL_TimKiem_DGV(string str)
        {
            return _KTKLDAL.layKTKL_TimKiem_DGV(str);
        }

        public bool xoaKTKL_TheoMaKTKL(string maKTKL, ref string error)
        {
            return _KTKLDAL.xoaKTKL_TheoMaKTKL(maKTKL, ref error);
        }

        public bool themKTKL(KTKLDTO ktkl, ref string error)
        {
            return _KTKLDAL.themKTKL(ktkl.HinhThuc, ktkl.MoTa,
                ktkl.NgayTao, ktkl.MaSV, ref error);
        }
    }
}