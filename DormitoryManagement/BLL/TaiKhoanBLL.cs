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
    }
}
