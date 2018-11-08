using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab5
{
    struct SomebodyStruct
    {
        public string Latinname;
        public int Coast;

        public void DisplayNameAndCoast() => Console.WriteLine($"Latinname: {Latinname} coast: {Coast} by rub");

        public SomebodyStruct(string Latinname, int Coast)
        {
            this.Latinname = Latinname;
            this.Coast = Coast;
        }
    }
    enum MyEnum
    {
        Hello = 1 , My , Name , Valentin,
    }
    class Program
    {
        static string s = new string('/', 120);
        static string str = new string('_', 120);
        static void Main(string[] args)
        {
            Console.WriteLine(s);
            Console.WriteLine("Laboratornya 5: ");
            Console.WriteLine(str);
            Plant bush = new Bush("Bush", "green", "Normal size",10);
            Plant kaktus = new Kaktus("Cactus", "yellow", "Average" , 15);
            Plant rose = new Rose("Rosa", "red", "No't bad size", 50);
            Plant gladiolus = new Gladiolus("Gladiolus", "blue", "Pefect size",30);
            Console.WriteLine("Information about bush");
            bush.GetInfoAboutPlant();
            Console.WriteLine("Information about kaktus");
            kaktus.GetInfoAboutPlant();
            Console.WriteLine("Information about rose");
            rose.GetInfoAboutPlant();
            Console.WriteLine("Information about gladiolus");
            gladiolus.GetInfoAboutPlant();
            Console.WriteLine(str);
            Console.WriteLine("Metods with one name :");
            Latinname roza = rose;
            roza.Metod();
            Color glad = gladiolus;
            glad.Metod();
            Console.WriteLine(str);
            Console.WriteLine("Using in the code is and as");
            if (glad is Color)
                Console.WriteLine("it's a Year type");
            else
                Console.WriteLine("Oh no i'ts are not Year type");
            if (glad is Latinname)
                Console.WriteLine("it's a Latinname type");
            else
                Console.WriteLine("Sorry i'ts are not Latinname type");             
            Object someObj = gladiolus;
            glad = someObj as Gladiolus;
            if (glad != null)
                Console.WriteLine("Wow it's good");
            else
            Console.WriteLine("O no i'ts a very bad");
            Console.WriteLine(str);
            Console.WriteLine("Array of plants:");
            object[] ListOfObjescts = new object[] { bush, kaktus, rose, gladiolus };
            foreach (Latinname cap in ListOfObjescts)
            Printer.iAmPrinting(cap);
            Console.WriteLine(str);
            Console.WriteLine(s);
            Console.WriteLine("Laboratornya 6:");
            Console.WriteLine(str);
            MyEnum enume = MyEnum.Hello;
            Console.WriteLine("Implementation of ENUM:");
            for (int i =0; i < 4; i++)
            {
                Console.WriteLine(enume+" ");
                enume++;
            }
            Console.WriteLine(str);
            SomebodyStruct odv = new SomebodyStruct("APHACA", 1);
            Console.WriteLine("Implementation of STRUCT:");
            odv.DisplayNameAndCoast();
            Console.WriteLine(str);
            Posy posy = new Posy();
            posy[0] = rose;
            posy[1] = gladiolus;
            posy[2] = kaktus;
            Console.WriteLine("Posy consist:");
            posy.OutputPosy();
            Console.WriteLine(str);
            posy.Delete(2);
            Console.WriteLine("Posy consist without 1 flower:");
            posy.OutputPosy();
            Console.WriteLine(str);
            posy.Coast(posy);
            Console.WriteLine(str);
            Console.WriteLine("Sorting of posy by price:");
            posy.Sortirovka(posy);
            Console.WriteLine(str);
            posy.ColorofFlower(posy);
            Console.WriteLine(str);
            Console.WriteLine(s);
            Console.WriteLine("Laboratornya 7:");
            Console.WriteLine(str);
            Console.WriteLine("Exception №1");
            try
            {
                Plant kust = new Bush("Bush", "orange", "Normal size", 600);
                if (kust.coast > 500 ) throw new СoastException();            
            }
            catch(СoastException ex)
            {
                Console.WriteLine($"Type of Error: {ex.typeoferror}");
                Console.WriteLine($"Type of exception: {ex.typeofexception}");
                Console.WriteLine($"Message of Error: {ex.message}");
                Console.WriteLine($"Time of triggering of error: {ex.time}");
            }
            finally
            {
                Console.WriteLine("Example of block finally");
            }
            Console.WriteLine(str);
            Console.WriteLine("Exception №2");
            try
            {
                Plant rosa = new Rose("Rosa", "black", "Little size", 150);
                if (rosa.colorofplant.Equals("blue") == false && rosa.colorofplant.Equals("red") == false &&
                    rosa.colorofplant.Equals("orange") == false && rosa.colorofplant.Equals("yellow") == false &&
                    rosa.colorofplant.Equals("white") == false && rosa.colorofplant.Equals("pink") == false)
            throw new ColorException();
            }
            catch (ColorException ex)
            {
                Console.WriteLine($"Type of Error: {ex.typeoferror}");
                Console.WriteLine($"Type of exception: {ex.typeofexception}");
                Console.WriteLine($"Message of Error: {ex.message}");
                Console.WriteLine($"Time of triggering of error: {ex.time}");
            }
            finally
            {
                Console.WriteLine("Example of block finally");
            }
            Console.WriteLine(str);
            Console.WriteLine("Exception №3");
            try
            {
                Plant kaktusik = new Gladiolus("Kaktus", "green", "A very long description about little size of kaktus", 210);
                if  (kaktusik.typeofrazmer.Length > 20) throw new SizeException();
            }
            catch(SizeException ex)
            {
                Console.WriteLine($"Type of Error: {ex.typeoferror}");
                Console.WriteLine($"Type of exception: {ex.typeofexception}");
                Console.WriteLine($"Message of Error: {ex.message}");
                Console.WriteLine($"Time of triggering of error: {ex.time}");
            }
            finally
            {
                Console.WriteLine("Example of block finally");
            }
            Console.WriteLine(str);
            Console.WriteLine("Exception №4");
            try
            {
                Console.WriteLine("Enter x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y:");
                int y = int.Parse(Console.ReadLine());
                int c = x / y;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Message of Error: {ex.Message}");
            }
            Console.WriteLine(str);
            Console.WriteLine("Exception №5");
            try
            {
             int[] arr = new int[5];
             Random rand = new Random();
             for (int i= 0; i< 6; i++)
             {
               arr[i] = rand.Next(0, 10);
             }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message of Error: {ex.Message}");
            }
            Plant gladus = new Gladiolus("Gladiolus", "blue", "Good size", 700);
            gladus.DebugMetod(gladus);
            Console.WriteLine(str);
            Console.WriteLine(s);
        }
    }
}
