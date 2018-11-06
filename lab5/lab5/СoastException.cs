using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5
{
    class СoastException : TypeException
    {
        public СoastException() 
        {
            message = "Sorry you coast is not acceptable";
            typeoferror = "It's are CoastException";
            time = DateTime.Now;
            typeofexception = "Custom Exception";
        }
    }
}
