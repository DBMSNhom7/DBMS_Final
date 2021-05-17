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
    public class ThanNhanBLL
    {
        private ThanNhanDAL _thanNhanDAL;

        public ThanNhanBLL()
        {
            _thanNhanDAL = new ThanNhanDAL();
        }

        public ThanNhanDTO layThanNhan_TheoCMNDTN(string CMND_TN)
        {
            DataTable dt = _thanNhanDAL.layThanNhan_TheoCMNDTN(CMND_TN);
            return new ThanNhanDTO(dt.Rows[0]);
        }
    }
}
