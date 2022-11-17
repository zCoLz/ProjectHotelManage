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
    public class BAL_Loai
    {
        public DataTable DocDanhSachLoai()
        {
            DAL_Loai xuLyLoai = new DAL_Loai ();
            return xuLyLoai.DocDanhSachLoai();
        }
    }
}
