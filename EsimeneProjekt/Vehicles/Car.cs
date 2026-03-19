using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt.Vehicles
{
    public class Car : Vehicle
        //Kasutades koolonit, saab anda klassile "Car" päriluse abil teisest klassist omadusi ning meetodeid
        //Antud juhul saadakse päriluse abil info klassist "Vehicle".
        //Uuele klassile "Car" saab anda lisaomadusi mida klassi "Vehicle" sees ei ole, ning mis täpsustab
        //antud klassi olemust.
    {
        public int BootVolume { get; set; } //omadus mida klassis "Vehicle" ei ole, ning on omane pigem tavalisele
        //sõiduautole
        public int SeatCount { get; set; }//omadus mida klassis "Vehicle" ei ole, ning on omane pigem tavalisele
        //sõiduautole
        public Car(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }
    }
}
