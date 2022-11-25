using System;

namespace EasySave
{
    class Interface
    {
        public void MainLaunch()
        {
            //Set values
            //-----------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Values.Instance.Start = true;
            Values.Instance.PathConfig = Directory.GetCurrentDirectory();
            //-----------------------------------------------------------

            //Check if folders exist
            //---------------------------
            var CheckF = new ModelView();
            CheckF.FolderChecker();
            //---------------------------

            while (true)
            {
                //Ask language and welcome message
                //--------------------------------
                var FirstLaunch = new ModelView();
                FirstLaunch.FirstLaunch();
                //--------------------------------
                if (Values.Instance.Start == true)
                {
                    //Check File for lang and path
                    //----------------------------
                    var Checker = new ModelView();
                    Checker.FileChecker();
                    //----------------------------
                }
                //Show menu
                //-------------------------
                var Menu = new ModelView();
                Menu.Menu();
                //-------------------------
                if (Values.Instance.Key == "1")
                {
                    //Create save
                    //-------------------------
                    var Save = new ModelView();
                    Save.Save();
                    //-------------------------
                }
                else if (Values.Instance.Key == "2")
                {
                    //Show saves (logs)
                    //-------------------------
                    var Show = new ModelView();
                    Show.Show();
                    //-------------------------
                }
                else if (Values.Instance.Key == "3")
                {
                    //Show configuration menu
                    //---------------------------
                    var Config = new ModelView();
                    Config.Configuration();
                    //---------------------------
                    if (Values.Instance.KeyM == "1")
                    {
                        //Set default path
                        //-------------------------
                        var Path = new ModelView();
                        Path.PathDefault();
                        //-------------------------
                    }
                    else if (Values.Instance.KeyM == "2")
                    {
                        //Select language
                        //-----------------------------
                        var Language = new ModelView();
                        Language.Language();
                        //-----------------------------
                    }
                    else if (Values.Instance.KeyM == "3")
                    {
                        //Clear saves (logs)
                        //---------------------------
                        var ClearL = new ModelView();
                        ClearL.Logs();
                        //---------------------------
                    }
                    else if (Values.Instance.KeyM == "4")
                    {
                        //Uninstall by delete folders
                        //------------------------------
                        var Uninstall = new ModelView();
                        Uninstall.Uninstall();
                        //------------------------------
                    }
                    else if (Values.Instance.KeyM == "5")
                    {
                        //Go back
                        //-------
                        continue;
                        //-------
                    }
                }
                else if (Values.Instance.Key == "4")
                {
                    //Leave
                    //------------------
                    Environment.Exit(0);
                    //------------------
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