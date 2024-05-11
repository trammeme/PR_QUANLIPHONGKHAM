using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class QLBNDL
    {
        DataTable BN;
        private object maCTcu;

        public QLBNDL()
        {
            var query = "SELECT * FROM [BenhNhan]";
            BN = DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllBenhNhan()
        {
            return BN;
        }
        public bool THBN(String MaBN, String TenBN, DateTime Ngaysinh, String DC, String Sdt)
        {
            int count = 0;
            var query = "INSERT INTO BenhNhan (MaBN, TenBN, Ngaysinh, DC, Sdt) VALUES ( @mabn , @tenbn , @ngaysinh , @diachi , @sodienthoai )";
            object[] parameters = { MaBN, TenBN, Ngaysinh, DC, Sdt };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0) { return true; }
            return false;

        }

        public bool DeleteBenhNhan(string mabn)
        {
            var query = $"DELETE [BenhNhan] WHERE MaBN = '{mabn}' ";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateBenhNhan(string mabn, string tenbn, DateTime ngaysinh, string dc, string sdt)
        {
            var query = $"UPDATE [BenhNhan] SET TenBN= @tenBN , Ngaysinh = CONVERT(DATE, @ngaysinh ), DC= @dc , Sdt= @sdt   WHERE MaBN = @mabn ";
            object[] parameters = { tenbn, ngaysinh, dc, sdt, mabn };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool KiemTraTonTai(string maBN)
        {
            var query = $"SELECT count(*) FROM BenhNhan where  MaBN = @mabn ";
            object[] parametera = { maBN };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parametera);
            if (count > 0)
            { return true; }
            return false;
        }
    }
}
