using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class qllkBUS
    {
        qllkDL XLK = new qllkDL();

        public DataTable LayDSlk()
        {
            return XLK.LAYDSlk();
        }
    }
}
