using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Language
    {
        string keyL = "0";
        public void FirstLaunch()
        {
            //SHow welcome message and ask for language
            if (Values.Instance.FirstLaunch == true)
            {
                string keyFl = "0";
                while (keyFl != "1" & keyFl != "2")
                {
                    var NewBanner = new Banner();
                    NewBanner.EasySaveBanner();
                    Console.ForegroundColor= ConsoleColor.DarkCyan;
                    Console.WriteLine("\n\n > Welcome to EasySave ! < ");
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("EasySave is a backup software created by ProSoft with the help \nof a group of students specialized in computer science \nfrom the CESI Lille engineering school.\n");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n > Bienvenue sur EasySave ! < ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EasySave est un logiciel de sauvegarde réalisé par ProSoft avec l'aide \nd'un groupe d'étudiants spécialisé en informatique \nde l'école d'ingénieurs de CESI Lille.\n");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n > Brieuc.D - Weicheng.L - Arthur.K - Jean-Loup.D < ");
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("\n > 1 - English / 2 - Français < ");
                    keyFl = Console.ReadLine();
                    Console.Clear();
                }
                if (keyFl == "1")
                {
                    Values.Instance.Lang = "en";
                    StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
                    config_lang.WriteLine(Values.Instance.Lang);
                    config_lang.Close();
                }
                if (keyFl == "2")
                {
                    Values.Instance.Lang = "fr";
                    StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
                    config_lang.WriteLine(Values.Instance.Lang);
                    config_lang.Close();
                }
                Values.Instance.FirstLaunch = false;
            }
            else
            {
                StreamReader config_lang = new StreamReader(Values.Instance.PathConfig + "\\Config\\Lang.json");
                Values.Instance.Lang = config_lang.ReadLine();
                config_lang.Close();
            }
        }
        public void Language_En()
        {
            //Ask user to change language (english)
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
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.json");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
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
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.json");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                Console.WriteLine("Langue : français");
                Console.Write("\nAppuyé sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
        public void Language_Fr()
        {
            //Ask user to change language (french)
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
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.json");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
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
                File.Delete(Values.Instance.PathConfig + "\\Config\\Lang.json");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                Console.WriteLine("Langue : français");
                Console.Write("\nAppuyé sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
    }
}