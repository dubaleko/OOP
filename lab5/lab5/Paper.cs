using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Paper : Plant
    {
        public Paper(string latinname, string yearofplant, string typeofrazmer) : base(latinname, yearofplant, typeofrazmer)
        {

        }
        public override string ToString()
        {
            return "Paper";
        }
    }
}
