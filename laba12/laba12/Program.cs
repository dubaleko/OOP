using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.WriteClassInfo();
       
            Console.WriteLine("---- MyType:");
            Reflector.ClassPublicMethods("Lab12.MyType");

            Console.WriteLine("\n---- Reflector:");
            Reflector.ClassPublicMethods("Lab12.Reflector");

            Console.WriteLine();
            Reflector.PropertiesAndFields();

            Console.WriteLine("\n---- Interfaces in MyType:");
            Reflector.InterfacesInClass();

            Console.WriteLine("\n---- Methods with specified param:");
            Reflector.MethodsByParametres("Lab12.MyType", "Int32 value");

            Console.WriteLine("\n---- Invoke metod:");
            Reflector.InvokeMetod("Lab12.MyType", "ReturnText");
        }
    }
}