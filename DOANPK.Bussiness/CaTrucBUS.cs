using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANPK.DataAccess;

namespace DOANPK.Bussiness
{
    public class CaTrucBUS
    {
        CaTrucDL dh = new CaTrucDL();
        public DataTable LayDSCaTruc()
        {
            return dh.GetAllCaTruc();
        }
        public bool JKCT(string mact, string tenct, DateTime ngaytruc)
        {
            if (!dh.KiemTraTonTai(mact))
            {
                if (dh.THCT(mact, tenct, ngaytruc))
                    return true;
            }
            return false;
        }
        public bool DeleteCaTruc(String mact)
        {
            return dh.DeleteCaTruc(mact);
        }
        public bool UpdateCaTruc(string mact, string tenct, String mactcu)
        {
            if (mact == mactcu)
            {
                if (dh.UpdateCaTruc(mact, tenct))

                    return true;
            }
            return false;

        }

    }
}
