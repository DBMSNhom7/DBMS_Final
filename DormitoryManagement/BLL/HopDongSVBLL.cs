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
    public class HopDongSVBLL
    {
        private HopDongSVDAL _hopDongSVDAL;

        public HopDongSVBLL()
        {
            _hopDongSVDAL = new HopDongSVDAL();
        }

        public HopDongSVDTO layHDSV_TheoMaHD(string maHD)
        {
            DataTable dt = _hopDongSVDAL.layHDSV_TheoMaHD(maHD);
            return new HopDongSVDTO(dt.Rows[0]);
        }
    }
}
