using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class DefaultPath
    {
        string NewPath = "";
        bool errorPath = false;
        public void Path_En()
        {
            //Write the default path (english)
            while (true)
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();                    
                Console.WriteLine("\nWrite \"exit\" to go back.\n------------------------------\n");
                Console.Write("\nDefault path : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Values.Instance.PathFolder + "\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (errorPath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" - ERROR path - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("\rNew path : ");
                NewPath = Console.ReadLine();
                if (NewPath == "exit")
                {
                    break;
                }
                if (Directory.Exists(NewPath))
                {
                    Values.Instance.PathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.json");
                    path_folder.WriteLine(Values.Instance.PathFolder);
                    path_folder.Close();
                    break;
                }
                else
                {
                    errorPath = true;
                }
            }
        }
        public void Path_Fr()
        {
            //Write the default path (french)
            while (true)
            {
                Console.Clear();
                var NewBanner = new Banner();
                Console.WriteLine("\nÉcrire \"exit\" pour quitter.\n------------------------------\n");
                Console.Write("\nChemin par défault : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Values.Instance.PathFolder + "\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (errorPath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" - ERREUR chemin - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("\rNouveau chemin : ");
                NewPath = Console.ReadLine();
                if (NewPath == "exit")
                {
                    break;
                }
                if (Directory.Exists(NewPath))
                {
                    Values.Instance.PathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.json");
                    path_folder.WriteLine(Values.Instance.PathFolder);
                    path_folder.Close();
                    break;
                }
                else
                {
                    errorPath = true;
                }
            }
        }
    }
}