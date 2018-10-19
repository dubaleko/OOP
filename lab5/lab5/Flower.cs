using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower: Plant
    {
        public Flower(string typeofpaper, string typeofposy, string typeofrazmer, string typeoflist) : base(typeofpaper, typeofposy, typeofrazmer)
        {
        }
        public override string ToString()
        {
            return "Flower";
        }
    }
}
