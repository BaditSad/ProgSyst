using System;

namespace EasySave
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
                var FirstLaunch = new ModelView();
                FirstLaunch.Language();
                //--------------------------------------------------------
                //Detection du premier lancement dans la boucle principale
                //--------------------------------------------------------
                if (start == true)
                {
                    var Checker = new ModelView();
                    Checker.FileChecker();
                }
                Console.Clear();
                //--------------------
                //Affichage principale
                //--------------------
                var Menu = new ModelView();
                Menu.Menu();
                //------------------
                //Detection du choix
                //------------------
                if (key == "1") //Création de sauvegarde
                {
                    Console.Clear();
                    var save = new ModelView();
                    save.ModelSave();
                }
                else if (key == "2") //Affichage des sauvegardes
                {
                    Console.Clear();
                    var show = new ModelView();
                    show.ModelShow();
                }
                else if (key == "3") // Configuration
                {
                    var Config = new ModelView();
                    Config.Configuration();
                    if (keyM == "1") //Set default path
                    {
                        var Path = new ModelView();
                        Path.PathDefault();
                    }
                    else if (keyM == "2") //Select language
                    {
                        var Language = new ModelView();
                        Language.Language();
                    }
                    else if (keyM == "3") //Uninstall
                    {
                        var Uninstall = new ModelView();
                        Uninstall.Uninstall();
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
    }
}