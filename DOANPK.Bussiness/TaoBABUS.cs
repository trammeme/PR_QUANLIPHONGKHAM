using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class TaoBABUS
    {
        TaoBADL BA = new DataAccess.TaoBADL();

        public DataTable Laydanhsachbenhan()
        {
            return BA.laydsBA();
        }
        public bool themba(string maba, string tenbs, string chuadoan, string mabn)
        {
            if (!BA.addbenhan(mabn))
            {
                if (BA.addba( maba,  tenbs,  chuadoan,  mabn))
                    return true;
            }
            return false;
        }
    }

}