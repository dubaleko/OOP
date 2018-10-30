using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Labs 5:");
            Plant bush = new Bush("Bush", "green", "Normal size");
            Plant kaktus = new Kaktus("Cactus", "yellow", "Average" , 15);
            Plant rose = new Rose("Rosa", "red", "No't bad size", 20);
            Plant gladiolus = new Gladiolus("Gladiolus", "blue", "Pefect size",30);
            Console.WriteLine("Information about bush");
            bush.GetInfoAboutPlant();
            Console.WriteLine("Information about kaktus");
            kaktus.GetInfoAboutPlant();
            Console.WriteLine("Information about rose");
            rose.GetInfoAboutPlant();
            Console.WriteLine("Information about gladiolus");
            gladiolus.GetInfoAboutPlant();
            Console.WriteLine("Metods with one name :");
            Latinname roza = rose;
            roza.Metod();
            Color glad = gladiolus;
            glad.Metod();
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
            Console.WriteLine("Array of plants");
            object[] ListOfObjescts = new object[] { bush, kaktus, rose, gladiolus };
            foreach (Latinname cap in ListOfObjescts)
            Printer.iAmPrinting(cap);
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Labs 6:");
            MyEnum enume = MyEnum.Hello;
            Console.WriteLine("Implementation of ENUM:");
            for (int i =0; i < 4; i++)
            {
                Console.WriteLine(enume+" ");
                enume++;
            }
            SomebodyStruct odv = new SomebodyStruct("APHACA", 1);
            Console.WriteLine("Implementation of STRUCT:");
            odv.DisplayNameAndCoast();
            Posy posy = new Posy();
            posy[0] = rose;
            posy[1] = gladiolus;
            posy[2] = kaktus;
            Console.WriteLine("Posy Consist:");
            posy.OutputPosy();

        }
    }
}
