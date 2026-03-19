using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt.Vehicles
{
    public class Truck : Vehicle
    {
        //Kasutades koolonit, saab anda klassile "Truck" päriluse abil teisest klassist omadusi ning meetodeid
        //Antud juhul saadakse päriluse abil info klassist "Vehicle".
        //Uuele klassile "Truck" saab anda lisaomadusi mida klassi "Vehicle" sees ei ole, ning mis täpsustab
        //antud klassi olemust.
        public double Loadweight { get; set; }//omadus mida klassis "Vehicle" ei ole, ning on omane pigem rekkale
        public double EnginePower { get; set; }//omadus mida klassis "Vehicle" ei ole, ning on omane pigem rekkale
        public Truck(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }
    }
}
