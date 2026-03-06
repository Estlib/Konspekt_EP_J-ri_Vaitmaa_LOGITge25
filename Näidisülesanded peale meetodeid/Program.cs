namespace Näidisülesanded_peale_meetodeid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Palun sisesta esimene arv");
            //float arv1 = 0.0f;
            //arv1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Palun sisesta teine arv");
            //float arv2 = 0.0f;
            //arv2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
            //string tehteTüüp = "";
            //tehteTüüp = Console.ReadLine();

            //double tehteTulemus = 0.0d;

            //if (tehteTüüp != "")
            //{
            //    switch (tehteTüüp)
            //    {
            //        default:
            //            Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
            //            return;
            //        case "+":
            //            tehteTulemus = Liitmine(arv1, arv2);
            //            break;
            //        case "-":
            //            tehteTulemus = Lahutamine(arv1, arv2);
            //            break;
            //        case "/":
            //            tehteTulemus = Jagamine(arv1, arv2);
            //            break;
            //        case "*":
            //            tehteTulemus = Korrutamine(arv1 , arv2);
            //            break;
            //        case "^":
            //            tehteTulemus = Astendamine(arv1,arv2);
            //            break;
            //        case "V":
            //            tehteTulemus = Juurimine(arv1,arv2);
            //            break;
            //    }
            //    Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tehteTulemus}");
            //}
            const string nameOfFile = "kasutajatanav.txt";
            if (File.Exists(nameOfFile))
            {
                string[] tervitus = File.ReadAllLines(nameOfFile);
                Console.WriteLine(tervitus[0]);
            }
            else
            {
                Console.WriteLine("Sisesta oma nimi");
                string kasutajanimi = GetAnswer();
                Console.WriteLine("Tere " + kasutajanimi);
                Console.WriteLine("Palun sisesta ka oma tänavanimi");
                string tänavanimi = GetAnswer();
                string failisisu = kasutajanimi + " ahha! elad " + tänavanimi + " tänaval";
                Console.WriteLine(failisisu);
                File.WriteAllText(nameOfFile, failisisu);
            }

            //IsPensionär();
            //küsi kasutajalt tema vanust, meetod selgitab välja kas ta on pensionär või mitte, ning meetod ise kuvab sõnumi vastavalt kas on või ei;
            // kui on - ütle "Kuidas jalad liiguvad? hästi?"
            // kui ei ole - ütle "Mitu monsterit päevas jood?"
        }

        private static void IsPensionär()
        {
            Console.WriteLine("Kui vana oled?");
            string vanus = GetAnswer();
            int arvunavanus = int.Parse(vanus);
            if (arvunavanus >= 65)
            {
                Console.WriteLine("Kuidas jalad liiguvad? hästi?");
            }
            else
            {
                Console.WriteLine("Mitu monsterit päevas jood?");
            }
        }

        private static string GetAnswer()
        {
            string input = "";
            do
            {
                Console.WriteLine("Palun sisesta:");
                input = Console.ReadLine();
            } while (input == "");
            return input;
        }

        private static double Juurimine(float arv1, float arv2)
        {
            return Math.Pow(arv1, (1 / arv2));
        }

        private static double Astendamine(float arv1, float arv2)
        {
            return Math.Pow(arv1, arv2);
        }

        private static double Korrutamine(float arv1, float arv2)
        {
            return arv1 * arv2;
        }

        private static double Jagamine(float arv1, float arv2)
        {
            return arv1 / arv2;
        }

        private static double Lahutamine(float arv1, float arv2)
        {
            return arv1 - arv2;
        }

        private static double Liitmine(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
    }
}
