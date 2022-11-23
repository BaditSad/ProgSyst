using System;
using System.Security.Cryptography.X509Certificates;

namespace System
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
                NewBanner.EasySaveBanner();                    Console.WriteLine("\nWrite \"exit\" to close.\n------------------------------\n");
                Console.WriteLine("\nActual path : " + pathFolder + "\n");
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
                    pathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                    path_folder.WriteLine(pathFolder);
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
                Console.WriteLine("\nécrire \"exit\" pour fermer.\n------------------------------\n");
                Console.WriteLine("\nChemin actuel : " + pathFolder + "\n");
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
                    pathFolder = NewPath;
                    StreamWriter path_folder = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                    path_folder.WriteLine(pathFolder);
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