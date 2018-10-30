using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Bush : Plant
    {
        public Bush(string latinname, string colorofplant, string typeofrazmer) : base(latinname, colorofplant, typeofrazmer)
        {
        }
        public override string ToString()
        {
            return "Bush";
        }
    }
}
