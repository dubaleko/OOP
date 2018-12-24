using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba14
{
    [DataContract]
    [Serializable]
    public class Plant
    {
        [DataMember]
        public string latinname { get; set; }
        [DataMember]
        public string colorofplant { get; set; }
        [DataMember]
        public int coast { get; set; }
        public virtual void GetInfoAboutPlant()
        {
          Console.WriteLine($"Latin name: {latinname} Color: {colorofplant}  Coast: {coast} by rub");
        }
        public Plant()
        {

        }
        public Plant(string latinname, string colorofplant,  int coast)
        {
          this.latinname = latinname;
          this.colorofplant = colorofplant;
          this.coast = coast;
        }
    }
}
