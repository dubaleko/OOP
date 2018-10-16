using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   abstract class Plant : Object , Paper , Posy 
    {
        public string typeofpaper{get;set;}
        public string typeofposy { get; set;}
        public string typeofrazmer { get; set; }
        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Type of Paper :{typeofpaper} TypeofPosy :{typeofposy} TypeofRazmer :{typeofrazmer}");
        }
        protected Plant(string typeofpaper , string typeofposy , string typeofrazmer)
        {
            this.typeofpaper = typeofpaper;
            this.typeofposy = typeofposy;
            this.typeofrazmer = typeofrazmer;
        }
        bool Paper.Metod()
        {
            bool c = true;
            return c;
        }
        void  Posy.Metod()
        {
            Console.WriteLine("Совсем другая реализация навязанного задания ");
        }
        public override int GetHashCode()
        {
            return 18;
        }
        public override string ToString()
        {
            return "Plant";
        }
        public override bool Equals(object obj)
        {
            return !base.Equals(obj);
        }
    }
}
