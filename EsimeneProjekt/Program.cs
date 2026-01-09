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

            //int kasutajaVanus = 0; 
            //Console.WriteLine("Kui vana sa oled?");
            //kasutajaVanus = int.Parse(Console.ReadLine());
            //if (kasutajaVanus >= 18)
            //{
            //    Console.WriteLine("Tere, siin on sinu mojito 🍹");
            //}
            //else 
            //{
            //    Console.WriteLine("Alaealisi sisse ei lasta, mine vembutembumaale. 🤡");
            //}

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

            //int mingiArv = 4;

            //mingiArv = mingiArv + 15; //
            //mingiArv = mingiArv * 15; //
            //mingiArv = mingiArv - 15; //
            //mingiArv = mingiArv / 15; //


            //mingiArv += 15; //
            //mingiArv -= 15; //
            //mingiArv *= 15; //
            //mingiArv /= 15; //

            ///* näiteülesanne 4 */
            //Console.WriteLine("Palun sisesta oma vanus"); 
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //int kasutajavanus = int.Parse(Console.ReadLine()); 
            //// tekitame muutuja kasutajavanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            //Console.WriteLine("Palun sisesta oma vanavanema vanus"); 
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //int kasutajaVanavanemaVanus = int.Parse(Console.ReadLine()); 
            //// tekitame muutuja kasutajaVanavanemaVanus ning omistame sinna käsurealt int.Parser abiga täisarvu
            //int vanusteVahe = kasutajaVanavanemaVanus - kasutajavanus; 
            //// tekitame uue täisarvu muutuja kuhu omistame avaldise kasutajaVanavanemaVanus - kasutajavanus tulemuse
            //Console.WriteLine(kasutajaVanavanemaVanus - kasutajavanus);
            //// saab ka otse kuvada, ilma muutujata
            //Console.WriteLine("Kui palju sa vanem oled?");
            //// esitame kasutajale küsimuse, console writeline kuvamisfunktsiooniga
            //kasutajavanus += int.Parse(Console.ReadLine());
            //// kasutame omistusoperaatorit, et lisada muutujale kasutaja poolt esitatud täisarvu
            //Console.WriteLine("vanuste vahe on nüüd: "+(kasutajaVanavanemaVanus - kasutajavanus));
            //// kuvame uuesti vanuste vahe koos tekstiga

            /* näiteülesanne 5 */

            Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (m)?");
            float kaugus = float.Parse(Console.ReadLine());
            if ( kaugus <= 1.00 && kaugus >= 0.00 )
            {
                Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            }
            else if (kaugus <= 2.00 && kaugus >= 1.01)
            {
                Console.WriteLine("Noh tuleb juba, jõuad veel!");
            }
            else if (kaugus <= 3.00 && kaugus >= 2.01 )
            {
                Console.WriteLine("TUBLI kolm meetrit umbes, peaaegu, vist... not sure");
            }
            else if (kaugus < 0)
            {
                Console.WriteLine("MIKS SA TAGURPIDI VISKAD?!?!?!");
            }
            else
            {
                Console.WriteLine("Ossaraks, seda on varsti orbiidilt näha");
            }

            /*
                üleval harjutused

                https://meet.google.com/qjt-wofj-gdb

                all teooria
                */

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

            ///* Muutuja nime näide: */
            ////string string = "abc"; //is bäd
            //string sõne = "abc"; //is gud

            /*   -= O M I S T U S O P E R A A T O R I D =-          */
            // =    -> üksik võrdusmärk omistab muutja sisse väärtuse, mida adresseeritakse muutuja enda nimega
            int muutuja = 1;
            // +=   -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            muutuja += 2;
            // -=   -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva väärtuse
            muutuja -= 1;
            // *=   -> võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
            muutuja *= 3;
            // /=   -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            muutuja /= 4;
            // %=   -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi.
            muutuja %= 2;

            // ++   -> on kiirtehe, mis muutujale liidab ainult ühe juurde.
            muutuja++; 
            // --   -> on kiirtehe, mis muutujast lahutab ainult ühe maha.
            muutuja--;

            /*   -= V Õ R D L U S O P E R A A T O R I D =-          */
            // ==   ->  "on võrdne/on täpselt sama" - Võrdusmärkide ühel pool olev objekt peab vastama
            //          oma olemuselt täpselt võrdusmärkide teisel pool oleva objektiga
            // >    ->  "on suurem kui" - Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt
            // <    ->  "on väiksem kui" - Märgist vasakul pool olev objekt peaks olema väiksem kui paremal pool olev objekt
            // >=   ->  "on suurem kui, või samavõrdne" - Märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem
            //          kui paremal pool olev objekt
            // <=   ->  "on väiksem kui, või samavõrdne" - Märgist vasakul pool olev objekt peaks olema maksimaalselt sama suur või väiksem
            //          kui paremal pool olev objekt
            // !=   ->  "ei tohi olla" võrdusmärgi vasakul pool olev objekt ei tohi omada IDENTSET kuju paremal pool oleva objektiga, kõik muud
            //          väärtused on lubatud.

            /*   -= L O O G I L I S E D    T E H T E D =-          */
            // &&   ->  "AND" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
            //          mõlemal pool märki "&&" olevad tingimused omakorda annavad oma avaldise tulemusena "true"
            //          või teisisõnu: true + true = true
            // ||   ->  "OR" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true" juhul kui
            //          ühel pool märki "||" olev tingimus annab oma avaldise tulemusena "true", ei ole vahet millisel pool märki
            //          või teisisõnu: true + false = true
            // !    ->  "NOT" loogiline tehe, mida kasutatakse tingimuse avaldise tulemuse inverteerimiseks. Tulemus mis muidu tagastaks "true",
            //          hüüumärgi abil nüüd tagastab false, ja vastupidi - tulemus mis muidu tagastaks "false", nüüd tagastab "true".
            //          ehk teisisõnu: true = false / false = true

        }
    }
}
