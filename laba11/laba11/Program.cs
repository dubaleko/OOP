using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = new string('_', 120);
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "Semptember", "October", "November", "December" };

            //LINQ request by size
            Console.WriteLine(mystr);
            Console.WriteLine("LINQ request  by size");
            Console.Write("Pls input need month size: ");
            int monthlength = int.Parse(Console.ReadLine());
            var lengtofmonth = from month in months where month.Length == monthlength select month;
            Console.WriteLine($"Name of month with size {monthlength}:");
            foreach (string month in lengtofmonth)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(mystr);

            //LINQ request for winter and spring month
            Console.WriteLine("LINQ request for winter and spring month");
            var wintandspr = from month in months
                             where month == "January" || month == "February" || month == "December" || month == "March" || month == "April" || month == "May"
                             select month;
            Console.WriteLine("Winter and Spring month:");
            foreach (string month in wintandspr)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(mystr);

            //LINQ request sorting
            Console.WriteLine("LINQ request sorting");
            var sorting = from month in months orderby month select month;
            foreach (string month in sorting)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(mystr);

            //LINQ request letter "u" and size >= 4
            Console.WriteLine("LINQ request letter (u) and size >= 4");
            var letterandsize = from month in months where month.Length >= 4 && month.Contains("u") select month;
            foreach (string month in letterandsize)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(mystr);

            //Collection List<Date>
            Console.WriteLine("Collection List<Date>");
            var data = new List<Date>();
            Date[] datearray = { new Date(1, 1, 2000), new Date(14, 3, 2000), new Date(5, 5, 2000), new Date(23, 7, 2000), new Date(19, 10, 2000), new Date(24, 9, 2000),
                                 new Date(8, 2, 2000), new Date(28, 4, 2000),  new Date(2, 6, 2000), new Date(14, 8, 2000),  new Date(26, 11, 2000), new Date(31, 12, 2000),
                                 new Date(8, 1, 2018),new Date(28, 2, 2018),new Date(2, 3, 2018),new Date(14, 10, 2018),new Date(26, 11, 2018),new Date(27, 12, 2018),
                                 new Date(1, 7, 2018),new Date(14, 8, 2018),new Date(5, 9, 2018),new Date(23, 4, 2018),new Date(19, 5, 2018),new Date(24, 6, 2018),
            };
            data.AddRange(datearray);

            //Data from need year
            Console.WriteLine("Pls input need year");
            int needyear = int.Parse(Console.ReadLine());
            var datayear = from date in data where date.year == needyear select date;
            Console.WriteLine("List data in this year:");
            foreach (Date date in datayear)
            {
                date.getdate();
            }
            Console.WriteLine();

            //Data from need month
            Console.WriteLine("Pls input need month");
            int needmonth = int.Parse(Console.ReadLine());
            var datemonth = from date in data where date.month == needmonth select date;
            Console.WriteLine("List data in this month:");
            foreach (Date date in datemonth)
            {
                date.getdate();
            }
            Console.WriteLine();

            //Data from need range
            Console.WriteLine("Pls input range in format two date [day.month.year]");
            Console.WriteLine("First date:");
            Console.Write("day: ");
            int firstday = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int firstmonth = int.Parse(Console.ReadLine());
            Console.Write("year: ");
            int firstyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Second date:");
            Console.Write("day: ");
            int secondday = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int secondmonth = int.Parse(Console.ReadLine());
            Console.Write("year: ");
            int secondyear = int.Parse(Console.ReadLine());
            var range = from date in data where 
            (date.year > firstyear || date.year == firstyear && date.month > firstmonth || date.year == firstyear && date.month == firstmonth && date.day > firstday) &&
            (date.year < secondyear || date.year == secondyear && date.month < secondmonth || date.year == secondyear && date.month == secondmonth && date.day < secondday)
            select date;
            Console.WriteLine("Data of range:");
            foreach (Date date in range)
            {
                date.getdate();
            }
            Console.WriteLine();

            //First data for day
            Console.WriteLine("Pls input need day");
            int needday = int.Parse(Console.ReadLine());
            var thisday = from date in data where date.day == needday select date;
            Console.Write("Need date: ");
            foreach (Date date in thisday)
            {
                date.getdate();
                break;
            }
            Console.WriteLine();

            //Sort List<Date>
            Console.WriteLine("Sort List<Date>");
            var newsort = from date in data
                        orderby date.year, date.month, date.day
                        select date;
            foreach (Date date in newsort)
            {
                date.getdate();
            }
            Console.WriteLine();

            //Max value
            Console.Write("Max value: ");
            var maxvalue = newsort.Last();
            maxvalue.getdate();
            Console.WriteLine(mystr);

            //Join request
            Console.WriteLine("Join request");
            List<Employee> employee = new List<Employee> { new Employee("Nikita", 1), new Employee("Vitya", 2), new Employee("Mary", 3)};
            List<Department> department = new List<Department> { new Department("HS", 1), new Department("OW", 2), new Department("WOW", 3)};
            var emp = from dep in department
                      join em in employee on dep.Id equals em.departmentId into mygroup
                      select new { Depart = dep.depname, Employees = mygroup };
            foreach(var dep in emp)
            {
                Console.Write("department :"+dep.Depart);
                foreach(var em in dep.Employees)
                {
                    Console.WriteLine(" name of employee :"+em.name);
                }
            }
            Console.WriteLine(mystr);

        }
    }
}
