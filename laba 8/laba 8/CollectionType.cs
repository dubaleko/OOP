using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    class CollectionType<T> : Interface<T>
    {
        private List<T> collection;

        public void Add(T element)
        {
            collection.Add(element);
        }
         public void Remove(T element)
        {
            collection.Remove(element);           
        }
        public List<T> Show()
        {
            return collection;
        }
    }
}
