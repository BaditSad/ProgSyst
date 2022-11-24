using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class ModelView
    {

        private static Save_Show save_Show = new Save_Show();

        public void FileChecker()
        {
            if (lang == "en")
            {
                var Checker_LangEn = new FileChecker();
                Checker_LangEn.Checker_En();
            }
            else if (lang = "fr")
            {
                var Checker_LangFr = new FileChecker();
                Checker_LangFr.Checker_Fr();
            }
        }
        public void FirstLaunch()
        {
            var FL_Lang = new Language();
            FL_Lang.FirstLaunch();
        }
        public void Menu(string lang)
        {
            if (lang == "en")
            {
                var Menu_LangEn = new Menu();
                Menu_LangEn.Menu_En();
            }
            else if (lang == "fr")
            {
                var Menu_LangFr = new Menu();
                Menu_LangFr.Menu_Fr();
            }
        }
        public void Configuration()
        {
            if (lang == "en")
            {
                var Config_LangEn = new Configuration();
                Config_LangEn.Config_En();
            }
            else if (lang = "fr")
            {
                var Config_LangFr = new Configuration();
                Config_LangFr.Config_Fr();
            }
        }
        public void PathDefault()
        {
            if (lang == "en")
            {
                var Path_LangEn = new DefaultPath();
                Path_LangEn.Path_En();
            }
            else if (lang = "fr")
            {
                var Path_LangFr = new DefaultPath();
                Path_LangFr.Path_Fr();
            }
        }
        public void Language()
        {
            if (lang == "en")
            {
                var Language_LangEn = new Language();
                Language_LangEn.Language_En();
            }
            else if (lang = "fr")
            {
                var Language_LangFr = new Language();
                Language_LangFr.Language_Fr();
            }
        }
        public void Uninstall()
        {
            if (lang == "en")
            {
                var Uninstall_LangEn = new Uninstall();
                Uninstall_LangEn.Uninstall_En();
            }
            else if (lang = "fr")
            {
                var Uninstall_LangFr = new Uninstall();
                Uninstall_LangFr.Uninstall_Fr();
            }

        }
        public void ModelSave(string lang)
        {
            save_Show.CreateSave(lang);
        }
        public void ModelShow(string lang)
        {
            save_Show.QuerySaves(lang);
        }
    }
}