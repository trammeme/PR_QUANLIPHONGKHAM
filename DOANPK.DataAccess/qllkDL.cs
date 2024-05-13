using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class qllkDL
    {
        DataTable xlk;

        public qllkDL()
        {
            var query = "SELECT * FROM [DKLK]";
            xlk = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LAYDSlk()
        {
            return xlk;
        }
    }
}



