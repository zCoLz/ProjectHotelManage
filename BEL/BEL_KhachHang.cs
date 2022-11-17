using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_KhachHang
    {
        private string _maKH;
        private string _hoTenKH;
        private DateTime _ngaySinh;
        private string _sex;
        private string _address;
        private string _phone;
        private string _cmnd;
        private string _quocTich;

        private BEL_KhachHang()
        {
            this._maKH = null;
            this._hoTenKH =null;
            this._ngaySinh = System.DateTime.Now;
            this._sex = null;
            this._address = null;
            this._phone = null;
            this._cmnd = null;
            this._quocTich = null;
        }
        public BEL_KhachHang(string maKH, string hoTenKH, DateTime ngaySinh, string sex, string address, string phone, string cmnd, string quocTich)
        {
            this._maKH = maKH;
            this._hoTenKH = hoTenKH;
            this._ngaySinh = ngaySinh;
            this._sex = sex;
            this._address = address;
            this._phone = phone;
            this._cmnd = cmnd;
            this._quocTich = quocTich;
        }   

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string HoTenKH { get => _hoTenKH; set => _hoTenKH = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Cmnd { get => _cmnd; set => _cmnd = value; }
        public string QuocTich { get => _quocTich; set => _quocTich = value; }
    }
}
