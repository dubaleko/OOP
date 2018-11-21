using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*Arraylist*/

            string mystr = new string('_', 120);
            Random rand = new Random();
            ArrayList arraylist = new ArrayList();
            Console.WriteLine(mystr);
            Console.WriteLine("|Enter data in ArryList|");
            Console.WriteLine("Pls enter five random numbers:");
            for (int i = 0; i < 5; i++)
            {
                int name = int.Parse(Console.ReadLine());
                arraylist.Add(name);
            }
            Console.WriteLine("Pls enter somebody string:");
            string str = Console.ReadLine();
            arraylist.Add(str);
            Student valentin = new Student("Valentin", "Dubaleko", 18);
            arraylist.Add(valentin);
            Console.WriteLine(mystr);
            Console.WriteLine("|Remove element from ArrayList|");
            Console.Write("Pls input type of data which you need to remove[1: int, 2: string]: ");
            int mychoose = int.Parse(Console.ReadLine());
            Console.Write("Pls enter element of ArrayList which need to remove: ");
            if (mychoose == 1)
            {
                int numbremove = int.Parse(Console.ReadLine());
                arraylist.Remove(numbremove); 
            }
            if (mychoose == 2)
            {
                string numbremove = Console.ReadLine();
                arraylist.Remove(numbremove);
            }
            Console.WriteLine(mystr);
            Console.WriteLine("|Data about ArrayList|");
            Console.WriteLine("Amount of elements in ArrayList: "+arraylist.Count);
            Console.WriteLine("Collection ArrayList:");
            object[] vid = arraylist.ToArray();
            foreach (object o in arraylist)
            {
                if (o is Student)
                {
                    valentin.GetInfoAboutStudent();
                    break;
                }
                Console.WriteLine(o);
            }
            Console.WriteLine(mystr);
            Console.WriteLine("|Search value in ArrayList|");
            Console.Write("Pls input type of data which you need to find[1: int, 2: string]: ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.Write("Input searche int data: ");
                var find = int.Parse(Console.ReadLine());
                Console.WriteLine(arraylist.Contains(find));
            }
            if (choose == 2)
            {
               Console.Write("Input searche string data: ");
               var find = Console.ReadLine();
               Console.WriteLine(arraylist.Contains(find));
            }
            Console.WriteLine(mystr);

            //List<float>

            List<float> newlist = new List<float> { 1.5F, 2.6F, 8.2F, 9.4F, 5.6F};
            Console.WriteLine("Collection List<float>:");
            foreach (float o in newlist)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(mystr);
            Console.WriteLine("Remov element from List<float> not more that five");
            Console.Write("Amount of elements for remove: ");
            int range = int.Parse(Console.ReadLine());
            newlist.RemoveRange(0, range);
            Console.WriteLine();
            Console.WriteLine("List<float> after remove:");
            foreach (float o in newlist)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(mystr);
            Console.WriteLine("|Metods to add elements in List|");
            Console.Write("Pls input one float value: ");
            float flt = float.Parse(Console.ReadLine());
            newlist.Add(flt);
            Console.Write("Pls input size of array: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(mystr);
            float[] array = new float[number];
            for (int i=0; i<number; i++)
            {
                double mantisa  = rand.NextDouble();
                array[i] = (float)mantisa;
            }
            newlist.AddRange(array);
            Console.WriteLine("New collection List<float>:");
            foreach (float o in newlist)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(mystr);

            //Stack<float>

            Stack<float> newstack = new Stack<float>();
            foreach (float o in newlist)
            {
                newstack.Push(o);
            }
            Console.WriteLine("Collection Stack<float>:");
            foreach(float o in newstack)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(mystr);
            Console.WriteLine("|Search value in Stack|");
            Console.Write("Pls input searched value: ");
            float indata = float.Parse(Console.ReadLine());
            float[] onearr = newstack.ToArray();
            int numb = 0;
            for (int i = 0; i< onearr.Length; i++)
            {
                if (onearr[i] == indata)
                {
                    Console.WriteLine($"Yes we find this float number in stack  his number: {i+1}");
                }
                else
                {
                    numb++;
                    if (numb == onearr.Length)
                    {
                        Console.WriteLine("Sorry but we don't find this float number in stack");
                    }
                }
            }
            Console.WriteLine(mystr);

            //List<Plant>

            Plant roze = new Plant("Roza", "Red", 50);
            Plant gladiolus = new Plant("Gladiolus", "Blue", 60);
            Plant kaktus = new Plant("Kaktus", "Green", 40);
            Plant apacha = new Plant("Apacha", "Yellow", 20);
            List<Plant> mylist = new List<Plant> { roze, gladiolus, kaktus, apacha};
            Plant[] massiv = mylist.ToArray();
            Console.WriteLine("Collection Stack<Plant>:");
            for (int i=0; i < massiv.Length; i++)
            {
                massiv[i].GetInfoAboutPlant();
            }
            Console.WriteLine(mystr);
            Console.WriteLine("Remov element from List<Plant> not more that four");
            Console.Write("Amount of elements for remove: ");
            int myrange = int.Parse(Console.ReadLine());
            mylist.RemoveRange(0, myrange);
            Plant[] newmassiv = mylist.ToArray();
            Console.WriteLine();
            Console.WriteLine("Collection List<Plant> after remove:");
            for (int i = 0; i < newmassiv.Length; i++)
            {
                newmassiv[i].GetInfoAboutPlant();
            }
            Console.WriteLine(mystr);

            //Stack<Plant>
            Stack<Plant> mystack = new Stack<Plant>();
            foreach (laba10.Plant o in mylist)
            {
                mystack.Push(o);
            }
            Plant[] mymassiv = mystack.ToArray();
            Console.WriteLine("Collection Stack<Plant:>");
            for (int i = 0; i < mymassiv.Length; i++)
            {
                mymassiv[i].GetInfoAboutPlant();
            }
            Console.WriteLine(mystr);
            Console.Write("Select what will be searched[ 1: latinname, 2: color, 3: coast]: ");
            int plchoose = int.Parse(Console.ReadLine());
            if (plchoose == 1)
            {
                Console.Write("Pls enter searched latinname: ");
                string latname = Console.ReadLine();
                Console.WriteLine();
                int k = 0;
                for (int i = 0; i < mymassiv.Length; i++)
                {
                    if(mymassiv[i].latinname == latname)
                    {
                      Console.WriteLine("Information about plant with searchead latinname:");
                      mymassiv[i].GetInfoAboutPlant();
                    }
                    else
                    {
                     k++;
                     if(k == mymassiv.Length)
                     {
                      Console.WriteLine("Sorry  we don't  find element with this latinname in Stack<Plant>");
                     }
                    }
                }
            }
            if (plchoose == 2)
            {
                Console.Write("Pls enter searched color: ");
                string colname = Console.ReadLine();
                Console.WriteLine();
                int k = 0;
                for (int i = 0; i < mymassiv.Length; i++)
                {
                    if (mymassiv[i].colorofplant == colname)
                    {
                        Console.WriteLine("Information about plant with searchead color:");
                        mymassiv[i].GetInfoAboutPlant();
                    }
                    else
                    {
                        k++;
                        if (k == mymassiv.Length)
                        {
                            Console.WriteLine("Sorry  we don't  find element with this color in Stack<Plant>");
                        }
                    }
                }
            }
            if (plchoose == 3)
            {
                Console.Write("Pls enter searche coast: ");
                int coast = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int k = 0;
                for (int i = 0; i < mymassiv.Length; i++)
                {
                    if (mymassiv[i].coast == coast)
                    {
                        Console.WriteLine("Information about plant with searchead coast:");
                        mymassiv[i].GetInfoAboutPlant();
                    }
                    else
                    {
                        k++;
                        if (k == mymassiv.Length)
                        {
                            Console.WriteLine("Sorry  we don't  find element with this coast in Stack<Plant>");
                        }
                    }
                }
            }
            Console.WriteLine(mystr);

            //ObservableCollection<T>

            ObservableCollection<Plant> plants = new ObservableCollection<Plant> { roze, gladiolus, kaktus, apacha };
            Plant Tritaque = new Plant("tritaque", "white", 10);
            Plant Zizania = new Plant("zizania", "green", 5);
            Console.WriteLine("Changes in ObservableCollection<Plant>:");
            plants.CollectionChanged += Plants_CollectionChanged;
            plants.Add(Tritaque);
            plants.RemoveAt(1);
            plants[0] = Zizania;
            Console.WriteLine(mystr);
            Console.WriteLine("ObservableCollection<Plant>");
            foreach (Plant plant in plants)
            {
                plant.GetInfoAboutPlant();
            }
            Console.WriteLine(mystr);

            void Plants_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        Plant newPlant = e.NewItems[0] as Plant;
                        Console.WriteLine($"Add new object: {newPlant.latinname}");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        Plant oldUser = e.OldItems[0] as Plant;
                        Console.WriteLine($"Remove object: {oldUser.latinname}");
                        break;
                    case NotifyCollectionChangedAction.Replace: // если замена
                        Plant replacedUser = e.OldItems[0] as Plant;
                        Plant replacingUser = e.NewItems[0] as Plant;
                        Console.WriteLine($"Object {replacedUser.latinname} replced vy object {replacingUser.latinname}");
                        break;
                }
            }
        }
    }
}
