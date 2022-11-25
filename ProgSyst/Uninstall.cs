using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class Uninstall
    {
        //Uninstall all folders to reset the software
        string choiceDelete = "";
        public void Uninstall_En()
        {
            while (choiceDelete != "y" & choiceDelete != "Y" & choiceDelete != "n" & choiceDelete != "N")
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\n##### UNINSTALL ? #####\nY/N");
                choiceDelete = Console.ReadLine();
                if (choiceDelete == "y" | choiceDelete == "Y")
                {
                    Console.Clear();
                    if (Directory.Exists(Values.Instance.PathConfig + "\\Config"))
                    {
                        Directory.Delete(Values.Instance.PathConfig + "\\Config", true);
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(Values.Instance.PathFolder + "\\Dailylog"))
                    {
                        Directory.Delete(Values.Instance.PathFolder + "\\Dailylog", true);
                        Console.WriteLine($"Directory {Values.Instance.PathFolder + "\\Dailylog"} deleted!");
                    }
                    else
                    {
                        Console.WriteLine("\"Daily log\" non-existent.");
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(Values.Instance.PathFolder + "\\Statelog"))
                    {
                        Directory.Delete(Values.Instance.PathFolder + "\\Statelog", true);
                        Console.WriteLine($"Directory {Values.Instance.PathFolder + "\\Statelog"} deleted!");
                    }
                    else
                    {
                        Console.WriteLine("\"State log\" non-existent.");
                    }
                    Thread.Sleep(500);
                    Values.Instance.PathFolder = "Ø";
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
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\n##### DESINSTALLER ? #####\nO/N");
                choiceDelete = Console.ReadLine();
                if (choiceDelete == "o" | choiceDelete == "O")
                {
                    Console.Clear();
                    if (Directory.Exists(Values.Instance.PathConfig + "\\Config"))
                    {
                        Directory.Delete(Values.Instance.PathConfig + "\\Config", true);
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(Values.Instance.PathFolder + "\\Dailylog"))
                    {
                        Directory.Delete(Values.Instance.PathFolder + "\\Dailylog", true);
                        Console.WriteLine($"Dossier {Values.Instance.PathFolder + "\\Dailylog"} supprimé!");
                    }
                    else
                    {
                        Console.WriteLine("\"Daily log\" inexistant.");
                    }
                    Thread.Sleep(500);
                    if (Directory.Exists(Values.Instance.PathFolder + "\\Statelog"))
                    {
                        Directory.Delete(Values.Instance.PathFolder + "\\Statelog", true);
                        Console.WriteLine($"Dossier {Values.Instance.PathFolder + "\\Statelog"} supprimé!");
                    }
                    else
                    {
                        Console.WriteLine("\"State log\" inexistant.");
                    }
                    Thread.Sleep(500);
                    Values.Instance.PathFolder = "Ø";
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