using System;
using System.Security.Cryptography.X509Certificates;

namespace System
{
    class Model
    {
        public void Uninstall_En()
        {

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