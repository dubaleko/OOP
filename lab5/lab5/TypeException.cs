using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class TypeException : Exception
    {
        public string typeofexception { get; set; }
        public string message { get; set; }
        public string typeoferror { get; set; }
        public System.DateTime time { get; set; }
    }
}
