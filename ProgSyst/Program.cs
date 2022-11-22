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
            bool start = true;
            string key;
            string lang = "";
            string path = Directory.GetCurrentDirectory();
            bool firstLaunch = true; //à recup dans config pour savoir si c'est le premier demarrage ou non pour choisir la langue
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
                        Console.WriteLine("\n1 - english / 2 - français");
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
                    firstLaunch = false; //IL FAUDRA L'ECRIRE DANS LE FICHIER CONFIG EGALEMENT
                }
                else //si ce n'est pas le premier lancement on recupère la langue
                {
                    lang = "en"; //à recup dans config pour ne pas changer la langue à tout les démarrages !
                }
                //--------------------------------------------------------
                //Detection du premier lancement dans la boucle principale
                //--------------------------------------------------------
                if (start == true)
                {
                    //Verification des dossiers
                    //S'ils n'existent pas alors ils sont créés (en englais)
                    if (lang == "en")
                    {
                        if (!Directory.Exists(path + "path_source"))
                        {
                            Console.WriteLine($"Directory {path + "path_source"} does not exist!");
                            Directory.CreateDirectory(path + "path_source");
                            Console.WriteLine("created...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "path_source"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_target"))
                        {
                            Console.WriteLine($"Directory {path + "path_target"} does not exist!");
                            Directory.CreateDirectory(path + "path_target");
                            Console.WriteLine("created...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "path_target"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_dailylog"))
                        {
                            Console.WriteLine($"Directory {path + "path_dailylog"} does not exist!");
                            Directory.CreateDirectory(path + "path_dailylog");
                            Console.WriteLine("created...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "path_dailylog"} exists!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_statelog"))
                        {
                            Console.WriteLine($"Directory {path + "path_statelog"} does not exist!");
                            Directory.CreateDirectory(path + "path_statelog");
                            Console.WriteLine("created...");
                        }
                        else
                        {
                            Console.WriteLine($"Directory {path + "path_statelog"} exists!");
                        }
                    }
                    //Verification des dossiers
                    //S'ils n'existent pas alors ils sont créés (en englais)
                    else if (lang == "fr")
                    {
                        if (!Directory.Exists(path + "path_source"))
                        {
                            Console.WriteLine($"Dossier {path + "path_source"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "path_source");
                            Console.WriteLine("créer...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "path_source"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_target"))
                        {
                            Console.WriteLine($"Dossier {path + "path_target"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "path_target");
                            Console.WriteLine("créer...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "path_target"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_dailylog"))
                        {
                            Console.WriteLine($"Dossier {path + "path_dailylog"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "path_dailylog");
                            Console.WriteLine("créer...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "path_dailylog"} éxiste déjà!");
                        }
                        Thread.Sleep(500);
                        if (!Directory.Exists(path + "path_statelog"))
                        {
                            Console.WriteLine($"Dossier {path + "path_statelog"} n'éxiste pas!");
                            Directory.CreateDirectory(path + "path_statelog");
                            Console.WriteLine("créer...");
                        }
                        else
                        {
                            Console.WriteLine($"Dossier {path + "path_statelog"} éxiste déjà!");
                        }
                    }
                    Thread.Sleep(500);
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
                    Console.WriteLine("\nActual path : " + path);
                    Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Manage folders\n4 - Select language\n5 - Close\n");
                }
                else if (lang == "fr")
                {
                    Console.WriteLine("\nChemin actuel : " + path);
                    Console.WriteLine("\n\n1 - Create save\n2 - Show saves\n3 - Manage folders\n4 - Select language\n5 - Close\n");
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
                        if (lang == "en")
                        {
                            Console.Clear();
                            if (Directory.Exists(path + "path_source"))
                            {
                                Directory.Delete(path + "path_source");
                                Console.WriteLine($"Directory {path + "path_source"} deleted!");
                            }
                            else
                            {
                                Console.WriteLine("\"Source\" non-existent.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_target"))
                            {
                                Directory.Delete(path + "path_target");
                                Console.WriteLine($"Directory {path + "path_target"} deleted!");
                            }
                            else
                            {
                                Console.WriteLine("\"Target\" non-existent.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_dailylog"))
                            {
                                Directory.Delete(path + "path_dailylog");
                                Console.WriteLine($"Directory {path + "path_dailylog"} deleted!");
                            }
                            else
                            {
                                Console.WriteLine("\"Daily log\" non-existent.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_statelog"))
                            {
                                Directory.Delete(path + "path_statelog");
                                Console.WriteLine($"Directory {path + "path_statelog"} deleted!");
                            }
                            else
                            {
                                Console.WriteLine("\"State log\" non-existent.");
                            }
                            Thread.Sleep(500);
                            path = "Ø";
                            Console.Write("\nPress any key to continue... ");
                            Console.ReadLine();
                        }
                        else if (lang == "fr")
                        {
                            Console.Clear();
                            if (Directory.Exists(path + "path_source"))
                            {
                                Directory.Delete(path + "path_source");
                                Console.WriteLine($"Dossier {path + "path_source"} supprimé!");
                            }
                            else
                            {
                                Console.WriteLine("\"Source\" inexistant.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_target"))
                            {
                                Directory.Delete(path + "path_target");
                                Console.WriteLine($"Dossier {path + "path_target"} supprimé!");
                            }
                            else
                            {
                                Console.WriteLine("\"Target\" inexistant.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_dailylog"))
                            {
                                Directory.Delete(path + "path_dailylog");
                                Console.WriteLine($"Dossier {path + "path_dailylog"} supprimé!");
                            }
                            else
                            {
                                Console.WriteLine("\"Daily log\" inexistant.");
                            }
                            Thread.Sleep(500);
                            if (Directory.Exists(path + "path_statelog"))
                            {
                                Directory.Delete(path + "path_statelog");
                                Console.WriteLine($"Dossier {path + "path_statelog"} supprimé!");
                            }
                            else
                            {
                                Console.WriteLine("\"State log\" inexistant.");
                            }
                            Thread.Sleep(500);
                            path = "Ø";
                            Console.Write("\nAppuyé sur une touche pour continuer... ");
                            Console.ReadLine();
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
                        Console.ReadLine();
                    }
                    else if (keyL == "2")
                    {
                        lang = "fr";
                        Console.Clear();
                        Console.WriteLine("Langue : français");
                        Console.Write("\nAppuyé sur une touche pour continuer... ");
                        Console.ReadLine();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _______     ___           _______.____    ____  _______.     ___   ____    ____  _______\n|   ____|   /   \\         /       |\\   \\  /   / /       |    /   \\  \\   \\  /   / |   ____|\n|  |__     /  ^  \\       |   (----` \\   \\/   / |   (----`   /  ^  \\  \\   \\/   /  |  |_\n|   __|   /  /_\\  \\       \\   \\      \\_    _/   \\   \\      /  /_\\  \\  \\      /   |   __|\n|  |____ /  _____  \\  .----)   |       |  | .----)   |    /  _____  \\  \\    /    |  |____\n|_______/__/     \\__\\ |_______/        |__| |_______/    /__/     \\__\\  \\__/     |_______| .V1");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
