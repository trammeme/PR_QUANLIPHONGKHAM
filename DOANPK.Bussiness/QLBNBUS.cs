using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class QLBNBUS
    {
        QLBNDL dh = new QLBNDL();
        public DataTable LayDSBenhNhan()
        {
            return dh.GetAllBenhNhan();
        }
        public bool JKBN(string mabn, string tenbn, DateTime ngaysinh, string dc, string sdt)
        {
            if (!dh.KiemTraTonTai(mabn))
            {
                if (dh.THBN(mabn, tenbn, ngaysinh, dc, sdt))
                    return true;
            }
            return false;
        }
        public bool DeleteBenhNhan(String mabn)
        {
            return dh.DeleteBenhNhan(mabn);
        }
        public bool UpdateBenhNhan(string mabn, string tenbn, DateTime ngaysinh, string dc, string sdt, String mabncu)
        {
            if (mabn == mabncu)
            {
                if (dh.UpdateBenhNhan(mabn, tenbn, ngaysinh, dc, sdt))

                    return true;
            }
            return false;

        }
    }
}
