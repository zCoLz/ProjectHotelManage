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
    public class BAL_TinhTrang
    {
        public DataTable TinhTrangPhong()
        {
            DAL_TinhTrang xuLyTinhtrang = new DAL_TinhTrang();
            return xuLyTinhtrang.TinhTrangPhong();
        }
    }
}
