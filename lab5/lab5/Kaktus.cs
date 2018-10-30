using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    sealed class Kaktus : Flower
    {
        public Kaktus(string latinname, string colorofplant, string typeofrazmer , int coast) : base(latinname, colorofplant, typeofrazmer,coast)
        {

        }
        public override string ToString()
        {
            return "Kaktus";
        }
    }
}
