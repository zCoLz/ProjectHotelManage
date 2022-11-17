using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Loai
    {
        private string _id;
        private string _name;

        public BEL_Loai(string ma, string ten)
        {
            this._id = ma;
            this._name= ten;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
