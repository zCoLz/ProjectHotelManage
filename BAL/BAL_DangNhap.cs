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
    public class BAL_DangNhap
    {
        public bool checkLogin(string user ,string pass)
        {
            DAL_DangNhap xuLyDangNhap = new DAL_DangNhap();
            return xuLyDangNhap.checklogin(user, pass);
        }
        public DataTable FindNhanVienByUser(string user)
        {
            DAL_DangNhap xuLyDangNhap = new DAL_DangNhap();
            return xuLyDangNhap.FindNhanVienByUser(user);
        }
        public DataTable FindNhanVienByMa(string MaNV)
        {
            DAL_DangNhap xuLyDangNhap = new DAL_DangNhap();
            return xuLyDangNhap.FindNhanVienByMa(MaNV);
        }
    }
}
