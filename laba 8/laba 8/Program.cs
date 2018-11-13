using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_8
{
  class Program
  {
     static void Main(string[] args)
     {
      string str = new string('_', 120);
        try
        {
         Console.WriteLine(str);
         Plant roze = new Plant("Rosa", "Red", "Big", 10);
         Plant gladiolus = new Plant("Gladiolus", "Blue", "Little", 15);
         CollectionType<Plant> collectionType = new CollectionType<Plant>();
         collectionType.Add(gladiolus);
         collectionType.Add(roze);
         Console.WriteLine("Consist of Collection:");
        foreach (Plant plant in collectionType.Show())
        {
         plant.GetInfoAboutPlant();
        }
        collectionType.Remove(gladiolus);
        collectionType.Remove(roze);
        Console.WriteLine(str);
        Console.WriteLine("Check consist of Collection:");
        collectionType.CheckCollection();
        }
        catch(Exception ex)
        {
        Console.WriteLine(ex.Message);
        }
        finally
        {
         Console.WriteLine(str);
         Console.WriteLine("Content file.txt:");
         Plant kaktus = new Plant("Kaktus", "Green", "Big", 40);
         CollectionType<Plant> collectionType = new CollectionType<Plant>();
         collectionType.Add(kaktus);
         CollectionType<Plant>.ClearFile();
         CollectionType<Plant>.WriteInFile(kaktus);
         CollectionType<Plant>.ReadfromFile();
         Console.WriteLine(str);
        }
     }
  }
}
