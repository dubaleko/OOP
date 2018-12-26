using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Lab15
{
    class Program
    {
        static string st = new string('-', 40);
        static string sw = new string('-', 75);
        static string str = new string('-', 120);
        private static void SecondaryDomain_DomainUnload(object sender, EventArgs e)
        {
            Console.WriteLine("Domain unloaded from process.");
        }
        private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine("Build loaded.");
            Console.WriteLine("List of build:");
        }
        public static void WriteNums(object x)
        {
            int i = 1;
            int n = (int)x;
            using (StreamWriter sw = new StreamWriter("EazyNumbers.txt"))
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
                        Console.WriteLine(i);
                        sw.WriteLine(i);

                    }
                    i++;
                }
            }
        }
        static void Main(string[] args)
        {
            var getprocess = Process.GetProcesses();
            Console.WriteLine(st + "Task1" + sw);
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
            Console.WriteLine("If you need information about process of 1 task pls check file.txt");
            Console.WriteLine(str);

            Console.WriteLine(st + "Task2" + sw);
            Console.WriteLine();
            using (StreamWriter text = new StreamWriter("Domain.txt"))
            {
                //This app analysis
                var thisAppDomain = Thread.GetDomain();
                text.WriteLine($"Name: {thisAppDomain.FriendlyName}");
                text.WriteLine($"Setup Information: {thisAppDomain.SetupInformation.ToString()}");
                text.WriteLine("Assemblies:");
                foreach (var item in thisAppDomain.GetAssemblies())
                {
                    text.WriteLine("    " + item.FullName.ToString());
                }
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
            }

            Console.WriteLine(st + "Task3" + sw);
            Thread NumbersThread = new Thread(new ParameterizedThreadStart(WriteNums));
            NumbersThread.Start(10);
            NumbersThread.Suspend();
            NumbersThread.Name = "Info about MyThread";
            Console.WriteLine("Priority: " + NumbersThread.Priority);
            Thread.Sleep(100);
            Console.WriteLine("Name: " + NumbersThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("ID: " + NumbersThread.ManagedThreadId);
            Console.WriteLine("List of eazy numbers:");
            Thread.Sleep(1000);
            NumbersThread.Resume();
            Thread.Sleep(1000);
            Console.WriteLine(str);

            Console.WriteLine(st + "Task4" + sw);
            Console.WriteLine("Consistently:");
            OddEven.DoItConsistently();
            Thread.Sleep(4000);
            Console.WriteLine("One by one:");
            OddEven.DoItOneByOne();
            Thread.Sleep(4000);
            Console.WriteLine(str);

            Console.WriteLine(st + "Task5" + sw);
            TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(5000);
            void WhatTimeIsIt(object obj)
            {
                Console.WriteLine($"It's {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }
            Console.WriteLine(str);
        }
    }
}