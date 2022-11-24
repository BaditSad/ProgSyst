using System;

namespace EasySave
{
    class Values
    {
        string key;
        string lang;
        bool firstLaunch;
        string pathConfig;
        string pathFolder;
        public Values(string v_key, string v_lang, bool v_firstLaunch, string v_pathConfig, string v_pathFolder)
        {
            this.key = v_key;
            this.lang = v_lang;
            this.firstLaunch = v_firstLaunch;
            this.pathConfig = v_pathConfig;
            this.pathFolder = v_pathFolder;
        }
    }
}