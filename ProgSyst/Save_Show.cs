using EasySave;
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;

namespace System
{
    public class Save_Show
    {
        private static string targetFolder = "";
        private static bool targetIsExist = false;

        string fileName = "";
        string transfer = "";
        string tranfertOK = "";
        string SourcePath = "";
        string TargetPath = "";
        bool errorFilePath = false;
        bool errorTargetPath = false;
        bool saved = false;
        public void Save_En()
        {
            while (saved == false)
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nWrite \"exit\" to go back.\n------------------------------\n");
                if (errorFilePath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" - ERROR path - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("\rFile path : \n");
                SourcePath = Console.ReadLine();
                if (SourcePath == "exit")
                {
                    break;
                }
                if (File.Exists(SourcePath))
                {
                    while (saved == false)
                    {
                        Console.Clear();
                        
                        NewBanner.EasySaveBanner();
                        Console.WriteLine("\nWrite \"exit\" to go back.\n------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nFile path : " + SourcePath + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (errorTargetPath == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" - ERROR path - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\r\nTarget default folder path : ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Values.Instance.PathFolder + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Target (just \"enter\" to keep the default path) :\n");
                        TargetPath = Console.ReadLine();
                        if (TargetPath == "")
                        {
                            TargetPath = Values.Instance.PathFolder;
                        }
                        if (TargetPath == "exit")
                        {
                            break;
                        }
                        if (Directory.Exists(TargetPath))
                        {
                            while (tranfertOK != "y" & tranfertOK != "Y" & tranfertOK != "n" & tranfertOK != "N")
                            {
                                Console.Clear();
                                NewBanner.EasySaveBanner();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n##### DO THE SAVE ? #####\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(SourcePath + " --> " + TargetPath);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nY/N\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                tranfertOK = Console.ReadLine();
                                if (tranfertOK == "y" | tranfertOK == "Y")
                                {
                                    fileName = Path.GetFileName(SourcePath);
                                    File.Move(SourcePath, TargetPath + "\\" + fileName);
                                    transfer = "(" + DateTime.Now + ") : " + SourcePath + " --> " + TargetPath;
                                    StreamWriter log = new StreamWriter(Values.Instance.PathConfig + "\\Dailylog\\Log.json", true);
                                    log.WriteLine(transfer);
                                    log.Close();
                                    saved = true;
                                    Console.Clear();
                                    Console.Write("\nDone. ");
                                    Console.Write("\nPress any key to continue... ");
                                    Console.ReadKey();
                                }
                                else if (tranfertOK == "n" & tranfertOK == "N")
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            errorTargetPath = true;
                        }
                    }
                }
                else
                {
                    errorFilePath = true;
                }
            }
        }
        public void Save_Fr()
        {
            while (saved == false)
            {
                Console.Clear();
                var NewBanner = new Banner();
                NewBanner.EasySaveBanner();
                Console.WriteLine("\nÉcrire \"exit\" pour revenir en arrière.\n------------------------------\n");
                if (errorFilePath == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" - ERREUR chemin - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine("\rChemin du fichier : \n");
                SourcePath = Console.ReadLine();
                if (SourcePath == "exit")
                {
                    break;
                }
                if (File.Exists(SourcePath))
                {
                    while (saved == false)
                    {
                        Console.Clear();

                        NewBanner.EasySaveBanner();
                        Console.WriteLine("\nÉcrire \"exit\" pour revenir en arrière.\n------------------------------\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nChemin du fichier : " + SourcePath + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (errorTargetPath == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" - ERROR path - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\r\nChemin par défaut de la cible : ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Values.Instance.PathFolder + "\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cible (écrire \"enter\" pour garder le chemin par défaut) :\n");
                        TargetPath = Console.ReadLine();
                        if (TargetPath == "")
                        {
                            TargetPath = Values.Instance.PathFolder;
                        }
                        if (TargetPath == "exit")
                        {
                            break;
                        }
                        if (Directory.Exists(TargetPath))
                        {
                            while (tranfertOK != "y" & tranfertOK != "Y" & tranfertOK != "n" & tranfertOK != "N")
                            {
                                Console.Clear();
                                NewBanner.EasySaveBanner();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n##### FAIRE LA SAUVEGARDE ? #####\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(SourcePath + " --> " + TargetPath);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nO/N\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                tranfertOK = Console.ReadLine();
                                if (tranfertOK == "o" | tranfertOK == "O")
                                {
                                    fileName = Path.GetFileName(SourcePath);
                                    File.Move(SourcePath, TargetPath + "\\" + fileName);
                                    transfer = "(" + DateTime.Now + ") : " + SourcePath + " --> " + TargetPath;
                                    StreamWriter log = new StreamWriter(Values.Instance.PathConfig + "\\Dailylog\\Log.json", true);
                                    log.WriteLine(transfer);
                                    log.Close();
                                    saved = true;
                                    Console.Clear();
                                    Console.Write("\nTerminer. ");
                                    Console.Write("\nAppuyer sur une touche pour continuer... ");
                                    Console.ReadKey();
                                }
                                else if (tranfertOK == "n" & tranfertOK == "N")
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            errorTargetPath = true;
                        }
                    }
                }
                else
                {
                    errorFilePath = true;
                }
            }
        }
        public void Show_En()
        {
            if (File.Exists(Values.Instance.PathConfig + "\\Dailylog\\Log.json"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                StreamReader LogFile = new StreamReader(Values.Instance.PathConfig + "\\Dailylog\\Log.json");
                string LogFileString = LogFile.ReadToEnd();
                LogFile.Close();
                Console.Write(LogFileString);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nPress any key to close... ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("NOTHING TO SHOW !\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPress any key to continue... ");
                Console.ReadKey();
            }
        }
        public void Show_Fr()
        {
            if (File.Exists(Values.Instance.PathConfig + "\\Dailylog\\Log.json"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                StreamReader LogFile = new StreamReader(Values.Instance.PathConfig + "\\Dailylog\\Log.json");
                string LogFileString = LogFile.ReadToEnd();
                LogFile.Close();
                Console.Write(LogFileString);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Appuyer sur une touche pour fermer... ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RIEN À AFFICHER !\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAppuyer sur une touche pour continuer... ");
                Console.ReadKey();
            }
        }
    }
}
