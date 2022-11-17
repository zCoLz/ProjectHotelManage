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
    public class BAL_QuanLyThuePhong
    {
        public DataTable DanhSachThuePhong()
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.DanhSachThuePhong();
        }
        public bool ThuePhong(BEL_QuanLyThuePhong tp)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.thuePhong(tp);
        }
        public bool ThuePhong_NoTraPhong(BEL_QuanLyThuePhong tp)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.thuePhong_KoNgayKT(tp);
        }
        public bool ThemKhachHang(BEL_KhachHang kh)
        {
            DAL_QuanLyThuePhong xuLyKhachHang = new DAL_QuanLyThuePhong();
            return xuLyKhachHang.themKhachHang(kh);
        }
        public bool traphong_themNKT(string MaHD,DateTime NKT)
        {
            DAL_QuanLyThuePhong xuLyKhachHang = new DAL_QuanLyThuePhong();
            return xuLyKhachHang.TraPhong(MaHD,NKT);
        }
        public bool deleteThuePhong(string maHD)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.deleteThuePhong(maHD);
        }
        public bool setrollQuanLyThuePhong(string display, string roll)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.SetRollQLThuePhong(display, roll);
        }
        public bool Settonghoadon(string mahoadon, double tong)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.Settonghoadon(mahoadon, tong);
        }
        public double gettonghoadon(string mahoadon)
        {
            DAL_QuanLyThuePhong xuLyThuePhong = new DAL_QuanLyThuePhong();
            return xuLyThuePhong.gettonghoadon(mahoadon);
        }


    }
}
