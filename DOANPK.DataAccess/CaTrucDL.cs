using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class CaTrucDL
    {
        DataTable CT;
        private object maCTcu;

        public CaTrucDL()
        {
            var query = "SELECT * FROM [CaTruc]";
            CT = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllCaTruc()
        {
            return CT;
        }
        public bool THCT(String MaCT, String TenCT, DateTime Ngaytruc)
        {
            int count = 0;
            var query = "INSERT INTO CaTruc (MaCT, TenCT, Ngaytruc) VALUES ( @mact , @tenct , @ngaytruc )";
            object[] parameters = { MaCT, TenCT, Ngaytruc };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0) { return true; }
            return false;

        }

        public bool DeleteCaTruc(string mact)
        {
            var query = $"DELETE [CaTruc] WHERE MaCT = '{mact}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCaTruc(string mact, string tenct)
        {
            var query = $"UPDATE [CaTruc] SET TenCT= @tenct WHERE MaCT = @mact ";
            object[] parameters = { tenct, mact };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool KiemTraTonTai(string maCT)
        {
            var query = $"SELECT count(*) FROM CaTruc where  MaCT = @mact ";
            object[] parametera = { maCT };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parametera);
            if (count > 0)
            { return true; }
            return false;
        }
    }
}
