using System;

namespace System
{
    public class Program
    {
        public static void Main()
        {
            //----------------------
            //Définition des valeurs
            //----------------------
            var NewBanner = new Program();
            bool start = true;
            string key;
            string lang = "";
            bool firstLaunch;
            string path = Directory.GetCurrentDirectory();
            if (!File.Exists(path + "\\Source\\Config.txt"))
            {
                firstLaunch = true;
            }
            else
            {
                firstLaunch = false;
            }
            //---------------------------------
            //Lancement de la boucle principale
            //---------------------------------
            while (true)
            {
                if (firstLaunch == true) //On détecte si c'est le premier lancement sur la machine pour définir le language
                {
                    string keyFl = "0";
                    while(keyFl != "1" & keyFl != "2")
                    {
                        NewBanner.EasySaveBanner();
                        Console.WriteLine("\n1 - English / 2 - Français");
                        keyFl = Console.ReadLine();
                        Console.Clear();
                    }
                    if (keyFl == "1")
                    {
                        lang = "en";
                    }
                    if (keyFl == "2")
                    {
                        lang = "fr";
                    }
                }
                else //si ce n'est pas le premier lancement on recupère la langue
                {
                    StreamReader config = new StreamReader(path + "\\Source\\Config.txt"); //ERREUR
                    lang = config.ReadLine();
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
                        if (!Directory.Exists(path + "\\Source"))
                        {
                            Console.WriteLine($"Directory {path + "\\Source"} does not exist!");
                            Directory.CreateDirectory(path + "\\Source");
                            StreamWriter config = new StreamWriter(path + "\\Source\\Config.txt");
                            config.WriteLine(lang);
                            config.Close();
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "\\Source"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "\\Target"))
                        {
                            Console.WriteLine($"Directory {path + "\\Target"} does not exist!");
                            Directory.CreateDirectory(path + "\\Target");
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "\\Target"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "\\Dailylog"))
                        {
                            Console.WriteLine($"Directory {path + "\\Dailylog"} does not exist!");
                            Directory.CreateDirectory(path + "\\Dailylog");
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "\\Dailylog"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "\\Statelog"))
                        {
                            Console.WriteLine($"Directory {path + "\\Statelog"} does not exist!");
                            Directory.CreateDirectory(path + "\\Statelog");
                            Console.WriteLine("Done...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "\\Statelog"} exists!");
                        }
                        Console.Write("\nPress any key to continue... ");
                        Console.ReadKey();
                    }
                    //Verification des dossiers
                    //S'ils n'existent pas alors ils sont créés (en englais)
                    else if (lang == "fr")
                    {
                        if (!Directory.Exists(path + "\\Source"))
                        {
                            Console.WriteLine($"Dossier {path + "\\Source"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "\\Source");
                            StreamWriter config = new StreamWriter(path + "\\Source\\Config.txt");
                            config.WriteLine(lang);
                            config.Close();
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "\\Source"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "\\Target"))
                        {
                            Console.WriteLine($"Dossier {path + "\\Target"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "\\Target");
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "\\Target"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "Dailylog"))
                        {
                            Console.WriteLine($"Dossier {path + "\\Dailylog"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "\\Dailylog");
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "\\Dailylog"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "\\Statelog"))
                        {
                            Console.WriteLine($"Dossier {path + "\\Statelog"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "\\Statelog");
                            Console.WriteLine("Fait...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "\\Statelog"} éxiste déjà!");
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
                    if (path == "Ø")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nActual path : " + path);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nActual path : " + path);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Manage folders\n4 - Languages\n5 - Close\n");
                }
                else if (lang == "fr")
                {
                    if (path == "Ø")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nChemin actuel : " + path);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nChemin actuel : " + path);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\n\n1 - Créer une sauvegarde\n2 - Afficher sauvegardes\n3 - Gérer dossiers\n4 - Langues\n5 - Fermer\n");
                }
                key = Console.ReadLine();
                //------------------
                //Detection du choix
                //------------------
                if (key == "1") //Création de sauvegarde
                {
                    Console.Clear();
                    ModelViewSave save = new ModelViewSave();
                }
                else if (key == "2") //Affichage des sauvegardes
                {
                    Console.Clear();
                    ModelViewShow show = new ModelViewShow();
                }
                else if (key == "3") // Management des dossiers
                {
                    string keyM = "0";
                    while (keyM != "1" & keyM != "2" & keyM != "3")
                    {
                        Console.Clear();
                        NewBanner.EasySaveBanner();
                        if (lang == "en")
                        {
                            Console.WriteLine("\nSelect an option :");
                            Console.WriteLine("\n1 - Change save path\n2 - Delete folders\n3 - Back");
                        }
                        else if (lang == "fr")
                        {
                            Console.WriteLine("\nChoisir une option :");
                            Console.WriteLine("\n1 - Changer le chemin de sauvegarde\n2 - Supprimé les dossiers\n3 - Retour");
                        }
                        keyM = Console.ReadLine();
                    }
                    if (keyM == "1") //Redéfinition du chemin
                    {
                        string NewPath = "";
                        bool errorPath = false;
                        while (NewPath == "exit" | NewPath == "quitter")
                        {
                            Console.Clear();
                            NewBanner.EasySaveBanner();
                            if (lang == "en")
                            {
                                Console.WriteLine("\nWrite \"exit\" to close.\n------------------------------\n");
                                Console.WriteLine("\nActual path : " + path + "\n");
                                if (errorPath = true)
                                {
                                    Console.WriteLine("ERROR path !");
                                }
                                Console.WriteLine("New path : ");
                                NewPath = Console.ReadLine();
                                if (Directory.Exists(NewPath))
                                {
                                    path = NewPath;
                                }
                                else
                                {
                                    errorPath = true;
                                }
                            }
                            else if (lang == "fr")
                            {
                                Console.WriteLine("\nécrire \"quitter\" pour fermer.\n------------------------------\n");
                                Console.WriteLine("\nChemin actuel : " + path + "\n");
                                if (errorPath = true)
                                {
                                    Console.WriteLine("ERREUR chemin !");
                                }
                                Console.WriteLine("Nouveau chemin : ");
                                NewPath = Console.ReadLine();
                                if (Directory.Exists(NewPath))
                                {
                                    path = NewPath;
                                }
                                else
                                {
                                    errorPath = true;
                                }
                            }
                        }
                    }
                    else if (keyM == "2") //Supprimer les dossiers
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
                                     if (Directory.Exists(path + "\\Source"))
                                     {
                                         Directory.Delete(path + "\\Source");
                                         Console.WriteLine($"Directory {path + "\\Source"} deleted!");
                                     }
                                     else
                                     {
                                         Console.WriteLine("\"Source\" non-existent.");
                                     }
                                     Thread.Sleep(500);
                                     if (Directory.Exists(path + "\\Target"))
                                     {
                                         Directory.Delete(path + "\\Target");
                                         Console.WriteLine($"Directory {path + "\\Target"} deleted!");
                                     }
                                     else
                                     {
                                         Console.WriteLine("\"Target\" non-existent.");
                                     }
                                     Thread.Sleep(500);
                                     if (Directory.Exists(path + "\\Dailylog"))
                                     {
                                         Directory.Delete(path + "\\Dailylog");
                                         Console.WriteLine($"Directory {path + "\\Dailylog"} deleted!");
                                     }
                                     else
                                     {
                                         Console.WriteLine("\"Daily log\" non-existent.");
                                     }
                                     Thread.Sleep(500);
                                     if (Directory.Exists(path + "\\Statelog"))
                                     {
                                         Directory.Delete(path + "\\Statelog");
                                         Console.WriteLine($"Directory {path + "\\Statelog"} deleted!");
                                     }
                                     else
                                     {
                                         Console.WriteLine("\"State log\" non-existent.");
                                     }
                                     Thread.Sleep(500);
                                     path = "Ø";
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
                                    if (Directory.Exists(path + "\\Source"))
                                    {
                                        Directory.Delete(path + "\\Source");
                                        Console.WriteLine($"Dossier {path + "\\Source"} supprimé!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\"Source\" inexistant.");
                                    }
                                    Thread.Sleep(500);
                                    if (Directory.Exists(path + "\\Target"))
                                    {
                                        Directory.Delete(path + "\\Target");
                                        Console.WriteLine($"Dossier {path + "\\Target"} supprimé!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\"Target\" inexistant.");
                                    }
                                    Thread.Sleep(500);
                                    if (Directory.Exists(path + "\\Dailylog"))
                                    {
                                        Directory.Delete(path + "\\Dailylog");
                                        Console.WriteLine($"Dossier {path + "\\Dailylog"} supprimé!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\"Daily log\" inexistant.");
                                    }
                                    Thread.Sleep(500);
                                    if (Directory.Exists(path + "\\Statelog"))
                                    {
                                        Directory.Delete(path + "\\Statelog");
                                        Console.WriteLine($"Dossier {path + "\\Statelog"} supprimé!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\"State log\" inexistant.");
                                    }
                                    Thread.Sleep(500);
                                    path = "Ø";
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
                    else if (keyM == "3")
                    {
                        continue;
                    }
                }
                else if (key == "4")
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
                        Console.WriteLine("Language : english");
                        Console.Write("\nPress any key to continue... ");
                        Console.ReadKey();
                    }
                    else if (keyL == "2")
                    {
                        lang = "fr";
                        Console.Clear();
                        Console.WriteLine("Langue : français");
                        Console.Write("\nAppuyé sur une touche pour continuer... ");
                        Console.ReadKey();
                    }
                }
                else if (key == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    return;
                }
            }
        }
        public void EasySaveBanner() //Texte EasySave
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" _______     ___           _______.____    ____  _______.     ___   ____    ____  _______\n|   ____|   /   \\         /       |\\   \\  /   / /       |    /   \\  \\   \\  /   / |   ____|\n|  |__     /  ^  \\       |   (----` \\   \\/   / |   (----`   /  ^  \\  \\   \\/   /  |  |_\n|   __|   /  /_\\  \\       \\   \\      \\_    _/   \\   \\      /  /_\\  \\  \\      /   |   __|\n|  |____ /  _____  \\  .----)   |       |  | .----)   |    /  _____  \\  \\    /    |  |____\n|_______/__/     \\__\\ |_______/        |__| |_______/    /__/     \\__\\  \\__/     |_______| .V1");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
