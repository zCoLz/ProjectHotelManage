using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_QuanLyThuePhong
    {
        private string _maNV;
        private string _maKH;
        private string _maPHG;
        DateTime _ngaydatphong;
        DateTime _ngaytraphong;
        private int _display = 0;

        public BEL_QuanLyThuePhong(string maNV, string maKH, string maPHG, DateTime ngaydatphong, DateTime ngaytraphong)
        {
            _maNV = maNV;
            _maKH = maKH;
            _maPHG = maPHG;
            _ngaydatphong = ngaydatphong;
            _ngaytraphong = ngaytraphong;
        }
        public BEL_QuanLyThuePhong(string maNV, string maKH, string maPHG, DateTime ngaydatphong)
        {
            _maNV = maNV;
            _maKH = maKH;
            _maPHG = maPHG;
            _ngaydatphong = ngaydatphong;
        }

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string MaPHG { get => _maPHG; set => _maPHG = value; }
        public DateTime Ngaydatphong { get => _ngaydatphong; set => _ngaydatphong = value; }
        public DateTime Ngaytraphong { get => _ngaytraphong; set => _ngaytraphong = value; }
        public int display { get => _display; set => _display = value; } 
    }
}
