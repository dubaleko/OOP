using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   abstract partial class Plant : Object , Year , Latinname
    {
        public string latinname{get;set;}
        public string yearofplant { get; set;}
        public string typeofrazmer { get; set; }
        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Latin name :{latinname} Type of Posy :{yearofplant} Type of Razmer :{typeofrazmer}");
        }
        protected Plant(string latinname , string yearofplant , string typeofrazmer)
        {
            this.latinname = latinname;
            this.yearofplant = yearofplant;
            this.typeofrazmer = typeofrazmer;
        }
        void Year.Metod()
        {
            Console.WriteLine("One implementation of one name Metod");
        }
         void Latinname.Metod()
        {
            Console.WriteLine("Second implementation of one name Metod");
        }
    }
}
