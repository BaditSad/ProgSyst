using System;

namespace EasySave
{
    class Values
    {
        public string Key //Menu key
        {
            get; set;
        }
        public string KeyM //Configuration menu key
        {
            get; set;
        }
        public string Lang //Language
        {
            get; set;
        }
        public bool FirstLaunch //Program first launch
        {
            get; set;
        }
        public bool Start //Loop first launch
        {
            get; set;
        }
        public string PathConfig //Config path folder
        {
            get; set;
        }
        public string PathFolder //Target path folder
        {
            get; set;
        }
        public string log //Transfer log
        {
            get; set;
        }
        private Values() { }
        public static readonly Values Instance = new Values();
    }
}