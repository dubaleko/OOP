using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Lab12
{
    static class Reflector
    {
        public static void WriteClassInfo()
        {
            Type type = typeof(MyType);
            StreamWriter file = new StreamWriter("ClassInfo.txt");
          
            foreach (var item in type.GetMembers())
            {
                file.WriteLine(item.Name);
            }

            file.Close();
        }

        public static void ClassPublicMethods(string className)
        {
            Type type = Type.GetType(className);

            foreach (var item in type.GetMethods(BindingFlags.Instance | BindingFlags.Public ))
            {
                Console.WriteLine(item);
            }
        }

        public static void PropertiesAndFields()
        {
            Type type = typeof(MyType);

            Console.WriteLine("---- Fields of MyType:");
            foreach (var item in type.GetFields())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---- Properties of MyType:");
            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item);
            }
        }

        public static void InterfacesInClass()
        {
            Type type = typeof(MyType);

            foreach (var item in type.GetInterfaces())
            {
                Console.WriteLine(item);
            }
        }

        public static void MethodsByParametres(string className, string param)
        {
            Type type = Type.GetType(className);

            foreach (var item in type.GetMethods())
            {
                foreach (var par in item.GetParameters())
                {
                    if (par.ToString() == param)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
        public static void InvokeMetod(string className , string metodName)
        {
            string path = @"D:\Labs\OOP\laba12\laba12\file.txt";
            string parm;
            List<string> parm1 = new List<string>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
              parm = sr.ReadToEnd();
            }
            string[] words = parm.Split(new char[] { '\n' });
            foreach (string s in words)
            {
                parm1.Add(s);
            }
            Type type = Type.GetType(className);
            var metod = type.GetMethod(metodName);
            object obj = Activator.CreateInstance(type); //создание экземпляра метода
            metod.Invoke(obj, new object[] {parm1[0].ToString(), parm1[1].ToString()});
        }
    }
}