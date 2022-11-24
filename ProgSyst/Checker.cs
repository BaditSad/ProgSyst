using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class FolderChecker
    {
        public void CheckFolders()
        {
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Config"))
            {
                Values.Instance.FirstLaunch = true;
            }
            else
            {
                Values.Instance.FirstLaunch = false;
            }
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Config"))
            {
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Config");
                Values.Instance.PathFolder = Values.Instance.PathConfig;
                StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.txt");
                path_folder.WriteLine(Values.Instance.PathFolder);
                path_folder.Close();
                StreamWriter lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                lang.WriteLine(Values.Instance.Lang);
                lang.Close();
            }
            else
            {
                StreamReader path_folder = new StreamReader(Values.Instance.PathConfig + "\\Config\\Path.txt");
                Values.Instance.PathFolder = path_folder.ReadLine();
                path_folder.Close();
            }
        }
    }
    class FileChecker
    {
        public void Checker_En()
        {
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Config"))
            {
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Config");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                StreamWriter config_path = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.txt");
                config_lang.WriteLine(Values.Instance.PathFolder);
                config_lang.Close();
            }
            Thread.Sleep(500);
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Dailylog"))
            {
                Console.WriteLine($"Directory Dailylog does not exist!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Dailylog");
                Console.WriteLine("Done...");
            }
            else
            {
                Console.WriteLine($"Directory Dailylog exists!");
            }
            Thread.Sleep(500);
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Statelog"))
            {
                Console.WriteLine($"Directory Statelog does not exist!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Statelog");
                Console.WriteLine("Done...");
            }
            else
            {
                Console.WriteLine($"Directory Statelog exists!");
            }
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
            Console.Clear();
            Values.Instance.Start = false;
        }
        public void Checker_Fr()
        {
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Config"))
            {
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Config");
                StreamWriter config_lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.txt");
                config_lang.WriteLine(Values.Instance.Lang);
                config_lang.Close();
                StreamWriter config_path = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.txt");
                config_lang.WriteLine(Values.Instance.PathFolder);
                config_lang.Close();
            }
            Thread.Sleep(500);
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Dailylog"))
            {
                Console.WriteLine($"Dossier Dailylog n'éxiste pas!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Dailylog");
                Console.WriteLine("Fait...");
            }
            else
            {
                Console.WriteLine($"Dossier Dailylog éxiste déjà!");
            }
            Thread.Sleep(500);
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Statelog"))
            {
                Console.WriteLine($"Dossier Statelog n'éxiste pas!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Statelog");
                Console.WriteLine("Fait...");
            }
            else
            {
                Console.WriteLine($"Dossier Statelog éxiste déjà!");
            }
            Console.Write("\nAppuyé sur une touche pour continuer... ");
            Console.ReadKey();
            Console.Clear();
            Values.Instance.Start = false;
        }
    }
}