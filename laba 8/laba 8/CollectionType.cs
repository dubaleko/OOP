using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_8
{
   class CollectionType<T> : Interface<T>  where T : Plant
   {
    
     private List<T> collection = new List<T>();
     public void Add(T element)
     {
      collection.Add(element);
     }
     public void Remove(T element)
     {
      collection.Remove(element);
      }
     public List<T> Show()
     {
      return collection;
     }
     public void CheckCollection()
     {
       if (collection.Count == 0) throw new Exception("You list is clear sorry =( ");
       else Console.WriteLine("This List has objects");
     }

     private static string path = @"D:/Labs/OOP/laba 8/laba 8/file.txt";
     public static void ReadfromFile()
     {
     StreamReader streamReader = new StreamReader(path);
     Console.WriteLine(streamReader.ReadToEnd());
     streamReader.Close();
     }
     public static void WriteInFile(T element)
     {
      StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default);
      object obj = element as Plant;
      Plant plant = (Plant)obj;
      streamWriter.WriteLine($"Latin Name: {plant.latinname}, Color: {plant.colorofplant}, Size: {plant.typeofrazmer}, Coast: {plant.coast} by rub;");
      streamWriter.Close();
     }
     public static void ClearFile()
     {
     FileStream fileStream = new FileStream(path, FileMode.Truncate);
     fileStream.Close();
     }

    }
}

