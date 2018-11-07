using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    class Set
    {
        private int[] data;
        public Set() { }
        public int[] Data
        {
            get
            {
                return data;
            }
        }
        public Set(int[] data)
        {
            this.data = data;
        }
        public static bool operator <(Set c1, Set c2)
        {
            if (c1.data.Length == c2.data.Length)
            {
                int k = 0;
                for (int j = 0; j < c2.data.Length; j++)
                {
                    for (int i = 0; i < c1.data.Length; i++)
                    {
                        if (c1.data[j] == c2.data[i]) k++;
                    }
                }
                if (k == c1.data.Length) return true;
                else return false;
            }
            return false;
        }
        public static bool operator >(Set c1, Set c2)
        {
            if (c1.data.Length == c2.data.Length)
            {
                return false;
            }
            if (c1.data.Length > c2.data.Length)
            {
                int k = 0;
                for (int j = 0; j < c1.data.Length; j++)
                {
                    for (int i = 0; i < c2.data.Length; i++)
                    {
                        if (c1.data[j] == c2.data[i]) k++;
                        if (k == c2.data.Length) break;
                    }
                }
                if (k == c2.data.Length)
                {
                    return true;

                }
                else return false;
            }
            else
            {
                int k = 0;
                for (int j = 0; j < c2.data.Length; j++)
                {
                    for (int i = 0; i < c1.data.Length; i++)
                    {
                        if (c2.data[j] == c1.data[i]) k++;
                        if (k == c1.data.Length) break;
                    }
                }
                if (k == c1.data.Length)
                {
                    return true;

                }
                return false;
            }
        }
        public static bool operator *(Set c1, Set c2)
        {
            int number;
            int newnumber;
            if (c1.data.Length > c2.data.Length)
            {
                number = c1.data.Length;
                newnumber = c2.data.Length;
            }
            else
            {
                number = c2.data.Length;
                newnumber = c1.data.Length;
            }
            int k = 0;
            for (int j = 0; j < number; j++)
            {
                for (int i = 0; i < newnumber; i++)
                {
                    if (number == c1.data.Length)
                    {
                        if (c1.data[j] == c2.data[i])
                        {
                            k++;
                            if (k == newnumber) break;
                        }
                    }
                    else
                    {
                        if (c1.data[i] == c2.data[j])
                        {
                            k++;
                            if (k == newnumber) break;
                        }
                    }
                }

            }
            if (k == 0) return false;
            else
            {
                return true;
            }
        }
        public static int[] operator -(Set c1, int poz)
        {
            var tmp = new List<int>(c1.data);
            tmp.RemoveAt(poz - 1);
            var d = tmp.ToArray();
            return d;
        }
        public static class Mathoperation
        {
            public static int findmaxElement(int[] a)
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                return max;
            }
            public static int findminElement(int[] a)
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min) min = a[i];
                }
                return min;
            }
            public static int findkovlo(int[] a)
            {
                int kolvo = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    kolvo++;
                }
                return kolvo;
            }
        }
    }
}
