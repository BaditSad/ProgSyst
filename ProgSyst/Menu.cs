using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Menu
    {
        public void Menu_En()
        {
            //Show the principal menu (english)
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n >>> Menu <<<");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[1] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Create save");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[2] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Show saves");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[3] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Configuration");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[4] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Close\n\n");
            Values.Instance.Key = Console.ReadLine();
        }
        public void Menu_Fr()
        {
            //Show the principal menu (french)
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n >>> Menu <<<");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[1] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Créer une sauvegarde");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[2] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Afficher sauvegardes");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[3] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Configuration");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[4] - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Quitter\n\n");
            Values.Instance.Key = Console.ReadLine();
        }
    }
}