using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant bush = new Bush("Неописуемая бумага","Никаких букетов из кустов", "Большой размер ");
            Plant kaktus = new Kaktus("Новая бумага", "Красивый букет", "Небольшой размер", "Благородные листья");
            Plant rose = new Rose("Cвежая бумага", "Букет для дамы", "Размер не выжен", "Божественные листья");
            Plant gladiolus = new Gladiolus("Нельзя пускать такой цветок на бумагу", "Букет для твоего бро", "Какой-то там размер", "Невообразимые листья");
            Console.WriteLine("Information about bush");
            bush.GetInfoAboutPlant();
            Console.WriteLine("Information about kaktus");
            kaktus.GetInfoAboutPlant();
            Console.WriteLine("Information about rose");
            rose.GetInfoAboutPlant();
            Console.WriteLine("Information about gladiolus");
            gladiolus.GetInfoAboutPlant();
            Console.WriteLine("Metods with one name :");
            Posy roza = new Rose("бумага как бумага", "цветной букет", "Смешной размер", "Листики");
            roza.Metod();
            Paper glad = new Gladiolus("beautifil paper", "amazing posy", "big gabarits", "Nice List");
            Console.WriteLine(glad.Metod());
            if (glad is Posy)
                Console.WriteLine("it's a Posy type");
            else
                Console.WriteLine("Oh no i'ts are not Posy type");
            if (glad is Paper)
                Console.WriteLine("it's a Paper type");
            else
                Console.WriteLine("Sorry i'ts are not Paper type");             
            Object someObj = gladiolus;
            glad = someObj as Gladiolus;
            if (glad != null)
                Console.WriteLine("Wow it's good");
            else
                Console.WriteLine("O no i'ts a very bad");
            object[] ListOfObjescts = new object[] { bush, kaktus, rose, gladiolus };
            foreach (Paper cap in ListOfObjescts)
                Printer.iAmPrinting(cap);

        }
    }
}
