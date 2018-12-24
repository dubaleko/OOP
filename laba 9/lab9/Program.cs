using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program : Direktor
    {
        delegate void Raise(Teacher tch);
        delegate void Fine(Teacher tch);
        static void Main(string[] args)
        { 
            string mystr = new string('_', 120);
            Direktor direktor = new Direktor();
            Teacher teacher1 = new Teacher("Татьяна", 500);
            Teacher teacher2 = new Teacher("Евгений", 500);
            Raisesalary hd = teacher1.Raise;
            hd();
            direktor.Getfine += teacher1.Fine;
            direktor.Getsalary += teacher1.Raise;
            direktor.Getsalary += teacher2.Raise;
            Console.WriteLine(mystr);
            Console.WriteLine("Teacher before Pay Day:");
            teacher1.GetInfoAboutTeacher();
            teacher2.GetInfoAboutTeacher();
            direktor.Startevent();
            Console.WriteLine(mystr);
            Console.WriteLine("Teacher after Pay Day:");
            teacher1.GetInfoAboutTeacher();
            teacher2.GetInfoAboutTeacher();
            Console.WriteLine(mystr);
            Console.WriteLine("Work with Action and Func:");
            string str = "Go test, this, text now.";
            Action<string> workwithstring = (s) => Console.WriteLine(s);
            workwithstring(str);
            Func<string, string> function = Direktor.ToUpperCase;
            workwithstring(str = function(str));
            function += Direktor.DeleteChaseMarks;
            workwithstring(str = function(str));
            function += Direktor.AddText;
            workwithstring(str = function(str));
            function += Direktor.DeleteSpaces;
            workwithstring(str = function(str));
            function += Direktor.ToLowerCase;
            workwithstring(str = function(str));
            Console.WriteLine(mystr);
        }
    }
}