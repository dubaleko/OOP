using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Programm
    {
        static void Main()
        {
           Console.WriteLine("Введите день месяц и год");
           int newday = int.Parse(Console.ReadLine());
           int newmonth = int.Parse(Console.ReadLine());
           int newyear = int.Parse(Console.ReadLine());
           Date FirstDate = new Date(newday,newmonth,newyear);
           FirstDate.Day = newday;
           FirstDate.Month = newmonth;
           FirstDate.Year = newyear;
           Date.Info();
           Date.Vyvod(newday, newmonth, newyear);
           Date.DrygoiVyvod(newday, newmonth, newyear);
           Console.WriteLine(FirstDate.GetType());
           Console.WriteLine(FirstDate.ToString());
           Date SecondDate = new Date(20, 10, 2000);
           Console.WriteLine(FirstDate.GetHashCode());
           Console.WriteLine(SecondDate.GetHashCode());
           Console.WriteLine(FirstDate.Equals(SecondDate));
           Console.WriteLine("Размер Массива");
           int razmer = int.Parse(Console.ReadLine());
           Date[] arr = new Date[razmer];
           Random rand = new Random();
            for (int i=0; i < razmer; i++ )
            {
                arr[i] = new Date(rand.Next(1, 31), rand.Next(1, 12), rand.Next(1990, 2020));
            }
           Console.WriteLine("Даты в массиве");
           for (int i=0;i<razmer;i++)
            {
                Console.WriteLine(arr[i]);
            }
           Console.WriteLine("Введите год который хотите найти в списке");
           int secondyear = int.Parse(Console.ReadLine());
           Date takedate = new Date(1, 1, secondyear);
           Console.WriteLine("Список дат в которых есть заданный год:");
            int k = 0; 
           for (int i=0; i<razmer;i++)
            {
                if (takedate.Equals(arr[i]) == true)
                {
                    Console.WriteLine(arr[i]);
                    k++;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Дат с этим годом не обнаружено ");
            }
            Console.WriteLine("Введите число которое нужно искать");
            int chislo = int.Parse(Console.ReadLine());
            Date takeday = new Date(chislo,1,1);
            Date takemonth = new Date(1, chislo, 1);
            Date takeyear = new Date(1, 1, chislo);
            int n = 0;
            if (chislo > 0 && chislo <= 31)
            {
                for (int i = 0; i < razmer; i++)
                {
                    if (takeday.DayEquals(arr[i]) == true)
                    {
                        Console.WriteLine(arr[i]);
                        n++;
                    }
                }
            }
            if (chislo > 0 && chislo <= 12)
            {
                for (int i = 0; i < razmer; i++)
                {
                    if (takemonth.NewEquals(arr[i]) == true)
                    {
                        Console.WriteLine(arr[i]);
                        n++;
                    }
                }
            }
            for (int i = 0; i < razmer; i++)
            {
                if (takeyear.Equals(arr[i]) == true)
                {
                    Console.WriteLine(arr[i]);
                    n++;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Такого числа в датах нету");
            }
            Console.WriteLine("Анонимный тип");
            var data = new { Day = 10, Month = 10, Year = 2000 };
            Console.WriteLine($"{data.Day}/{data.Month}/{data.Year}"); 

        }
    }
}