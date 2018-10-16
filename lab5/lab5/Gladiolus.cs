using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Gladiolus : Flower
    {
        public Gladiolus(string typeofpaper, string typeofposy, string typeofrazmer, string typeoflist) : base(typeofpaper, typeofposy, typeofrazmer, typeoflist)
        {
            Console.WriteLine("V poiske priklucheniy");
        }
        public override string ToString()
        {
            return "Gladiolus";
        }
    }
}
