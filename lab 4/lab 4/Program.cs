using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
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
        public class Owner
        {
            private int id;
            private string name;
            private string organization;
            public Owner(int id, string name, string organization)
            {
                this.id = id;
                this.name = name;
                this.organization = organization;
            }
            public int ID
            {
                get
                {
                    return id;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public string Organisation
            {
                get
                {
                    return organization;
                }
            }
        }
        public class Date
        {
            private string dateOfCreation;

            public string DateOfCreation
            {
                get
                {
                    return dateOfCreation;
                }
            }

            public Date(string dateOfCreation)
            {
                this.dateOfCreation = dateOfCreation;
            }
        }
        public static class Mathoperation
        {
            public static int findmaxElement(int[] a)
            {
                int max = a[0];
                for (int i = 0;i<a.Length; i++)
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
            public static string dobavlenietocki(string str)
            {
                string str2 = str.Insert(str.Length, ".");
                return str2;
            }
            public static void proverkananull(int[] a)
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
                for (int i = 0; i<k;i++)
                {
                    Console.WriteLine(z[i]);
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите размеры множествa a");
            int razm1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размеры множествa b");
            int razm2 = int.Parse(Console.ReadLine());
            int[] Arr = new int[razm1];
            int[] newArr = new int[razm2];
            Console.WriteLine("Введите элементы множества 1");
            for (int i = 0; i < razm1; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите элементы множества ");
            for (int i = 0; i < razm2; i++)
            {
                newArr[i] = int.Parse(Console.ReadLine());
            }
            Set Array = new Set(Arr);
            Set NewArray = new Set(newArr);
            Set Massiv;
            if (Array < NewArray)
            {
                Console.WriteLine("Множества равны");
            }
            else
            {
                Console.WriteLine("Множества не равны");
            }
            if (Array > NewArray)
            {
                Console.WriteLine("Одно из множеств является подмножеством другого ");
            }
            else
            {
                Console.WriteLine("Ни одно из множеств не является подмножеством");
            }
            if (Array * NewArray)
             {
                    Console.WriteLine("У заданных множеств есть общие члены");
             }
            else
            {
                    Console.WriteLine("У заданных множеств нет общих членов");
            }
            Console.WriteLine("Выберите номер множества , где будем производить удаление");
            int mass = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите номер  члена множества который будем удалять");
            int numb = int.Parse(Console.ReadLine());
            if (mass == 1) Massiv = Array;
            else Massiv = NewArray;
            int[] d = Massiv - numb;
            Console.Write("Множество без удаленного члена: ");
            for (int i =0; i <Massiv.data.Length-1;i++)
            { 
             Console.Write(d[i]+" ");
            }
            Console.WriteLine();
            Set.Owner owner = new Set.Owner(4, "Valentin", "BSTU");
            Console.WriteLine($"\nВладелец: ID: {owner.ID}, имя: {owner.Name}, " + $"организация: {owner.Organisation}");
            Set.Date date = new Set.Date("10.10.2018");
            Console.WriteLine($"Дата создания: {date.DateOfCreation}");
            Console.WriteLine("Максимальное значение множества из которого удаляли элемент:"+ Mathoperation.findmaxElement(d));
            Console.WriteLine("Минимальное значение множества массива из которого удаляли элемент:" + Mathoperation.findminElement(d));
            Console.WriteLine("Число элементов множества:" + Mathoperation.findkovlo(d));
            Console.WriteLine("Введите строку в конец которой хотите добавить точку");
            string str = Console.ReadLine();
            Console.WriteLine(Mathoperation.dobavlenietocki(str));
            Console.WriteLine("Все нули из множества  удалены ");
            Mathoperation.proverkananull(d);
        }
        }    
}

