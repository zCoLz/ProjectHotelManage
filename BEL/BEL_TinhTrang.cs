using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_TinhTrang
    {
        private string _id;
        private string _tentinhtrang;

        public BEL_TinhTrang(string id, string tentinhtrang)
        {
            this._id = id;
            this._tentinhtrang = tentinhtrang;
        }

        public string Id { get => _id; set => _id = value; }
        public string Tentinhtrang { get => _tentinhtrang; set => _tentinhtrang = value; }
    }
}
