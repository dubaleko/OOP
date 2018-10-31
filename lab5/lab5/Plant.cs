using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   abstract partial class Plant : Object , Color , Latinname
    {
        public int coast;
        public string latinname{get;set;}
        public string colorofplant { get; set;}
        public string typeofrazmer { get; set; }
        public int Coast
        {
            get
            {
                return coast;
            }
            set
            {
                if(coast >= 500)
                {
                    throw new DateError("Ну не могут столько стоить цветы");
                }
                else
                {
                    coast = value;
                }
            }
        }
        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Latin name :{latinname} Type of Posy :{colorofplant} Type of Razmer :{typeofrazmer} Coast:{coast} by rub");
        }
        protected Plant(string latinname , string colorofplant , string typeofrazmer , int coast)
        {
            this.latinname = latinname;
            this.colorofplant = colorofplant;
            this.typeofrazmer = typeofrazmer;
            this.coast = coast;
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
