using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Bush : Plant
    {
        public Bush(string typeofpaper,string typeofposy, string typeofrazmer) : base(typeofpaper, typeofposy, typeofrazmer)
        {
            Console.WriteLine("V poiske priklucheniy");
        }
        public override string ToString()
        {
            return "Bush";
        }
    }
}
