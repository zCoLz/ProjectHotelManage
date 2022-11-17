using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class BEL_DangNhap
    {
        private string _user;
        private string _pass;

        public BEL_DangNhap(string User,string Pass)
        {
            this._user = User;
            this._pass = Pass;
        }

        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
    }
}
