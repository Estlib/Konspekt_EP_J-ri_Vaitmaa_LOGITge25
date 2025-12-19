namespace EsimeneProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* näiteprogramm 1*/
            //int palk = 2345;
            //int kulud = 1122;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? (jah/ei)");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("Sisesta kõik kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //Console.WriteLine(kontojääk + " puulehte on alles."); // print(kontojääk + " puuehte on alles")
            //Console.WriteLine("Palun sisesta oma hästi tehtud töö boonus: ");
            //int boonus = int.Parse(Console.ReadLine()); // boonus = int(input("Palun sisesta oma hästi tehtud töö boonus: "))
            //kontojääk = kontojääk + boonus; // same python
            //Console.WriteLine("Sinu lõppväljavõte on: " + kontojääk + " puulehte");

            /* näiteprogramm 2 */
            /*
             * klient tahab et programm teeks: 
             * programm küsib kasutajalt tema vanust
             * kui ta on noorem kui 18 öeldakse kasutajale "alaealisi sisse ei lasta"
             * kui on vanem kui 18, pakutakse mojitot
             * 
             */

            int kasutajaVanus = 0; 
            Console.WriteLine("Kui vana sa oled?");
            kasutajaVanus = int.Parse(Console.ReadLine());
            if (kasutajaVanus >= 18)
            {
                Console.WriteLine("Tere, siin on sinu mojito 🍹");
            }
            else 
            {
                Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 🤡");
            }

            /*
             näiteprogramm 3:

            klient tahab et programm teeks:
             - küsib kasutajalt tema kasutajaNime
             - küsib kasutajalt tema parooli
             - logib kasutaja sisse kui mõlemad on õiged
             */
            // hint: mida teeb &&?

            /* siia käib vooskeemi järgi kirjutatud kood näidisülesanne 3 kohta */

            ////ctrl + k + c/u

            ///*   -= L I H T A N D M E T Ü Ü B I D =-             */
            //string tekst = "mingisugune inimloetav tekstike"; //tekst
            //char täht = 'A';
            //int arv = 1; //täisarv
            //float komakohagaarv = 1.5f; //32bit
            //double suuremkomakohagaarv = 1.5d; //64bit
            //decimal kümnendsüsteemiskomakohagaarv = 1.5M;
            //var x = 123; //Umbmäärase andmetüübiga ajutine muutuja
            //var y = "ABC";
            //bool jahvõiei = false; //kas true või false.

            ///**/
            ////string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud

        }
    }
}
