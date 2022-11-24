using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Menu
    {
        public void Menu_En()
        {
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
            Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Configuration\n4 - Close\n");
            Values.Instance.Key = Console.ReadLine();
        }
        public void Menu_Fr()
        {
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
            Console.WriteLine("\n\n1 - Créer une sauvegarde\n2 - Afficher sauvegardes\n3 - Configuration\n4 - Fermer\n");
            Values.Instance.Key = Console.ReadLine();
        }
    }
}