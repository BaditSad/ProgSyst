using System;

namespace EasySave
{
    class Interface
    {
        public void MainLaunch()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Values.Instance.Start = true;
            Values.Instance.PathConfig = Directory.GetCurrentDirectory();
         
            var CheckF = new ModelView();
            CheckF.FolderChecker();

            //---------------------------------
            //Lancement de la boucle principale
            //---------------------------------
            while (true)
            {
                var FirstLaunch = new ModelView();
                FirstLaunch.FirstLaunch();
                //--------------------------------------------------------
                //Detection du premier lancement dans la boucle principale
                //--------------------------------------------------------
                if (Values.Instance.Start == true)
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
                if (Values.Instance.Key == "1") //Création de sauvegarde
                {
                    var Save = new ModelView();
                    Save.Save();
                }
                else if (Values.Instance.Key == "2") //Affichage des sauvegardes
                {
                    var Show = new ModelView();
                    Show.Show();
                }
                else if (Values.Instance.Key == "3") // 1Configuration
                {
                    var Config = new ModelView();
                    Config.Configuration();
                    if (Values.Instance.KeyM == "1") //Set default path
                    {
                        var Path = new ModelView();
                        Path.PathDefault();
                    }
                    else if (Values.Instance.KeyM == "2") //Select language
                    {
                        var Language = new ModelView();
                        Language.Language();
                    }
                    else if (Values.Instance.KeyM == "3") //Clear logs
                    {
                        var ClearL = new ModelView();
                        ClearL.Logs();
                    }
                    else if (Values.Instance.KeyM == "4") //Uninstall
                    {
                        var Uninstall = new ModelView();
                        Uninstall.Uninstall();
                    }
                    else if (Values.Instance.KeyM == "5")
                    {
                        continue;
                    }
                }
                else if (Values.Instance.Key == "4")
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