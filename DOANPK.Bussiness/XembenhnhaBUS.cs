using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class XembenhnhaBUS
    {
        xemBenhNhanDL XBN = new xemBenhNhanDL();

        public DataTable LayDSBN()
        {
            return XBN.LAYDSbn();
        }
    }
}
