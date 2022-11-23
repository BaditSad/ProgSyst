using System;
using System.Security.Cryptography.X509Certificates;

namespace System
{
    class Menu
    {
        string key;
        public void Menu_En()
        {
            NewBanner.EasySaveBanner();
            if (pathFolder == "Ø")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDefault target path : " + pathFolder);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDefault target path : " + pathFolder);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Configuration\n4 - Close\n");
            key = Console.ReadLine();
        }
        public void Menu_Fr()
        {
            NewBanner.EasySaveBanner();
            if (pathFolder == "Ø")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("\n\n1 - Créer une sauvegarde\n2 - Afficher sauvegardes\n3 - Configuration\n4 - Fermer\n");
            key = Console.ReadLine();
        }
    }
}