using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Direktor
    {
        public delegate void Raisesalary();
        public event Raisesalary Getsalary;

        public delegate void GiveFine();
        public event GiveFine Getfine;
        public void Startevent()
        {
            Getsalary();
            Getfine();
        }
        public static string ToUpperCase(string str) => str.ToUpper();
        public static string AddText(string str)
        {
            string mystr = "AddTextInString:";
            str = mystr + str;
            return str;
        }
        public static string DeleteChaseMarks(string str)
        {
            string  newstr = "";
            foreach (char symb in str)
            {
                if (symb == ',' || symb == '.' || symb == '-' ||  symb ==':')
                continue;
                newstr += symb;
            }
            return newstr;
        }
        public static string DeleteSpaces(string str)
        {
            string newstr = "";
            foreach (char symb in str)
            {
                if (symb == ' ')
                continue;
                newstr += symb;
            }
            return newstr;
        }
        public static string ToLowerCase(string str) => str.ToLower();
    }
}
