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
    public class BAL_Phong
    {
        public DataTable DanhSachPhong()
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.DocDanhSachPhong();
        }
        public DataTable DanhSachPhong_rong()
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.DocDanhSachPhong_rong();
        }
        public bool ThemPhong(BEL_Phong p)
        {
            DAL_Phong xulyPhong = new DAL_Phong();
            return xulyPhong.themPhong(p);
        }
        public bool updatePhong(string maPhong, string loaiPhong, string tinhTrang, string gia)
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.updatePhong(maPhong, loaiPhong, tinhTrang, gia);
        }
        public bool deletePhong(string maPHG)
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.deletePhong(maPHG);
        }
        public DataTable timKiem(string keyword)
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.TimKiem(keyword);
        }
        public bool setrollphong(string maphg ,string roll)
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.SetRollPhong(maphg, roll);
        }
        public double getGia_Phong(string MaPHG)
        {
            DAL_Phong xuLyPhong = new DAL_Phong();
            return xuLyPhong.getGia_Phong(MaPHG);
        }
    }
}
