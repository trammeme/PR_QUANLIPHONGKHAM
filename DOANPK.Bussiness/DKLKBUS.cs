using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class DKLKBUS
    {
        DKlkDL LK = new DKlkDL();

        public DataTable LayDSlk()
        {
            return LK.LAYDSlk();
        }
        public bool themlk(string malk, string tenbn, DateTime ngaysinh, string email, string tenck, string tenbs, DateTime ngaykham, string giokham, DateTime ngaydk, string trieuchung)
        {
            if (!LK.addlk(malk))
            {
                if (LK.addlichkham(malk, tenbn, ngaysinh, email, tenck, tenbs, ngaykham, giokham, ngaydk, trieuchung))
                    return true;
            }
            return false;
        }
    }
}