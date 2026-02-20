namespace Näidisülesanded_peale_meetodeid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta esimene arv");
            float arv1 = 0.0f;
            arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta teine arv");
            float arv2 = 0.0f;
            arv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
            string tehteTüüp = "";
            tehteTüüp = Console.ReadLine();

            double tehteTulemus = 0.0d;

            if (tehteTüüp != "")
            {
                switch (tehteTüüp)
                {
                    default:
                        Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
                        return;
                    case "+":
                        tehteTulemus = Liitmine(arv1, arv2);
                        break;
                    case "-":
                        tehteTulemus = Lahutamine(arv1, arv2);
                        break;
                    case "/":
                        tehteTulemus = Jagamine(arv1, arv2);
                        break;
                    case "*":
                        tehteTulemus = Korrutamine(arv1 , arv2);
                        break;
                    case "^":
                        tehteTulemus = Astendamine(arv1,arv2);
                        break;
                    case "V":
                        tehteTulemus = Juurimine(arv1,arv2);
                        break;
                }
                Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tehteTulemus}");
            }
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
