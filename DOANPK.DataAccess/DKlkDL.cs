using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.DataAccess
{
    public class DKlkDL
    {
        DataTable lk;

        public DKlkDL()
        {
            var query = "SELECT * FROM [DKLK]";
            lk = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LAYDSlk()
        {
            return lk;
        }
        public bool addlk(string malk)
        {

            string query = "SELECT  COUNT(*) FROM DKLK WHERE  MaLK = @maLK ";

            object[] parameters = { malk };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool addlichkham(string MaLK, string HotenBN, DateTime Ngaysinh, string Email, string TenCK, string Hoten, DateTime Ngaykham, string Giokham, DateTime NgayDK, string Trieuchung)
        {
            int count = 0;
            var query = "INSERT INTO DKLK(MaLK, HotenBN, Ngaysinh, Email, TenCK, Hoten, Ngaykham, NgayDK, Giokham, Trieuchung)  VALUES  ( @malk , @tenbn , @ngaysinh , @email , @tenck , @tenbs , @ngaykham , @ngaydk , @giokham , @trieuchung" + " )";
            object[] parameters = { MaLK, HotenBN, Ngaysinh, Email, TenCK, Hoten, Ngaykham, NgayDK, Giokham, Trieuchung };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            {
                return true;
            }
            return false;
        }


    }
}
