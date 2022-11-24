using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Configuration
    {
        string keyM = "0";
        public void Config_En()
        {
            while (keyM != "1" & keyM != "2" & keyM != "3" & keyM != "4")
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
                Console.WriteLine("\nSelect an option :");
                Console.WriteLine("\n1 - Default save path\n2 - Language\n3 - Uninstall\n4 - Back");
                keyM = Console.ReadLine();
                Values.Instance.KeyM = keyM;
            }
        }
        public void Config_Fr()
        {
            while (keyM != "1" & keyM != "2" & keyM != "3" & keyM != "4")
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
                Console.WriteLine("\nChoisir une option :");
                Console.WriteLine("\n1 - Chemin de sauvegarde par défaut\n2 - Language\n3 - Désinstaller\n4 - Retour");
                keyM = Console.ReadLine();
                Values.Instance.KeyM = keyM;
            }
        }
    }
}