﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Language
    {
        string keyL = "0";
        public void FirstLaunch()
        {
            if (Values.Instance.FirstLaunch == true) //On détecte si c'est le premier lancement sur la machine pour définir le language
            {
                string keyFl = "0";
                while (keyFl != "1" & keyFl != "2")
                {
                    var NewBanner = new Banner();
                    NewBanner.EasySaveBanner();
                    Console.WriteLine("\n1 - English / 2 - Français");
                    keyFl = Console.ReadLine();
                    Console.Clear();
                }
                if (keyFl == "1")
                {
                    Values.Instance.Lang = "en";
                    StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                    config_lang.WriteLine(Values.Instance.Lang);
                    config_lang.Close();
                }
                if (keyFl == "2")
                {
                    Values.Instance.Lang = "fr";
                    StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                    config_lang.WriteLine(Values.Instance.Lang);
                    config_lang.Close();
                }
                Values.Instance.FirstLaunch = false;
            }
            else //si ce n'est pas le premier lancement on recupère la langue
            {
                StreamReader config_lang = new StreamReader(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                Values.Instance.Lang = config_lang.ReadLine();
                config_lang.Close();
            }
        }
        public void Language_En()
        {
            while (keyL != "1" & keyL != "2")
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nSelect language :");
                Console.WriteLine("\n\n1 - English (active)\n2 - French\n");
                keyL = Console.ReadLine();
            }
            if (keyL == "1")
            {
                Values.Instance.Lang = "en";
                Console.Clear();
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                Console.WriteLine("Language : english");
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            }
            else if (keyL == "2")
            {
                Values.Instance.Lang = "fr";
                Console.Clear();
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
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
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nChoisir une langue :");
                Console.WriteLine("\n\n1 - Anglais\n2 - Français (actif)\n");
                keyL = Console.ReadLine();
            }
            if (keyL == "1")
            {
                Values.Instance.Lang = "en";
                Console.Clear();
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                Console.WriteLine("Language : english");
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            }
            else if (keyL == "2")
            {
                Values.Instance.Lang = "fr";
                Console.Clear();
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                Console.WriteLine("Langue : français");
                Console.Write("\nAppuyé sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
    }
}