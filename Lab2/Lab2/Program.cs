using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Типы
            //a) Определите переменные всех возможных примитивных типов
            //С# и проинициализируйте их
            sbyte p1 = 12;  Console.WriteLine(p1);
            short p2 =-1;   Console.WriteLine(p2 );
            int p3 = -500;  Console.WriteLine(p3);
            long p4 = -1000000; Console.WriteLine(p4);
            ushort p5 = 1; Console.WriteLine(p5);
            uint p6 = 500; Console.WriteLine(p6);
            ulong p7 = 1000000; Console.WriteLine(p7);
            char p8 ='x'; Console.WriteLine(p8);
            bool p9 = false; Console.WriteLine(p9);
            float p10 = 3.5F; Console.WriteLine(p10);
            double p11 = 3.546975; Console.WriteLine(p11);
            decimal p12 = 300.5m; Console.WriteLine(p12);
            string p13 = "string"; Console.WriteLine(p13);
            object p14 = 'a'; Console.WriteLine(p14);
            //b) Выполните 5 операций явного и 5 неявного приведения.
            //Неявное
            p3 = p5;
            p7 = p5;
            p3 = p2;
            p11 = p10;
            p4 = p1;
            //Явное
            p7 = (ulong)p6;
            p4 = (long)p3;
            p3 = (int)p2;
            p2 = (short)p1;
            p6 = (uint)p5;
            //c)Выполните упаковку и распаковку значимых типов.
            p14= (object)p1;   //Упаковка
            p1 = (sbyte)p14;   //Распаковка

            p14 = (object)p2;
            p2 = (short)p14;

            p14 = (object)p3;
            p3 = (int)p14;

            p14 = (object)p4;
            p4 = (long)p14;

            p14 = (object)p5;
            p5 = (ushort)p14;

            p14 = (object)p6;
            p6 = (uint)p14;

            p14 = (object)p7;
            p7 = (ulong)p14;

            p14 = (object)p8;
            p8 = (char)p14;

            p14 = (object)p9;
            p9 = (bool)p14;

            p14 = (object)p10;
            p10 = (float)p14;

            p14 = (object)p11;
            p11 = (double)p14;

            p14 = (object)p12;
            p12 = (decimal)p14;

            p14 = (object)p13;
            p13 = (string)p14;
            //d)Продемонстрируйте работу с неявно типизированной переменной.
            var nottype = "string";
            var nottype2 = 3.5;
            Console.Write(nottype.GetType()+"\n");
            Console.Write(nottype2.GetType()+"\n");
            //e)Продемонстрируйте работу с nullable переменной
            Nullable<int> x = 5;
            int? x1 = null;
            Console.WriteLine(x == x1);
            int? a = null;
            int? b = 1;
            Console.WriteLine(b ?? a);
            //Задание 2: Строки
            //a)Объявите строковые литералы. Сравните их.
            string name = "Vlad";
            string name2 = "Dimon";
            if (name == name2)
            { Console.WriteLine("Имена совпали "); }
            else
            { Console.WriteLine("Имена не совпадают"); }
            //b)Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
            string str1 = "Свобода ";
            string str2 = "Равенство ";
            string str3 = "Независимость людям";
            Console.WriteLine(string.Concat(str1,str2 ,str3));
            string str4 = String.Copy(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str2.Substring(3, 5));
            String[] stringArr = str3.Split(' ');
            Console.WriteLine(str3.Insert(3, str1.Substring(0, 4)));
            Console.WriteLine(str2.Remove(2,3));
            //c)Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string ax = "";
            string bx = null;
            Console.WriteLine((bx ?? ax));
            //d)Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.
            StringBuilder sb = new StringBuilder("ABCDEFG", 50);
            sb.Remove(3, 2);
            sb.Append(new char[] { 'X', 'Y', 'Z' });
            sb.Insert(0, "QWE");
            Console.Write(sb + "\n");
            //3)Массивы
            // a)Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 
            int[,] z = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };
            Console.Write("Matrica" + "\n");
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(z[j, i] + " ");
                }
                Console.WriteLine();
            }
            //b)Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение).
            string[] strArray = new string [3];
            strArray[0] = "qwe";
            strArray[1] = "rty";
            strArray[2] = "fgh";
            for (int i=0; i<3; i++)
            {
                Console.Write(strArray[i]+" ");
            }
            Console.WriteLine();
            Console.Write("Длина массива "+ strArray[0].Length + "\n");
            int num;
            while (true)
            {
                Console.WriteLine("Введите позицию для замены (1-3):");
                num = int.Parse(Console.ReadLine());
                if (num == 1 || num == 2 || num == 3)
                {
                    break;
                }
            }
            Console.Write("Введите строку для замены: ");
            string temp = Console.ReadLine();
            strArray[num - 1] = temp;

            for (int i = 0; i < 3; i++)
            {
                Console.Write(strArray[i]+" ");
            }
            Console.WriteLine();
            //c)Создайте ступечатый (не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.
            int[][] axv = new int[3][];
            axv[0] = new int[2];
            axv[1] = new int[3];
            axv[2] = new int[4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < axv[i].Length; j++)
                {
                    Console.WriteLine("Введите значение ");
                    axv[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Значения ступенчатого массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < axv[i].Length; j++)
                {
                    Console.Write(axv[i][j] + " ");
                }
                Console.WriteLine();
            }
            //d. Создайте неявно типизированные переменные для хранения массива и строки.
            var arrayhall = axv;
            var stringhall = str1;
            Console.WriteLine(arrayhall);
            Console.WriteLine(stringhall);
            //4)Кортежи
            //а)Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
            //b) Сделайте именование его элементов.
            var names1 = (age:18,name:"Valentin",symbol:'X',secondname:"Dubaleko",year:2018);
            //c.Выведите кортеж на консоль целиком и выборочно(1, 3, 4 элементы)
            Console.WriteLine("Кортеж"+names1);
            Console.WriteLine("1-ый символ "+ names1.age);
            Console.WriteLine("3-ый символ "+ names1.symbol);
            Console.WriteLine("4-ый символ "+ names1.secondname);
            //d)Выполните распаковку кортежа в переменные.
            var age = names1.age;
            var firstname = names1.name;
            var symbol = names1.symbol;
            var secondname = names1.secondname;
            var year = names1.year;
            Console.WriteLine(age + firstname + symbol + secondname + year);
            //e. Сравните два кортежа.
            var names2 = (19, "sergo", 'X', "Rozkov", 2018);
            if (Tuple.Equals(names1, names2))
            {
                Console.WriteLine("Кортежи равны.");
            }
            else
            {
                Console.WriteLine("Кортежи не равны.");
            }
            //5) Создайте локальную функцию в main и вызовите ее. Формальные
            //параметры функции – массив целых и строка. Функция должна вернуть
            //кортеж, содержащий: максимальный и минимальный элементы массива,
            //сумму элементов массива и первую букву строки.
            (int,int,int,string)task(int[] massiv, string text )
            {
                int max = massiv[0];
                int min = massiv[0];
                int sum = 0;
               for (int i=0; i< massiv.Length; i++)
                {
                    if (max < massiv[i]) max = massiv[i];
                    if (min > massiv[i]) min = massiv[i];
                    sum = sum + massiv[i];
                }
                string letter = text.Substring(0, 1);
                return (max, min, sum, letter);
            }
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(task(arr, "valentin"));
        }
    }
}
