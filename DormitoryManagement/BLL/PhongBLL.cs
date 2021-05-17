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
    public class PhongBLL
    {
        private PhongDAL _phongDAL;

        public PhongBLL()
        {
            _phongDAL = new PhongDAL();
        }

        public DataTable layPhong_DGV()
        {
            return _phongDAL.layPhong_DGV();
        }

        public PhongDTO layPhong_TheoMaPhong(string maPhong)
        {
            DataTable dt = _phongDAL.layPhong_TheoMaPhong(maPhong);
            return new PhongDTO(dt.Rows[0]);
        }

        public DataTable layPhong_TimKiem_DGV(string str)
        {
            return _phongDAL.layPhong_TimKiem_DGV(str);
        }

        public DataTable layPhong_TheoToa(string tenToa)
        {
            return _phongDAL.layPhong_TheoToa(tenToa);
        }

        public DataTable layLoaiPhong()
        {
            return _phongDAL.layLoaiPhong();
        }

        public bool suaPhong(PhongDTO phong, ref string error)
        {
            return _phongDAL.suaPhong(phong.MaPhong, phong.MaLoai,
                phong.SucChuaSV, ref error);
        }
    }
}
