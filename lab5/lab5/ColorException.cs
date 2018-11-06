using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class ColorException : TypeException
    {
        public  ColorException()
        {
            message = "Sorry you color is not acceptable";
            typeoferror = "It's are ColorException";
            time = DateTime.Now;
            typeofexception = "Custom Exception";
        }
    }
}
