using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace laba15
{
    class Program
    {
        static string str = new string('_', 120);
        private static void SecondaryDomain_DomainUnload(object sender, EventArgs e)
        {
            Console.WriteLine("Domain unloaded from process.");
        }
        private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine("Build loaded.");
            Console.WriteLine("List of build:");
        }
        public static void EazyNumb(object x)
        {
            int i = 1;
            int n = (int)x;
            using (StreamWriter sw = new StreamWriter("aloneThread.txt", false, Encoding.Default))
            {
                while (n != i)
                {
                    int z = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            z++;

                        }
                    }
                    if (z == 2)
                    {
                        sw.WriteLine(i);

                    }
                    i++;
                }
            }
        }
        public static void EvenandOddNumb(object x)
        {
            int i = 0;
            List<int> mylist = new List<int>();
            ValueTuple<int, bool> n = (ValueTuple<int, bool>)x;
            while (n.Item1 != i)
                {
                    if (n.Item2 == false)
                    {
                        if (i % 2 == 0)
                        {
                        Console.WriteLine(i);
                        mylist.Add(i);
                        Thread.Sleep(20);
                        }
                    }
                    if(n.Item2 == true)
                    {
                        if (i % 2 != 0)
                        {
                        Console.WriteLine(i);
                        mylist.Add(i);
                        Thread.Sleep(10);
                        }

                    }
                   i++;
                }
            using (StreamWriter sw = new StreamWriter("EvenandOddNumb.txt", false, Encoding.Default))
            {
                foreach (int c in mylist)
                {
                    sw.WriteLine(c.ToString());
                }
            }
        
        }
        static void Main(string[] args)
        {
           
            //get info about process
            var getprocess = Process.GetProcesses();
            Console.WriteLine(str);
            using (StreamWriter sw = new StreamWriter("file.txt", false, Encoding.Default))
            {
                try
                {
                    foreach (var proc in getprocess)
                    {
                        sw.WriteLine("Process: " + proc.Id);
                        sw.WriteLine("Name of process: " + proc.ProcessName);
                        sw.WriteLine("Priority of process: " + proc.BasePriority);
                        sw.WriteLine("Time of start process: " + proc.StartTime);
                        sw.WriteLine("Total using time of process: " + proc.TotalProcessorTime);
                        sw.WriteLine();
                    }
                }
                catch
                {

                }

            }
            Console.WriteLine("Process:");
            Console.WriteLine("If you need information about process of 1 task pls check file.txt");
            Console.WriteLine(str);
            //Domain
            AppDomain secondaryDomain = AppDomain.CreateDomain("Secondary domain");
            //build load event
            secondaryDomain.AssemblyLoad += Domain_AssemblyLoad;
            //domain unload event
            secondaryDomain.DomainUnload += SecondaryDomain_DomainUnload;
            Console.WriteLine($"Domain: {secondaryDomain.FriendlyName}");
            secondaryDomain.Load(new AssemblyName("System.Data"));
            Assembly[] assemblies = secondaryDomain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);
            //unload domain
            AppDomain.Unload(secondaryDomain);
            Console.WriteLine(str);
            //thread with easy numbers
            int number = 20;
            Console.WriteLine("Second thread who was working with easy numbers");
            Thread myThread = new Thread(EazyNumb);
            myThread.Name = "Second thread";
            myThread.Start(number);
            Console.WriteLine("List of easy numbers:");
            Thread.Sleep(0);
            using (StreamReader sr = new StreamReader("aloneThread.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Thread ID:" + myThread.ManagedThreadId.ToString());
            Console.WriteLine("Name of Thread: " + myThread.Name);
            //Console.WriteLine("Priority of Thread: " + myThread.Priority.ToString());
            Console.WriteLine("State of Thread: " + myThread.ThreadState.ToString());
            Console.WriteLine(str);
            myThread.Abort();
            //two thread
            ValueTuple<int, bool> oddnum = (number, true);
            ValueTuple<int, bool> evennum = (number, false);
            Console.WriteLine("Working with 2 Thread");
            Thread evenThread = new Thread(EvenandOddNumb);
            Thread oddThread = new Thread(EvenandOddNumb);
            oddThread.Priority = ThreadPriority.AboveNormal;
            evenThread.Start(evennum);
            oddThread.Start(oddnum);
        }
    }
}
