using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    sealed class Kaktus : Flower
    {
        public Kaktus(string typeofpaper, string typeofposy, string typeofrazmer, string typeoflist) : base(typeofpaper, typeofposy, typeofrazmer,typeoflist)
        {

        }
        public override string ToString()
        {
            return "Kaktus";
        }
    }
}
