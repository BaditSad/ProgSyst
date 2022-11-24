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
            while (true)
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();                    Console.WriteLine("\nWrite \"exit\" to close.\n------------------------------\n");
                Console.WriteLine("\nActual path : " + Values.Instance.PathFolder + "\n");
                if (errorPath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR path !");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("New path : ");
                NewPath = Console.ReadLine();
                if (NewPath == "exit")
                {
                    break;
                }
                if (Directory.Exists(NewPath))
                {
                    Values.Instance.PathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.txt");
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
            while (true)
            {
                Console.Clear();
                var NewBanner = new Banner();
                Console.WriteLine("\nécrire \"exit\" pour fermer.\n------------------------------\n");
                Console.WriteLine("\nChemin actuel : " + Values.Instance.PathFolder + "\n");
                if (errorPath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERREUR chemin !");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("Nouveau chemin : ");
                NewPath = Console.ReadLine();
                if (NewPath == "exit")
                {
                    break;
                }
                if (Directory.Exists(NewPath))
                {
                    Values.Instance.PathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(Values.Instance.PathConfig + "\\Config\\Path.txt");
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