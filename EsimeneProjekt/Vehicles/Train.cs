using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt.Vehicles
{
    public class Train : Vehicle
    {
        public int Carriages { get; set; }
        public decimal TrackWidth { get; set; }
        public bool hasCatering { get; set; }
        public Train(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }
        /// <summary>
        /// Returns info about the train
        /// </summary>
        /// <returns>Human-readable sentence as a string</returns>
        public override string GetInfo()
        {
            
            //Klassi "Train" meetod "GetInfo", asendab baasklassist tulevat meetodit, kaitstud sõna "override" abil, kuna baasklassis oleval meetodil on juures kaitstud sõna "virtual".
            return $"This is a {Mark} {Model}, it is {Colour} color and has {Carriages} carriages.\nIt runs on a track with the width: {TrackWidth}";

        }
    }
}
