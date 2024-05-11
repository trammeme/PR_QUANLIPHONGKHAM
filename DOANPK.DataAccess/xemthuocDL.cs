using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class xemthuocDL
    {
        DataTable xt;

        public xemthuocDL()
        {
            var query = "SELECT * FROM [Thuoc]";
            xt = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable laydsthuoc()
        {
            return xt;
        }
        public DataTable timthuoc(string MaThuoc)
        {
            string query = "SELECT * FROM [Thuoc] WHERE MaThuoc LIKE @Keyword";
            object[] parameter = { MaThuoc };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
