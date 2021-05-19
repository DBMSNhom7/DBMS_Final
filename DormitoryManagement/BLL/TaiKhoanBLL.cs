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
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDAL;

        public TaiKhoanBLL()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
        }

        public bool dangNhap(string taiKhoan, string matKhau)
        {
            return _taiKhoanDAL.dangNhap(taiKhoan, matKhau);
        }

        public TaiKhoanDTO layTaiKhoan_TheoTenTK(string taiKhoan)
        {
            return new TaiKhoanDTO(_taiKhoanDAL.layTaiKhoan_TheoTenTK(taiKhoan).Rows[0]);
        }

        public DataTable layTaiKhoan_DGV()
        {
            return _taiKhoanDAL.layTaiKhoan_DGV();
        }

        public DataTable layLoaiTK()
        {
            return _taiKhoanDAL.layLoaiTK();
        }

        public bool themTaiKhoan(TaiKhoanDTO tk, ref string error)
        {
            return _taiKhoanDAL.themTaiKhoan(tk.TenTaiKhoan, tk.MatKhau,
                tk.IDLoaiQuyen, ref error);
        }

        public bool xoaTaiKhoan_TheoTenTK(string tenTK, ref string error)
        {
            return _taiKhoanDAL.xoaTaiKhoan_TheoTenTK(tenTK, ref error);
        }

        public DataTable layTaiKhoan_TimKiem_DGV(string str)
        {
            return _taiKhoanDAL.layTaiKhoan_TimKiem_DGV(str);
        }

        public bool suaTaiKhoan_TheoTenTK(TaiKhoanDTO tk, ref string error)
        {
            return _taiKhoanDAL.suaTaiKhoan_TheoTenTK(tk.TenTaiKhoan,
                tk.MatKhau, tk.IDLoaiQuyen, ref error);
        }
    }
}
