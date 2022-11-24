using System;

namespace EasySave
{
    class CLogs
    {
        string choiceClearLogs;
        public void ClearLogs_En()
        {
            if (File.Exists(Values.Instance.PathConfig + "\\Dailylog\\Log.json"))
            {
                while (choiceClearLogs != "y" & choiceClearLogs != "Y" & choiceClearLogs != "n" & choiceClearLogs != "N")
                {
                    Console.Clear();
                    var NewBanner = new Banner();
                    NewBanner.EasySaveBanner();
                    Console.WriteLine("\n##### CLEAR LOGS ? #####\nY/N");
                    choiceClearLogs = Console.ReadLine();
                    if (choiceClearLogs == "y" | choiceClearLogs == "Y")
                    {
                        File.Delete(Values.Instance.PathConfig + "\\Dailylog\\Log.json");
                        Console.Clear();
                        Console.Write("\nDone. ");
                        Console.Write("\nPress any key to continue... ");
                        Console.ReadKey();
                        return;
                    }
                    else if (choiceClearLogs == "n" & choiceClearLogs == "N")
                    {
                        return;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOTHING TO DELETE !\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
                return;
            }
        }
        public void ClearLogs_Fr()
        {
            if (File.Exists(Values.Instance.PathConfig + "\\Dailylog\\Log.json"))
            {
                while (choiceClearLogs != "y" & choiceClearLogs != "Y" & choiceClearLogs != "n" & choiceClearLogs != "N")
                {
                    Console.Clear();
                    var NewBanner = new Banner();
                    NewBanner.EasySaveBanner();
                    Console.WriteLine("\n##### SUPPRIMER LES LOGS ? #####\nO/N");
                    choiceClearLogs = Console.ReadLine();
                    if (choiceClearLogs == "o" | choiceClearLogs == "O")
                    {
                        File.Delete(Values.Instance.PathConfig + "\\Dailylog\\Log.json");
                        Console.Clear();
                        Console.Write("\nTerminer. ");
                        Console.Write("\nAppuyer sur une touche pour continuer... ");
                        Console.ReadKey();
                        return;
                    }
                    else if (choiceClearLogs == "n" & choiceClearLogs == "N")
                    {
                        return;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RIEN À SUPPRIMER !\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAppuyer sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
    }
}