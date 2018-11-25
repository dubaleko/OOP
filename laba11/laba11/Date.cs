using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Date
    {
        public int day { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public void getdate()
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
