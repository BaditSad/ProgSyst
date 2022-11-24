using EasySave;
using System;
using System.IO;

namespace System
{
    public class Save_Show
    {
        private static string targetFolder = "";
        private static bool targetIsExist = false;
        public void Save_En()
        {

        }
        public void Save_Fr()
        {

        }
        public void Show_En()
        {

        }
        public void Show_Fr()
        {

        }
        public void QuerySaves(string lang)
        {
            var NewBanner = new Banner();
            Console.Clear();
            NewBanner.EasySaveBanner();

            if (lang == "en")
            {
                if (targetFolder == null)
                {
                    Console.WriteLine("\r\nTarget folder do not exist!");
                }
                else
                {
                    string[] fileNames = Directory.GetFiles(targetFolder);

                    if (fileNames.Length == 0)
                    {
                        Console.WriteLine("\r\nThere is nothing to show");
                    }
                    else
                    {
                        Console.WriteLine();
                        for (int i = 0; i < fileNames.Length; i++)
                        {
                            Console.WriteLine(fileNames[i]);
                        }
                    }
                }
                Console.Write("\r\nPress any key to menu...");
                Console.ReadKey();
            }
            else if (lang == "fr")
            {
                if (targetFolder == null)
                {
                    Console.WriteLine("\r\nCible dossier n'existe pas!");
                }
                else
                {
                    string[] fileNames = Directory.GetFiles(targetFolder);

                    if (fileNames.Length == 0)
                    {
                        Console.WriteLine("\r\nIl y a aucun fichier...");
                    }
                    else
                    {
                        Console.WriteLine();
                        for (int i = 0; i < fileNames.Length; i++)
                        {
                            Console.WriteLine(fileNames[i]);
                        }
                    }
                }
                Console.Write("\r\nAppuy¨¦ un bouton pour retourner au menu...");
                Console.ReadKey();
            }

            Console.Clear();
        }

        public void CreateSave(string lang)
        {
            var NewBanner = new Banner();
            string saveName = "";
            string targetFile = targetFolder + "\\" + saveName;

            while (true)
            {
                Console.Clear();
                NewBanner.EasySaveBanner();

                if (lang == "en")
                {
                    //verify target folder exist?
                    if (!targetIsExist)
                    {
                        //enter target folder path
                        Console.Write("\r\nTarget folder path: ");
                        targetFolder = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("\r\nTarget folder path: " + targetFolder);
                    }

                    //verify path is true?
                    if (!Directory.Exists(targetFolder))
                    {
                        string key;
                        Console.Clear();
                        NewBanner.EasySaveBanner();

                        Console.WriteLine("\r\nTarget folder do not exist!");
                        Thread.Sleep(500);
                        Console.WriteLine("\r\nDo you want to create one?");
                        Console.WriteLine("######### Yes:Y/No:N #########");
                        key = Console.ReadLine();

                        if (key == "Y" || key == "y")
                        {
                            Directory.CreateDirectory(targetFolder);
                            targetIsExist = true;
                            Console.WriteLine("Created successfully...");
                            Thread.Sleep(500);
                        }
                        else if (key == "N" || key == "n")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid parameter");
                            Thread.Sleep(500);
                            continue;
                        }
                    }
                    Console.Clear();
                    NewBanner.EasySaveBanner();
                    Console.Write("\r\nTarget folder path: " + targetFolder);

                    Console.Write("\r\nPlease enter a save name: ");
                    saveName = Console.ReadLine();
                    File.Create(targetFile).Close();
                    Console.WriteLine("\r\nCreated successfully...");

                    //return to menu
                    Console.Write("\r\nPress any key to menu...");
                    Console.ReadKey();
                }
                else if (lang == "fr")
                {
                    if (!targetIsExist)
                    {
                        //entrer cible dossier path
                        Console.Write("\r\nCible dossier adresse: ");
                        targetFolder = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("\r\nCible dossier adresse: " + targetFolder);
                    }

                    //verify path is true?
                    if (!Directory.Exists(targetFolder))
                    {
                        string key;

                        Console.Clear();
                        NewBanner.EasySaveBanner();

                        Console.WriteLine("\r\nCible dossier n'existe pas!");
                        Thread.Sleep(500);
                        Console.WriteLine("\r\nEst-ce que tu veux cr¨¦er un nouveau?");
                        Console.WriteLine("######### Oui:O/Non:N #########");
                        key = Console.ReadLine();

                        if (key == "O" || key == "o")
                        {
                            Directory.CreateDirectory(targetFolder);
                            Console.WriteLine("c'est fait...");
                            Thread.Sleep(500);
                        }
                        else if (key == "N" || key == "n")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Parametre invalide");
                            Thread.Sleep(500);
                            continue;
                        }
                    }
                    Console.Clear();
                    NewBanner.EasySaveBanner();
                    Console.Write("\r\nCible dossier adresse: " + targetFolder);

                    Console.Write("\r\nVeuillez entrer un nom de sauvegarde: ");
                    saveName = Console.ReadLine();
                    File.Create(targetFile).Close();
                    Console.WriteLine("\r\nc'est fait...");

                    //return to menu
                    Console.Write("\r\nAppuy¨¦ un bouton pour retourner au menu...");
                    Console.ReadKey();
                }

                Console.Clear();
                return;
            }
        }
    }
}
