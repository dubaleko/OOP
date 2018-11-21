using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Student
    {
        public string name { get; set; }
        public string secondname { get; set; }
        public int age { get; set; }

        public virtual void GetInfoAboutStudent()
        {
            Console.WriteLine($"Name: {name} Second name: {secondname} Age: {age} years");
        }
        public Student(string name,  string secondname, int age)
        {
            this.age = age;
            this.name = name;
            this.secondname = secondname;
        }
    }
}
