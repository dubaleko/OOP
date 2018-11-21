using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace laba10
{
    class Plant
    {
        public string latinname { get; set; }
        public string colorofplant { get; set; }
        public int coast { get; set; }

        public virtual void GetInfoAboutPlant()
        {
            Console.WriteLine($"Latin name: {latinname}; Color of plant: {colorofplant}; Coast: {coast} by rub");
        }
        public Plant(string latinname, string colorofplant, int coast)
        {
            this.latinname = latinname;
            this.colorofplant = colorofplant;
            this.coast = coast;
        }
    }
}
