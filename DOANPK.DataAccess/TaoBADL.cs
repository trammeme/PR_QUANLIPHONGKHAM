using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class TaoBADL
    {
        DataTable ba;

        public TaoBADL()
        {
            var query = "SELECT * FROM [BenhAn]";
            ba = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable laydsBA()
        {
            return ba;
        }
      
        public bool addbenhan(string maba)
        {

            string query = "SELECT  COUNT(*) FROM BenhAn WHERE  MaBA = @maba ";

            object[] parameters = { maba };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool addba(string MaBA, string TenBS, string Chuandoan, string MaBN)
        {


            int count = 0;
            var query = "INSERT INTO BenhAn( MaBA,TenBS,Chuandoan ,MaBN) VALUES ( @maba , @tenbs , @chuadoan , @mabenhnhan" + " )";
            object[] parameters = { MaBA, TenBS, Chuandoan, MaBN };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
    }
}

