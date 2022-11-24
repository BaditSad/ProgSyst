using System;

namespace EasySave
{
    class Values
    {
        public string Key
        {
            get; set;
        }
        public string KeyM
        {
            get; set;
        }
        public string Lang
        {
            get; set;
        }
        public bool FirstLaunch
        {
            get; set;
        }
        public bool Start
        {
            get; set;
        }
        public string PathConfig
        {
            get; set;
        }
        public string PathFolder
        {
            get; set;
        }
        public string log
        {
            get; set;
        }
        private Values() { }
        public static readonly Values Instance = new Values();
    }
}