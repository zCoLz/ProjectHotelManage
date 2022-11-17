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
    public class BAL_KhachHang
    {
        public DataTable DocDSKhachHang()
        {
            DAL_KhachHang xulyKhachHang = new DAL_KhachHang();
            return xulyKhachHang.DocDSKhachHang();
        }
        public bool ThemKhachHang(BEL_KhachHang kh)
        {
            DAL_KhachHang xulyKhachHang = new DAL_KhachHang();
            return xulyKhachHang.themKhachHang(kh);
        }
        public bool CapNhatKhachHang(string maKH, string hoTenKH,DateTime ngaySinh,string gioiTinh,string diaChi, string SĐT, string cmnd,string quocTich )
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.updateKH(maKH,hoTenKH,ngaySinh,gioiTinh,diaChi,SĐT,cmnd,quocTich);
        }
        public bool deleteKhachHang(string maKH)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.deleteKH(maKH);
        }
        public DataTable TimKiemKhachHang(string keyword)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.TimKiem(keyword);
        }
        public string GetNameKH(string MaKH)
        {
            DAL_KhachHang xuLyKhachHang = new DAL_KhachHang();
            return xuLyKhachHang.GetNameKH(MaKH);
        }
    }
}
