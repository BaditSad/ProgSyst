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
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Config");
                Values.Instance.PathFolder = Values.Instance.PathConfig;
                StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.json");
                path_folder.WriteLine(Values.Instance.PathFolder);
                path_folder.Close();
                StreamWriter lang = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Lang.json");
                lang.WriteLine(Values.Instance.Lang);
                lang.Close();
                Values.Instance.FirstLaunch = true;
            }
            else
            {
                StreamReader path_folder = new StreamReader(Values.Instance.PathConfig + "\\Config\\Path.json");
                Values.Instance.PathFolder = path_folder.ReadLine();
                path_folder.Close();
                Values.Instance.FirstLaunch = false;
            }
        }
    }
    class FileChecker
    {
        public void Checker_En()
        {
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
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Dailylog"))
            {
                Console.WriteLine($"Dossier Dailylog n'éxiste pas!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Dailylog");
                Console.WriteLine("Terminer...");
            }
            else
            {
                Console.WriteLine($"Dossier Dailylog éxiste déjà!");
            }
            if (!Directory.Exists(Values.Instance.PathConfig + "\\Statelog"))
            {
                Console.WriteLine($"Dossier Statelog n'éxiste pas!");
                Directory.CreateDirectory(Values.Instance.PathConfig + "\\Statelog");
                Console.WriteLine("Terminer...");
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