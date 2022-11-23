using System;

namespace System
{
    class Interface
    {
        public void MainLaunch()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var NewBanner = new Banner();
            bool start = true;
            string key;
            string lang = "";
            bool firstLaunch;
            string pathConfig = Directory.GetCurrentDirectory();
            string pathFolder;
            if (!Directory.Exists(pathConfig + "\\Config"))
            {
                firstLaunch = true;
            }
            else
            {
                firstLaunch = false;
            }
            if (!Directory.Exists(pathConfig + "\\Config"))
            {
                Directory.CreateDirectory(pathConfig + "\\Config");
                pathFolder = pathConfig;
                StreamWriter path_folder = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                path_folder.WriteLine(pathFolder);
                path_folder.Close();
            }
            else
            {
                StreamReader path_folder = new StreamReader(pathConfig + "\\Config\\Path.txt");
                pathFolder = path_folder.ReadLine();
                path_folder.Close();
            }
            //---------------------------------
            //Lancement de la boucle principale
            //---------------------------------
            while (true)
            {
                if (firstLaunch == true) //On détecte si c'est le premier lancement sur la machine pour définir le language
                {
                    string keyFl = "0";
                    while (keyFl != "1" & keyFl != "2")
                    {
                        NewBanner.EasySaveBanner();
                        Console.WriteLine("\n1 - English / 2 - Français");
                        keyFl = Console.ReadLine();
                        Console.Clear();
                    }
                    if (keyFl == "1")
                    {
                        lang = "en";
                        StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                        config_lang.WriteLine(lang);
                        config_lang.Close();
                    }
                    if (keyFl == "2")
                    {
                        lang = "fr";
                        StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                        config_lang.WriteLine(lang);
                        config_lang.Close();
                    }
                    firstLaunch = false;
                }
                else //si ce n'est pas le premier lancement on recupère la langue
                {
                    StreamReader config_lang = new StreamReader(pathConfig + "\\Config\\Lang.txt");
                    lang = config_lang.ReadLine();
                    config_lang.Close();
                }
                //--------------------------------------------------------
                //Detection du premier lancement dans la boucle principale
                //--------------------------------------------------------
                if (start == true)
                {
                    //Verification des dossiers
                    //S'ils n'existent pas alors ils sont créés (en anglais)
                    if (lang == "en")
                    {
                        if (!Directory.Exists(pathConfig + "\\Config"))
                        {
                            Directory.CreateDirectory(pathConfig + "\\Config");
                            StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                            config_lang.WriteLine(lang);
                            config_lang.Close();
                            StreamWriter config_path = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                            config_lang.WriteLine(pathFolder);
                            config_lang.Close();
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(pathConfig + "\\Dailylog"))
                        {
                            Console.WriteLine($"Directory Dailylog does not exist!");
                            Directory.CreateDirectory(pathConfig + "\\Dailylog");
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory Dailylog exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(pathConfig + "\\Statelog"))
                        {
                            Console.WriteLine($"Directory Statelog does not exist!");
                            Directory.CreateDirectory(pathConfig + "\\Statelog");
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory Statelog exists!");
                        }
                        Console.Write("\nPress any key to continue... ");
                        Console.ReadKey();
                    }
                    //Verification des dossiers
                    //S'ils n'existent pas alors ils sont créés (en englais)
                    else if (lang == "fr")
                    {
                        if (!Directory.Exists(pathConfig + "\\Config"))
                        {
                            Directory.CreateDirectory(pathConfig + "\\Config");
                            StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                            config_lang.WriteLine(lang);
                            config_lang.Close();
                            StreamWriter config_path = new StreamWriter(pathConfig + "\\Config\\Path.txt");
                            config_lang.WriteLine(pathFolder);
                            config_lang.Close();
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(pathConfig + "\\Dailylog"))
                        {
                            Console.WriteLine($"Dossier Dailylog n'éxiste pas!");
                            Directory.CreateDirectory(pathConfig + "\\Dailylog");
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier Dailylog éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(pathConfig + "\\Statelog"))
                        {
                            Console.WriteLine($"Dossier Statelog n'éxiste pas!");
                            Directory.CreateDirectory(pathConfig + "\\Statelog");
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier Statelog éxiste déjà!");
                        }
                        Console.Write("\nAppuyé sur une touche pour continuer... ");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    start = false;
                }
                Console.Clear();
                //--------------------
                //Affichage principale
                //--------------------
                NewBanner.EasySaveBanner();
                if (lang == "en")
                {
                    if (pathFolder == "Ø")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDefault target path : " + pathFolder);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDefault target path : " + pathFolder);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Configuration\n4 - Close\n");
                }
                else if (lang == "fr")
                {
                    if (pathFolder == "Ø")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\n\n1 - Créer une sauvegarde\n2 - Afficher sauvegardes\n3 - Configuration\n4 - Fermer\n");
                }
                key = Console.ReadLine();
                //------------------
                //Detection du choix
                //------------------
                if (key == "1") //Création de sauvegarde
                {
                    Console.Clear();
                    Model save = new ModelSave();
                }
                else if (key == "2") //Affichage des sauvegardes
                {
                    Console.Clear();
                    Model show = new ModelShow();
                }
                else if (key == "3") // Management des dossiers
                {
                    string keyM = "0";
                    while (keyM != "1" & keyM != "2" & keyM != "3" & keyM != "4")
                    {
                        Console.Clear();
                        NewBanner.EasySaveBanner();
                        if (lang == "en")
                        {
                            if (pathFolder == "Ø")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nDefault target path : " + pathFolder);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nDefault target path : " + pathFolder);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            Console.WriteLine("\nSelect an option :");
                            Console.WriteLine("\n1 - Default save path\n2 - Language\n3 - Uninstall\n4 - Back");
                        }
                        else if (lang == "fr")
                        {
                            if (pathFolder == "Ø")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nChemin cible par défaut : " + pathFolder);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            Console.WriteLine("\nChoisir une option :");
                            Console.WriteLine("\n1 - Chemin de sauvegarde par défaut\n2 - Language\n3 - Désinstaller\n4 - Retour");
                        }
                        keyM = Console.ReadLine();
                    }
                    if (keyM == "1") //Redéfinition du chemin
                    {
                        string NewPath = "";
                        bool errorPath = false;
                        while (true)
                        {
                            Console.Clear();
                            NewBanner.EasySaveBanner();
                            if (lang == "en")
                            {
                                Console.WriteLine("\nWrite \"exit\" to close.\n------------------------------\n");
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
                            else if (lang == "fr")
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
                    else if (keyM == "2")
                    {
                        string keyL = "0";
                        while (keyL != "1" & keyL != "2")
                        {
                            Console.Clear();
                            NewBanner.EasySaveBanner();
                            if (lang == "en")
                            {
                                Console.WriteLine("\nSelect language :");
                                Console.WriteLine("\n\n1 - English (active)\n2 - French\n");
                            }
                            else if (lang == "fr")
                            {
                                Console.WriteLine("\nChoisir une langue :");
                                Console.WriteLine("\n\n1 - Anglais\n2 - Français (actif)\n");
                            }
                            keyL = Console.ReadLine();
                        }
                        if (keyL == "1")
                        {
                            lang = "en";
                            Console.Clear();
                            File.Delete(pathConfig + "\\Config\\Lang.txt"); //ERREUR
                            StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                            config_lang.WriteLine(lang);
                            config_lang.Close();
                            Console.WriteLine("Language : english");
                            Console.Write("\nPress any key to continue... ");
                            Console.ReadKey();
                        }
                        else if (keyL == "2")
                        {
                            lang = "fr";
                            Console.Clear();
                            File.Delete(pathConfig + "\\Config\\Lang.txt"); //ERREUR
                            StreamWriter config_lang = new StreamWriter(pathConfig + "\\Config\\Lang.txt");
                            config_lang.WriteLine(lang);
                            config_lang.Close();
                            Console.WriteLine("Langue : français");
                            Console.Write("\nAppuyé sur une touche pour continuer... ");
                            Console.ReadKey();
                        }
                    }
                    else if (keyM == "3") //Supprimer les dossiers
                    {
                        string choiceDelete = "";
                        if (lang == "en")
                        {
                            while (choiceDelete != "y" & choiceDelete != "Y" & choiceDelete != "n" & choiceDelete != "N")
                            {
                                Console.Clear();
                                NewBanner.EasySaveBanner();
                                Console.WriteLine("\n##### DELETE FOLDERS ? #####\nY/N");
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
                        if (lang == "fr")
                        {
                            while (choiceDelete != "o" & choiceDelete != "O" & choiceDelete != "n" & choiceDelete != "N")
                            {
                                Console.Clear();
                                NewBanner.EasySaveBanner();
                                Console.WriteLine("\n#####SUPPRIMER DOSSIERS ? #####\nO/N");
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
                    else if (keyM == "4")
                    {
                        continue;
                    }
                }
                else if (key == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
        public void MenuPrincipale()
        {
            var Start = new Model();
            Start.Menu_P();
        }
    }
}