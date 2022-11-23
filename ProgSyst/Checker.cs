using System;
using System.Security.Cryptography.X509Certificates;

namespace System
{
    class FileChecker
    {
        public void Checker_En()
        {
            if (!Directory.Exists(pathConfig + "\\Config"))
            {
                Directory.CreateDirectory(pathConfig + "\\Config");
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                StreamWriter config_path = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                config_lang.WriteLine(pathFolder);
                config_lang.Close();
            }
            Thread.Sleep(500);
            if (!Directory.Exists(pathConfig + "\\Dailylog"))
            {
                Console.WriteLine($"Directory Dailylog does not exist!");
                Directory.CreateDirectory(pathConfig + "\\Dailylog");
                Console.WriteLine("Done...");
            }
            else
            {
                Console.WriteLine($"Directory Dailylog exists!");
            }
            Thread.Sleep(500);
            if (!Directory.Exists(pathConfig + "\\Statelog"))
            {
                Console.WriteLine($"Directory Statelog does not exist!");
                Directory.CreateDirectory(pathConfig + "\\Statelog");
                Console.WriteLine("Done...");
            }
            else
            {
                Console.WriteLine($"Directory Statelog exists!");
            }
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
            Console.Clear();
            start = false;
        }
        public void Checker_Fr()
        {
            if (!Directory.Exists(pathConfig + "\\Config"))
            {
                Directory.CreateDirectory(pathConfig + "\\Config");
                StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(lang);
                config_lang.Close();
                StreamWriter config_path = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                config_lang.WriteLine(pathFolder);
                config_lang.Close();
            }
            Thread.Sleep(500);
            if (!Directory.Exists(pathConfig + "\\Dailylog"))
            {
                Console.WriteLine($"Dossier Dailylog n'éxiste pas!");
                Directory.CreateDirectory(pathConfig + "\\Dailylog");
                Console.WriteLine("Fait...");
            }
            else
            {
                Console.WriteLine($"Dossier Dailylog éxiste déjà!");
            }
            Thread.Sleep(500);
            if (!Directory.Exists(pathConfig + "\\Statelog"))
            {
                Console.WriteLine($"Dossier Statelog n'éxiste pas!");
                Directory.CreateDirectory(pathConfig + "\\Statelog");
                Console.WriteLine("Fait...");
            }
            else
            {
                Console.WriteLine($"Dossier Statelog éxiste déjà!");
            }
            Console.Write("\nAppuyé sur une touche pour continuer... ");
            Console.ReadKey();
            Console.Clear();
            start = false;
        }
    }
}