using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Flower: Plant
    {
        public Flower(string latinname, string colorofplant, string typeofrazmer, int coast) : base (latinname, colorofplant, typeofrazmer)
        {
        }
        public override string ToString()
        {
            return "Flower";
        }
    }
}
