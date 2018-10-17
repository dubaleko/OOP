using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    static class Metods
    {
        public static string dobavlenietocki(this string str)
        {
            string str2 = str.Insert(str.Length, ".");
            return str2;
        }
        public static void proverkananull(this int[] a)
        {
            int[] c = new int[0];
            int k = 0;
            List<int> z = new List<int> { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    z.Add(a[i]);
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(z[i]);
            }
        }
    }
}
