using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Posy : ClassController
    {  private static Plant[] Buket = new Plant[3];
       public Plant this[int index]
        {
            get
            {
                return Buket[index];
            }
            set
            {
               Buket[index] = value;
            }
        }
       public void OutputPosy()
       {
            Console.WriteLine("Posy Consist:");
            for (int i=0; i<Buket.Length;i++)
            {
                Console.WriteLine(Buket[i]);
            }
       }
       public Plant[] Delete(int number)
        {
            var tmp = new List<Plant>(Buket);
            tmp.RemoveAt(number);
            Buket = tmp.ToArray();
            return Buket;
        }
        public Plant[] GetPosy() => Buket;
    }
}
