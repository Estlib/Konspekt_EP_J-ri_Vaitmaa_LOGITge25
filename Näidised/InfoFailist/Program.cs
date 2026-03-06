using System;
using System.Text;

namespace InfoFailist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, List<string>, int, bool, string> player =
                new Tuple<int, List<string>, int, bool, string>(0, new List<string> { "" }, 0, false, "");
            const string saveGameLocation = "savegame.txt";
            if (!File.Exists(saveGameLocation))
            {
                List<string> info = new List<string>();
                info.Add("_integer");
                info.Add("_list");
                info.Add("_anotherinteger");
                info.Add("_boolean");
                info.Add("_message");

                File.WriteAllLines(saveGameLocation, info);
            }
            else if (File.Exists(saveGameLocation))
            {
                int elud = 0;
                List<string> seljaKott = new List<string>();
                int moni = 0;
                bool haige = false;
                string message = "nomsg";

                string[] loadedFile = File.ReadAllLines(saveGameLocation);
                //for (int i = 0; i < loadedFile.Length; i++)
                //{
                //    string[] seeRida = loadedFile[i].Split('_');
                //    if (seeRida.Length <= 1)
                //    {
                //        loadedFile[i] = string.Join('_', new string[] { seeRida[0], "_0" }); //later parse this to int

                //    }
                //    else
                //    {

                //    }
                //}
                foreach (string rida in loadedFile)
                {
                    try
                    {
                        string[] seeRida = rida.Split('_');
                        switch (seeRida[0])
                        {
                            case "_integer":
                                elud = int.Parse(seeRida[1]);
                                break;
                            case "_list":
                                seljaKott = seeRida[1].Split(',').ToList();
                                break;
                            case "_anotherinteger":
                                moni = int.Parse(seeRida[1]);
                                break;
                            case "_bool":
                                haige = bool.Parse(seeRida[1]);
                                break;
                            case "_message":
                                message = seeRida[1];
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {


                    }

                }

                Console.WriteLine(elud);
                Console.WriteLine(seljaKott.Count);
                Console.WriteLine(moni);
                Console.WriteLine(haige);
                Console.WriteLine(message);

            }
        }
    }
}
