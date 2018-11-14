using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Teacher
    {
        public string namе { get; set; }
        public int salary { get; set; }
        public Teacher(string name, int salary)
        {
            this.namе = name;
            this.salary = salary;
        }
        public void GetInfoAboutTeacher()
        {
            Console.WriteLine($"Name of Teacher: {namе}, Salary of Teacher: {salary}");
        }
        public void Raise()
        {
            salary = salary + 100;
        }
        public void Fine()
        {
            salary = salary - 25;
        }
    }
}
