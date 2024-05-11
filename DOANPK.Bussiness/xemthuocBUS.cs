using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class xemthuocBUS
    {
        xemthuocDL XT = new xemthuocDL();

        public DataTable Laydanhsachthuoc()
        {
            return XT.laydsthuoc();
        }
        public DataTable timmathuoc(string data)
        {
            return XT.timthuoc(data);
        }
    }


}