using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Configuration
    {
        string keyM = "0";
        public void Config_En()
        {
            //Show config menu (english)
            while (keyM != "1" & keyM != "2" & keyM != "3" & keyM != "4" & keyM != "5")
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                if (Values.Instance.PathFolder == "Ø")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDefault target path : " + Values.Instance.PathFolder);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDefault target path : " + Values.Instance.PathFolder);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n >>> Menu > Configuration <<<");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[1] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Set default target path");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[2] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Language");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[3] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Clear saves (logs)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[4] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Reset");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[5] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Back\n\n");
                keyM = Console.ReadLine();
                Values.Instance.KeyM = keyM;
            }
        }
        public void Config_Fr()
        {
            //Show config menu (french)
            while (keyM != "1" & keyM != "2" & keyM != "3" & keyM != "4" & keyM != "5")
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                if (Values.Instance.PathFolder == "Ø")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nChemin cible par défaut : " + Values.Instance.PathFolder);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nChemin cible par défaut : " + Values.Instance.PathFolder);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n >>> Menu > Configuration <<<");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[1] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Changer le chemin cible par défaut");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[2] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Langue");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[3] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Supprimer les sauvegardes (logs)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[4] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Rénitialiser");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[5] - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Retour\n\n");
                keyM = Console.ReadLine();
                Values.Instance.KeyM = keyM;
            }
        }
    }
}