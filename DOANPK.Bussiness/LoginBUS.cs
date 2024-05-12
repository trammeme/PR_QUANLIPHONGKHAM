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

        public static bool Login(string username, string password)
        {
            return DataProvider.Instance.CheckLogin(username, password);
        }


    }
}
