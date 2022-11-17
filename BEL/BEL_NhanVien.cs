using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_NhanVien
    {
        private string _id;
        private string _name;
        private string _sex;
        private DateTime _dateBirth;
        private string _address;
        private string _phone;
        private string _user;
        private string _pass;

        public BEL_NhanVien()
        {
            this._id = null;
            this._name = null;
            this._sex = null;
            this._dateBirth = System.DateTime.Now;
            this._address = null;
            this._phone = null;
            this._user = null;
            this._pass = null;
        }
        public BEL_NhanVien(string MaNV, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi,string SĐT,string User, string Pass)
        {
            this._id = MaNV;
            this._name = hoTen;
            this._sex = gioiTinh;
            this.DateBirth = ngaySinh;
            this._address = diaChi;
            this._phone = SĐT;
            this._user = User;
            this._pass = Pass;
        }
   
        //public BEL_NhanVien(string id, string name, string sex, DateTime dateBirth, string address, string phone)
        //{
        //    _id = id;
        //    _name = name;
        //    _sex = sex;
        //    _dateBirth = dateBirth;
        //    _address = address;
        //    _phone = phone;
        //}

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public DateTime DateBirth { get => _dateBirth; set => _dateBirth = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
    }
}
