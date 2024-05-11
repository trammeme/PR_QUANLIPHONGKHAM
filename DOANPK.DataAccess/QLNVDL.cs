using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOANPK.DataAccess
{
    public class QLNVDL
    {
        DataTable nv;

        public QLNVDL()
        {
            var query = "SELECT * FROM [NhanVien]";
            nv = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LAYDSNV()
        {
            return nv;
        }
        public bool Deletenv(string manv)
         {
             var query = $"DELETE [NhanVien] WHERE MaNV = '{manv}' ";
             var result = DataProvider.Instance.ExecuteNonQuery(query);
             return result > 0;
         }

        public bool addnhanvien(string manv)
        {

            string query = "SELECT  COUNT(*) FROM NhanVien WHERE  MaNV = @manv ";

            object[] parameters = { manv };
            int count = (int)DataProvider.Instance.ExecuteScalar(query, parameters);
            if (count > 0)
                return true;
            return false;

        }
        public bool addnv(string MaNV, string Hoten, string Gioitinh, string Sdt, DateTime Ngaysinh, string MaCK, string Maloainv)
        {


            int count = 0;
            var query = "INSERT INTO NhanVien( MaNV,Hoten,Gioitinh ,Sdt,Ngaysinh, MaCK,Maloainv ) VALUES ( @manv , @tennv , @gioitinh , @sdt , @ngaysinh , @chuyenkhoa , @maloai" + " )";
            object[] parameters = { MaNV, Hoten, Gioitinh, Sdt, Ngaysinh, MaCK, Maloainv };
            count = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            if (count != 0)
            { return true; }
            return false;
        }
        public bool CapNhatTennv(string manv, string tennv)
        {
            var query = "UPDATE [NhanVien] SET Hoten = @tenmoi WHERE MaNV = @Manv";
            object[] parameters = { tennv, manv };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

       public bool CapNhatGioiTinh(string maNV, string gioitinh)
        {
            var query = "UPDATE [NhanVien] SET Gioitinh = @gioitinh WHERE MaNV = @Manv";
            object[] parameters = { gioitinh, maNV };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool CapNhatSoDienThoai(string maNV, string sodienthoai)
        {
            var query = "UPDATE [NhanVien] SET   Sdt  = @sodienthoai WHERE MaNV = @Manv";
            object[] parameters = { sodienthoai, maNV };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool CapNhatNgaySinh(string maNV, string ngaysinh)
        {
            var query = "UPDATE [NhanVien] SET   Ngaysinh  = @ngaysinh WHERE MaNV = @Manv";
            object[] parameters = { ngaysinh, maNV };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool CapNhaChuyenKhoa(string maNV, string chuyenkhoa)
        {
            var query = "UPDATE [NhanVien] SET   MaCK  = @chuyenkhoa WHERE MaNV = @Manv";
            object[] parameters = { chuyenkhoa, maNV };
            var result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}

