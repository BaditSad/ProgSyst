using System;
using System.Security.Cryptography.X509Certificates;

namespace System
{
    class Uninstall
    {
        string choiceDelete = "";
        public void Uninstall_En()
        {
            while (choiceDelete != "y" & choiceDelete != "Y" & choiceDelete != "n" & choiceDelete != "N")
            {
                Console.Clear();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\n##### UNINSTALL ? #####\nY/N");
                choiceDelete = Console.ReadLine();
                if (choiceDelete == "y" | choiceDelete == "Y")
                {
                    Console.Clear();
                    if (Directory.Exists(pathConfig + "\\Config"))
                    {
                        Directory.Delete(pathConfig + "\\Config", true);
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(pathFolder + "\\Dailylog"))
                    {
                        Directory.Delete(pathFolder + "\\Dailylog", true);
                        Console.WriteLine($"Directory {pathFolder + "\\Dailylog"} deleted!");
                    }
                    else
                    {
                        Console.WriteLine("\"Daily log\" non-existent.");
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(pathFolder + "\\Statelog"))
                    {
                        Directory.Delete(pathFolder + "\\Statelog", true);
                        Console.WriteLine($"Directory {pathFolder + "\\Statelog"} deleted!");
                    }
                    else
                    {
                        Console.WriteLine("\"State log\" non-existent.");
                    }
                    Thread.Sleep(500);
                    pathFolder = "Ø";
                    Console.Write("\nPress any key to continue... ");
                    Console.ReadKey();
                }
                else if (choiceDelete == "n" & choiceDelete == "N")
                {
                    return;
                }
            }
        }
        public void Uninstall_Fr()
        {
            while (choiceDelete != "o" & choiceDelete != "O" & choiceDelete != "n" & choiceDelete != "N")
            {
                Console.Clear();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\n##### DESINSTALLER ? #####\nO/N");
                choiceDelete = Console.ReadLine();
                if (choiceDelete == "o" | choiceDelete == "O")
                {
                    Console.Clear();
                    if (Directory.Exists(pathConfig + "\\Config"))
                    {
                        Directory.Delete(pathConfig + "\\Config", true);
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(pathFolder + "\\Dailylog"))
                    {
                        Directory.Delete(pathFolder + "\\Dailylog", true);
                        Console.WriteLine($"Dossier {pathFolder + "\\Dailylog"} supprimé!");
                    }
                    else
                    {
                        Console.WriteLine("\"Daily log\" inexistant.");
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(pathFolder + "\\Statelog"))
                    {
                        Directory.Delete(pathFolder + "\\Statelog", true);
                        Console.WriteLine($"Dossier {pathFolder + "\\Statelog"} supprimé!");
                    }
                    else
                    {
                        Console.WriteLine("\"State log\" inexistant.");
                    }
                    Thread.Sleep(500);
                    pathFolder = "Ø";
                    Console.Write("\nAppuyé sur une touche pour continuer... ");
                    Console.ReadKey();
                }
                else if (choiceDelete == "n" & choiceDelete == "N")
                {
                    return;
                }
            }
        }
    }
}