using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   abstract partial class Plant : Object , Color , Latinname
    {
        public string latinname{get;set;}
        public string colorofplant { get; set;}
        public string typeofrazmer { get; set; }
        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Latin name :{latinname} Type of Posy :{colorofplant} Type of Razmer :{typeofrazmer}");
        }
        protected Plant(string latinname , string colorofplant , string typeofrazmer)
        {
            this.latinname = latinname;
            this.colorofplant = colorofplant;
            this.typeofrazmer = typeofrazmer;
        }
        void Color.Metod()
        {
            Console.WriteLine("One implementation of one name Metod");
        }
         void Latinname.Metod()
        {
            Console.WriteLine("Second implementation of one name Metod");
        }
    }
}
