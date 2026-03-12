using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneProjekt // Nimeruum millises projektis (skoobis) antud klass on
{
    // Klassi anatoomia:
    // A - Klassi enda nimeruum, mis sisaldab kõik mis klassil tema töö jaoks vaja on
    //      Klassi nimeruum vajab
    //      (A.1) - juurdepääsu modifikaatorit,
    //      (A.2) - sätestust et tegu on klassiga
    //      (A.3) - klassi enda nime.
    // B - Klassi konstruktor defineerib ära spetsiaalse meetodi mis ütleb kuidas
    //      selle klassi tüüpi objekt instantsieeritakse. Samamoodi nagu structil,
    //      saab olla konstruktoreid mitu, erinevalt Structist, väärtused peab andma kaasa.
    // C - Väljad mida konstruktor ootab, neile tuleb väärtus anda välja arvatud ühel juhul
    // D - Klassi omadused. Nende kaudu saab kasutatavas koodis selle klassi tüüpi objekti
    //      andmeid kätte, adresseerides neid punktiga. Erinevalt Structist, vajavad omadused
    //      objekti tekitamisel mingit väärtust. Välja arvatud siis, kui omaduse
    //      andmetüübi taga on küsimärk (?) mis ütleb, et see omadus võib jääda "null"iks.
    //      (D.1)
    //      Klassi omadusele saab anda vaikeväärtuse. Vaikeväärtus on midagi mis antakse
    //      selle klassi tüüpi uuele objektile kaasa, selle objekti tekitamise hetkel, kui
    //      ei ole sellele väljale väärtust antud.(D.2)
    //A.1   A.2   A.3
    public class KlassiPeatükk //A 
    {
        public KlassiPeatükk(string värvus, string materjal, double paksus) //B
        {
            Värvus = värvus; //C
            Materjal = materjal;
            Paksus = paksus;
        }
        //D
        public string?/*D.1*/ Värvus { get; set; } 
        public string Materjal { get; set; }
        public double Paksus { get; set; } = -1;//D.2
        //E klassi meetodid
        /// <summary>
        /// Returns a sentence, containing info about this object
        /// </summary>
        /// <returns>sentence</returns>
        public string GetInfo()
        {
            return $"This object is made of {Materjal}, is {Paksus} thick and has color {Värvus}.";
        }
        /// <summary>
        /// Method that return true, if this material can be dremeled or not<br/>
        /// If the dremel is longer than the material is thick, then it is not dremelable, and vice-versa.
        /// </summary>
        /// <param name="freesipaksus">Input your dremel length</param>
        /// <returns>true or false</returns>
        public bool CanThisBeDremeled(double freesipaksus) 
        {
            if (freesipaksus < Paksus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
