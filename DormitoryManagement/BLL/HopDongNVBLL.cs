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
    public class HopDongNVBLL
    {
        private HopDongNVDAL _hopDongNVDAL;

        public HopDongNVBLL()
        {
            _hopDongNVDAL = new HopDongNVDAL();
        }

        public HopDongNVDTO layHDNV_TheoMaHD(string maHD)
        {
            DataTable dt = _hopDongNVDAL.layHDNV_TheoMaHD(maHD);
            return new HopDongNVDTO(dt.Rows[0]);
        }
    }
}
