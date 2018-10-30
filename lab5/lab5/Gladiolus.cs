using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Gladiolus : Flower
    {
        public Gladiolus(string latinname, string colorofplant, string typeofrazmer , int coast) : base(latinname, colorofplant, typeofrazmer,coast)
        {
        }
        public override string ToString()
        {
            return "Gladiolus";
        }
    }
}
