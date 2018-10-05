using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
   partial class Date
    { 
     //Поля 
     private  int day;
     private  int month;
     public   int year;
     private static int numberofobjects = 0;
     public readonly int ID;
     //Свойства 
     public int Day
       {
            get
            {
                return day;
            }
            set
            {
                if (value > 1  && value <= 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("Неверно введенный день");
                }
            }
        }
       public  int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Неверно введенный месяц");
                }   
            }
        }
       public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Неверно введенный год");
                }
            }
        }
       public  static int NumberofObjects
        {
            get
            {
                return numberofobjects;
            }
        }
       //Методы
        public static void Info()
        {
            Console.WriteLine($"Из класса Date создано {numberofobjects} экземпляров.");
        }
        public static void Vyvod(int day, int month, int year)
        {
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 0)
            {
                Console.WriteLine($"{day}/{month}/{year}");
            }
        }
        public static void DrygoiVyvod(int day, int month, int year)
        {
            if (day > 0 && day <= 31 && month > 0 && month <= 12 && year > 0)
            {
                if (month == 1) Console.WriteLine($"{day} января {year} года");
                if (month == 2) Console.WriteLine($"{day} февраля {year} года");
                if (month == 3) Console.WriteLine($"{day} марта {year} года");
                if (month == 4) Console.WriteLine($"{day} апреля {year} года");
                if (month == 5) Console.WriteLine($"{day} мая {year} года");
                if (month == 6) Console.WriteLine($"{day} июня {year} года");
                if (month == 7) Console.WriteLine($"{day} июля {year} года");
                if (month == 8) Console.WriteLine($"{day} августа {year} года");
                if (month == 9) Console.WriteLine($"{day} сентября {year} года");
                if (month == 10) Console.WriteLine($"{day} октября {year} года");
                if (month == 11) Console.WriteLine($"{day} ноября {year} года");
                if (month == 12) Console.WriteLine($"{day} декабря {year} года");
            }
        }
        public bool DayEquals(object obj)
        {
            Date date = (Date)obj;
            return this.day == date.day;
        }
        public  bool NewEquals(object obj)
        {
            Date date = (Date)obj;
            return this.month == date.month;
        }
        public void  Mnozitel(ref int day,ref int month,out int chislo)
        {
            chislo = day * month;
        }
        //Конструкторы
        private Date()
        {
            Console.WriteLine("Какой-то текст который запихнут в конструктор не обращайте внимание");
        }
        static Date() { }
        public Date(int day, int month, int year)
        {
            if (day > 0 && day <= 31)
            {
                this.day = day;
            }
            if (month > 0 && month <= 12)
            {
                this.month = month;
            }
            if (year > 0)
            {
                this.year = year;
            }
            numberofobjects++;
            ID = GetHashCode();
        }

        //Переопределение
        public override int GetHashCode()
        {
            return Day.GetHashCode();
        }
        public override string ToString()
        {
            return $"{day} день {month} месяца {year} года";
        }
        public override bool Equals(object obj)
        {
            Date date = (Date)obj;
            return this.year == date.year;
        }

    }
}