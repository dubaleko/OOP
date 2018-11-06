using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class SizeException : TypeException
    {
        public SizeException()
        {
            message = "Sorry you coast size is not acceptable";
            typeoferror = "It's are SizeException";
            time = DateTime.Now;
            typeofexception = "Custom Exception";
        }
    }
}
