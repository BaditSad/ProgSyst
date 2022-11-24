using System;
using System.Security.Cryptography.X509Certificates;

namespace EasySave
{
    class ModelView
    {

        public void FolderChecker()
        {
            var CheckF = new FolderChecker();
            CheckF.CheckFolders();
        }
        public void FileChecker()
        {
            if (Values.Instance.Lang == "en")
            {
                var Checker_LangEn = new FileChecker();
                Checker_LangEn.Checker_En();
            }
            else if (Values.Instance.Lang == "fr")
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
        public void Menu()
        {
            if (Values.Instance.Lang == "en")
            {
                var Menu_LangEn = new Menu();
                Menu_LangEn.Menu_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Menu_LangFr = new Menu();
                Menu_LangFr.Menu_Fr();
            }
        }
        public void Configuration()
        {
            if (Values.Instance.Lang == "en")
            {
                var Config_LangEn = new Configuration();
                Config_LangEn.Config_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Config_LangFr = new Configuration();
                Config_LangFr.Config_Fr();
            }
        }
        public void PathDefault()
        {
            if (Values.Instance.Lang == "en")
            {
                var Path_LangEn = new DefaultPath();
                Path_LangEn.Path_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Path_LangFr = new DefaultPath();
                Path_LangFr.Path_Fr();
            }
        }
        public void Language()
        {
            if (Values.Instance.Lang == "en")
            {
                var Language_LangEn = new Language();
                Language_LangEn.Language_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Language_LangFr = new Language();
                Language_LangFr.Language_Fr();
            }
        }
        public void Uninstall()
        {
            if (Values.Instance.Lang == "en")
            {
                var Uninstall_LangEn = new Uninstall();
                Uninstall_LangEn.Uninstall_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Uninstall_LangFr = new Uninstall();
                Uninstall_LangFr.Uninstall_Fr();
            }

        }
        public void Save()
        {
            if (Values.Instance.Lang == "en")
            {
                var Save_LangEn = new Save_Show();
                Save_LangEn.Save_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Save_LangFr = new Save_Show();
                Save_LangFr.Save_Fr();
            }
        }
        public void Show()
        {
            if (Values.Instance.Lang == "en")
            {
                var Show_LangEn = new Save_Show();
                Show_LangEn.Show_En();
            }
            else if (Values.Instance.Lang == "fr")
            {
                var Show_LangFr = new Save_Show();
                Show_LangFr.Show_Fr();
            }
        }
    }
}