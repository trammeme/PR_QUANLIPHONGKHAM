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
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public string GetMaLoai(string userName)
        {
            string query = "SELECT UserName FROM Users WHERE UserName = @userName";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["UserName"].ToString();
            }
            else
            {
                return null;
            }
        }
    }

}
