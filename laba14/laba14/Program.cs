using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace laba14
{
    class Program 
    {
        static void Main(string[] args)
        {
            string str = new string('_', 120);
            Plant pl = new Plant("kaktus", "green", 15);
            //Binary
            Console.WriteLine(str);
            Console.WriteLine("Binary Serealization");
            BinaryFormatter binformat = new BinaryFormatter();
            //поток для сериализованного объекта
            using (Stream fstream = new FileStream("plants.dat", FileMode.Create, FileAccess.Write))
            {
                binformat.Serialize(fstream, pl);
            }
            //десериализация
            using (FileStream fs = new FileStream("plants.dat", FileMode.OpenOrCreate))
            {
                Plant newplant = (Plant)binformat.Deserialize(fs);
                newplant.GetInfoAboutPlant();
            }
            Console.WriteLine(str);
            //Soap
            Console.WriteLine("Soap Serealization");
            Plant pm = new Plant("rose", "red", 20);
            SoapFormatter soap = new SoapFormatter();
            //поток для сериализованного объекта
            using (Stream fstream = new FileStream("Soap.dat", FileMode.Create, FileAccess.Write))
            {
                soap.Serialize(fstream, pm);
            }
            //десереализация
            using (FileStream fs = new FileStream("Soap.dat", FileMode.OpenOrCreate))
            {
                Plant newplant = (Plant)soap.Deserialize(fs);
                newplant.GetInfoAboutPlant();
            }
            Console.WriteLine(str);
            //Xml
            Console.WriteLine("Xml Serealization");
            Plant ps = new Plant("gladiolus", "blue", 14);
            XmlSerializer xSer = new XmlSerializer(typeof(Plant));
            //поток для сериализации
            using (Stream fstream = new FileStream("plants.xml", FileMode.Create, FileAccess.Write))
            {
                xSer.Serialize(fstream, ps);
            }
            //десереализация
            using (FileStream fs = new FileStream("plants.xml", FileMode.OpenOrCreate))
            {
                Plant newP = xSer.Deserialize(fs) as Plant;
                newP.GetInfoAboutPlant();
            }
            Console.WriteLine(str);
            //Json
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Plant));
            Console.WriteLine("JSON Serealization");
            Plant pv = new Plant("opacha", "yellow", 12);
            //поток для сериализации
            using (FileStream fstream = new FileStream("plant.json", FileMode.OpenOrCreate))
            {

                jsonSerializer.WriteObject(fstream, pv);
            }
            //десериализация
            using (FileStream stream = new FileStream("plant.json", FileMode.OpenOrCreate))
            {
                Plant someplant = (Plant)jsonSerializer.ReadObject(stream);
                someplant.GetInfoAboutPlant();
            }
            Console.WriteLine(str);
            //Collection
            Console.WriteLine("Collection");
            XmlSerializer col = new XmlSerializer(typeof(List<Plant>));
            List<Plant> coll = new List<Plant>();
            coll.Add(new Plant("hyacinthum", "purple", 24));
            coll.Add(new Plant("agrimony", "green",5));
            coll.Add(new Plant("chrysanthemum", "blue",16));
            //поток для сериализации
            using (FileStream topStream = new FileStream("Collection.xml", FileMode.Create))
            {
                col.Serialize(topStream, coll);
            }
            //десериализацция
            using (FileStream topStream = new FileStream("Collection.xml", FileMode.OpenOrCreate))
            {
                List<Plant> someplants = (List<Plant>)col.Deserialize(topStream);
                foreach (var item in someplants)
                {
                    item.GetInfoAboutPlant();
                }
            }
            Console.WriteLine(str);
            //xPath
            Console.WriteLine("XPath");
            XmlDocument document = new XmlDocument();
            document.Load("Collection.xml");
            //выберем узел
            XmlNode xmlRoot = document.SelectSingleNode("ArrayOfPlant");
            XmlNodeList xml = xmlRoot.SelectNodes("Plant");
            Console.WriteLine("Latin name of plants:");
            foreach (XmlNode item in xml)
            {
                Console.WriteLine(item.SelectSingleNode("latinname").InnerText);
            }
            Console.WriteLine("\nAnd his coast:");
            foreach (XmlNode item in xml)
            {
                Console.WriteLine(item.SelectSingleNode("coast").InnerText);
            }
            Console.WriteLine(str);
            //Linq to Xml
            Console.WriteLine("Linq to XML");
            XDocument mygames = new XDocument();               //Create document
            XElement root = new XElement("Games");             //Create root
            XElement game;                                     //Create game element
            XElement name;                                     //Create name element
            XAttribute year;                                   //Create year attribute
            // first game element
            game = new XElement("game");
            name = new XElement("name");
            name.Value = "GS GO";
            year = new XAttribute("year", "2012");
            game.Add(name);
            game.Add(year);
            root.Add(game);
            //second game element
            game = new XElement("game");
            name = new XElement("name");
            name.Value = "Overwatch";
            year = new XAttribute("year", "2016");
            game.Add(name);
            game.Add(year);
            root.Add(game);
            //third game element
            game = new XElement("game");
            name = new XElement("name");
            name.Value = "Rainbow Six Siege";
            year = new XAttribute("year", "2015");
            game.Add(name);
            game.Add(year);
            root.Add(game);
            mygames.Add(root);
            mygames.Save("World games.xml");           //Save file
            //Query
            Console.WriteLine("Pls enter need year: ");
            string yearXML = Console.ReadLine();
            var allgames = root.Elements("game");
            foreach (var item in allgames)
            {
                if (item.Attribute("year").Value == yearXML)
                {
                    Console.WriteLine($"Name of game: {item.Value}");
                }
            }
        }
    }
}
