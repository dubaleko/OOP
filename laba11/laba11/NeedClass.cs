using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Employee
    {
        public string name  { get; set; }
        public int departmentId { get; set; }

        public Employee(string name, int departmentId)
        {
            this.name = name;
            this.departmentId = departmentId;
        }
    }
    class Department
    {
        public string depname { get; set; }
        public int Id { get; set; }

        public Department(string depname, int Id)
        {
            this.depname = depname;
            this.Id = Id;
        }
    }
    class Phone
    {
        public string name { get; set; }
        public string company { get; set; }
        public int yearofpublic { get; set; }

        public Phone(string name, string company, int yearofpublic)
        {
            this.name = name;
            this.company = company;
            this.yearofpublic = yearofpublic;
        }
    }
}
