using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Phong
    {
        private string _maPhong;
        private string _loaiPhong;
        private string _tinhTrang;
        private string _gia;
        private string _trangthai;
        public BEL_Phong(string MaPhong , string LoaiPhong, string TinhTrang,string Gia, string TrangThai)
        {
            this._maPhong = MaPhong;
            this._loaiPhong = LoaiPhong;
            this._tinhTrang = TinhTrang;
            this._gia = Gia;
            this._trangthai = TrangThai;
        }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public string LoaiPhong { get => _loaiPhong; set => _loaiPhong = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public string Gia { get => _gia; set => _gia = value; }
        public string Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
