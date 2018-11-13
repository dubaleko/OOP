using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    class Plant
    {
        public string latinname { get; set; }
        public string colorofplant { get; set; }
        public string typeofrazmer { get; set; }
        public int coast { get; set; }
        public Plant(string latinname, string colorofplant, string typeofrazmer, int coast)
        {
            this.latinname = latinname;
            this.colorofplant = colorofplant;
            this.typeofrazmer = typeofrazmer;
            this.coast = coast;
        }
        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Latin name :{latinname} Type of Posy :{colorofplant} Type of Razmer :{typeofrazmer} Coast:{coast} by rub");
        }
    }
}
