using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt
{
    public enum CarMark
    {
        Toyota,Ford,Trashla,Subaru,Saab,Volvo,BMW,Mini,Škoda,
    }
    public class Vehicle
    {

        public Vehicle(
            string model, 
            CarMark mark, 
            string plate, 
            string colour, 
            decimal unloadedWeight, //one unit is one ton
            List<string> equiptment)
        {
            Model = model;
            Mark = mark;
            LicensePlate = plate;
            Colour = colour;
            EmptyWeight = unloadedWeight;
            Equiptment = equiptment;
        }

        public string Model { get; set; }
        public CarMark Mark { get; set; }
        public string LicensePlate { get; set; }
        public string Colour { get; set; }
        public decimal EmptyWeight { get; set; } = 0;
        public List<string>? Equiptment { get; set; } 
        /// <summary>
        /// Returns general info about Vehicle
        /// </summary>
        /// <returns>Human-readable sentence as a string</returns>
        public virtual string GetInfo()
            //Baasklassi meetod "GetInfo" omab kaitstud sõna virtual, mis laseb siin klassis olevat meetodit, seda klassi pärivatel klassidel kaitstud sõnaga "override" asendada.
        {
            return $"This is a {Mark} {Model}, it is {Colour} color and weighs {EmptyWeight} Tons.\nLicense plate number is {LicensePlate}";
        }
        public void SeeEquiptment()
        {
            Console.WriteLine("This car has: ");
            foreach (var thing in Equiptment)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
