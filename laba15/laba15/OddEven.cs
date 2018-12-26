using System;
using System.Threading;
using System.IO;

namespace Lab15
{
    static class OddEven
    {
        public static void DoItConsistently()
        {
            Object locker = new Object();
            if (File.Exists("OddEvenConsistently.txt"))
            {
                File.Delete("OddEvenConsistently.txt");
            }
            Thread OddThread = new Thread(new ThreadStart(PrintOdd));
            Thread EvenThread = new Thread(new ThreadStart(PrintEven));
            OddThread.Start();
            EvenThread.Start();
            void PrintOdd()
            {
                lock (locker)
                {
                    for (int i = 0; i < 10; i++)
                    {

                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i + " odd");
                            WriteResultToFile(i);
                            Thread.Sleep(250);
                        }
                    }
                }

            }
            void PrintEven()
            {
                lock (locker)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i + " even");
                            WriteResultToFile(i);
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            void WriteResultToFile(int data)
            {
                StreamWriter OddEven = new StreamWriter("OddEvenConsistently.txt", true);
                OddEven.WriteLine(data);
                OddEven.Close();
            }
        }
        public static void DoItOneByOne()
        {
            Mutex mutex = new Mutex();
            if (File.Exists("OddEvenOneByOne.txt"))
            {
                File.Delete("OddEvenOneByOne.txt");
            }
            Thread OddThread = new Thread(new ThreadStart(PrintOdd));
            Thread EvenThread = new Thread(new ThreadStart(PrintEven));
            OddThread.Start();
            EvenThread.Start();
            void PrintOdd()
            {
                for (int i = 0; i < 10; i++)
                {
                    mutex.WaitOne();
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i + " odd");
                        WriteResultToFile(i);
                        Thread.Sleep(250);
                    }
                    mutex.ReleaseMutex();
                }

            }
            void PrintEven()
            {
                for (int i = 0; i < 10; i++)
                {
                    mutex.WaitOne();
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " even");
                        WriteResultToFile(i);
                        Thread.Sleep(500);
                    }
                    mutex.ReleaseMutex();
                }

            }
            void WriteResultToFile(int data)
            {
                StreamWriter OddEven = new StreamWriter("OddEvenOneByOne.txt", true);
                OddEven.WriteLine(data);
                OddEven.Close();
            }
        }
    }
}