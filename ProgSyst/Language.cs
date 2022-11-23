using System;
using System.Security.Cryptography.X509Certificates;

namespace System
{
    class Language
    {
        string keyFL = "0";
        string keyL = "0";
        public void FirstLaunch()
        {
            if (firstLaunch == true) //On détecte si c'est le premier lancement sur la machine pour définir le language
            {
                string keyFl = "0";
                while (keyFl != "1" & keyFl != "2")
                {
                    NewBanner.EasySaveBanner();
                    Console.WriteLine("\n1 - English / 2 - Français");
                    keyFl = Console.ReadLine();
                    Console.Clear();
                }
                if (keyFl == "1")
                {
                    lang = "en";
                    StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                    config_lang.WriteLine(lang);
                    config_lang.Close();
                }
                if (keyFl == "2")
                {
                    lang = "fr";
                    StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                    config_lang.WriteLine(lang);
                    config_lang.Close();
                }
                firstLaunch = false;
            }
            else //si ce n'est pas le premier lancement on recupère la langue
            {
                StreamReader config_lang = new StreamReader(pathConfig + "\\Config\\Lang.txt");
                lang = config_lang.ReadLine();
                config_lang.Close();
            }
        }
        public void Language_En()
        {
            while (keyL != "1" & keyL != "2")
            {
                Console.Clear();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nSelect language :");
                Console.WriteLine("\n\n1 - English (active)\n2 - French\n");
                keyL = Console.ReadLine();
            }
            if (keyL == "1")
            {
                lang = "en";
                Console.Clear();
                File.Delete(pathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                Console.WriteLine("Language : english");
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            }
            else if (keyL == "2")
            {
                lang = "fr";
                Console.Clear();
                File.Delete(pathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                Console.WriteLine("Langue : français");
                Console.Write("\nAppuyé sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
        public void Language_Fr()
        {
            while (keyL != "1" & keyL != "2")
            {
                Console.Clear();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nChoisir une langue :");
                Console.WriteLine("\n\n1 - Anglais\n2 - Français (actif)\n");
                keyL = Console.ReadLine();
            }
            if (keyL == "1")
            {
                lang = "en";
                Console.Clear();
                File.Delete(pathConfig + "\\Config\\Lang.txt"); //ERREUR
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                Console.WriteLine("Language : english");
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            }
            else if (keyL == "2")
            {
                lang = "fr";
                Console.Clear();
                File.Delete(pathConfig + "\\Config\\Lang.txt"); //ERREUR
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                Console.WriteLine("Langue : français");
                Console.Write("\nAppuyé sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
    }
}