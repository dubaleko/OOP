using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower: Plant
    {
        public Flower(string latinname, string yearofplant, string typeofrazmer, int coast) : base (latinname, yearofplant, typeofrazmer)
        {
        }
        public override string ToString()
        {
            return "Flower";
        }
    }
}
