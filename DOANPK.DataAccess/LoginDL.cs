using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class LoginDL
    {
        private static LoginDL instance;

        public static LoginDL Instance
        {
            get { if (instance == null) instance = new LoginDL(); return instance; }
            private set { instance = value; }
        }

        private LoginDL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT Password FROM dbo.Users WHERE UserName = @username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            return result.Rows.Count > 0;
        }
    }
}
