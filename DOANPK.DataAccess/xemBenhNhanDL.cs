using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class xemBenhNhanDL
    {
        DataTable xbn;

        public xemBenhNhanDL()
        {
            var query = "SELECT * FROM [BenhNhan]";
            xbn = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LAYDSbn()
        {
            return xbn;
        }
    }
}
