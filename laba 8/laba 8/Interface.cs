using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_8
{
    interface Interface<T>
    {
        void Add(T element);
        void Remove(T element);
        List<T> Show();
    }
}
