using DOANPK.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPK.Bussiness
{
    public class QLNVBUS
    {            QLNVDL NV = new QLNVDL();

        public DataTable LayDSNV()
        {
            return NV.LAYDSNV();
        }
       public bool Deletenv(string manv)
        {
            QLNVDL NV = new QLNVDL(); // Instantiate QLNVDL object

            return NV.Deletenv(manv);
        }

        public bool CtTennv(string maNV, string tenHH)
        {
            return NV.CapNhatTennv(maNV, tenHH);
        }
        public bool CtGioitinh(string maNV, string gioitinh)
        {
            return NV.CapNhatGioiTinh(maNV, gioitinh);
        }


        public bool Ctsdtnv(string maNV, string sodienthoai)
        {
            return NV.CapNhatSoDienThoai(maNV, sodienthoai);
        }
        public bool Ctngaysinh(string maNV, string ngaysinh)
        {
            return NV.CapNhatNgaySinh(maNV, ngaysinh);
        }
        public bool Ctcknv(string maNV, string chuyenkhoa)
        {
            return NV.CapNhaChuyenKhoa(maNV, chuyenkhoa);
        }
        public bool themnv(string manv, string tennv, string gioitinh, string sodientoai, DateTime ngaysinh, string chuyenkhoa, string maloai)
        {
            if (!NV.addnhanvien(manv))
            {
                if (NV.addnv(manv, tennv, gioitinh, sodientoai, ngaysinh, chuyenkhoa, maloai))
                    return true;
            }
            return false;
        }
    }

}
