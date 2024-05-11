using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DOANPK.DataAccess;
namespace DOANPK.Bussiness
{
    public class LoginBUS
    {
        private LoginDL loginDL;

        public LoginBUS()
        {
            loginDL = LoginDL.Instance;
        }

        public bool Login(string userName, string passWord)
        {
            return loginDL.Login(userName, passWord);
        }
    }
}
