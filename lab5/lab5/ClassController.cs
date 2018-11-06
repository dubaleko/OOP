using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class ClassController
    {
      public void Coast(Posy posy)
        {
           Plant[] Buket = posy.GetPosy();
           int k = 0;
           for (int i = 0; i < Buket.Length; i++)
           {
                k = k + posy[i].coast;
           }
          Console.WriteLine($"Coast of all plant in posy {k} by rub");
        }
      public void Sortirovka(Posy posy)
        {
            Plant number;
            Plant[] Buket = posy.GetPosy();
            for (int i = 0; i < Buket.Length-1; i++)
            {
                for (int j = 0; j < Buket.Length; j++)
                {
                    if (Buket[i].coast > Buket[j].coast)
                    {
                        number = Buket[i];
                        Buket[i] = Buket[j];
                        Buket[j] = number;
                    }
                }
            }
            posy.OutputPosy();
        }
      public void ColorofFlower(Posy posy)
        {
            Plant[] Buket = posy.GetPosy();
            string  k =  "red";
            Console.WriteLine("Red color Flower:");
            for (int i = 0; i < Buket.Length; i++)
            {
                if (String.Compare(k,Buket[i].colorofplant) == 0)
               {
                    Console.WriteLine(Buket[i]);
               }
            }
        }
    }
}