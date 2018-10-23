using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    abstract partial class Plant : Object, Year, Latinname
    {
        public override int GetHashCode()
        {
            return 18;
        }
        public override string ToString()
        {
            return "Plant";
        }
        public override bool Equals(object obj)
        {
            return !base.Equals(obj);
        }
    }
}
