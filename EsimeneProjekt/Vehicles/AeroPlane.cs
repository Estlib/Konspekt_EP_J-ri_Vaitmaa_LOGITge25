using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt.Vehicles
{
    public enum TravelClass
    {
        FirstClass, SecondClass, TouristClass, BaggageRoom
    }
    public class AeroPlane : Vehicle
    {
        public static List<TravelClass> TravelClasses {  get; set; }
        public double WingSpan { get; set; }
        public int MaxFlightRise { get; set; }
        public AeroPlane(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equiptment) : base(model, mark, plate, colour, unloadedWeight, equiptment)
        {
        }
    }
}
