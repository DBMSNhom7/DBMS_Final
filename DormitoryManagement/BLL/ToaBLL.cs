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
    public class ToaBLL
    {
        private ToaDAL _toaDAL;

        public ToaBLL()
        {
            _toaDAL = new ToaDAL();
        }

        public DataTable layToa()
        {
            return _toaDAL.layToa();
        }

        public int layTongSoToa()
        {
            return _toaDAL.layTongSoToa();
        }
    }
}
