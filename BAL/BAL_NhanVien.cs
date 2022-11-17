using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;

namespace BAL
{
    public class BAL_NhanVien
    {
        public DataTable DocDSNhanVien()
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.DocDSNhanVien();
        }
        public bool ThemNhanVien(BEL_NhanVien nv)
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.themNhanVien(nv);
        }
        public bool updateNhanVien(string MaNV, string HoTen, string gioiTinh, DateTime ngaySinh, string  diaChi, string SĐT, string User ,string Pass)
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.updateNV(MaNV, HoTen, gioiTinh, ngaySinh, diaChi, SĐT,User, Pass);
        }
        public bool deleteNhanVien(string maNV)
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.deleteNV(maNV);
        }
        public DataTable TimkiemNhanVien(String keyword)
        {
            DAL_NhanVien xuLyNhanVien = new DAL_NhanVien();
            return xuLyNhanVien.TimKiem(keyword);
        }

    }
}
