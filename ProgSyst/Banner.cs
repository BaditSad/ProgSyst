using System;

namespace EasySave
{
    class Banner
    {
        //------\\
        //Banner\\
        //------\\
        public void EasySaveBanner() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" \r\n███████╗░█████╗░░██████╗██╗░░░██╗░██████╗░█████╗░██╗░░░██╗███████╗\r\n██╔════╝██╔══██╗██╔════╝╚██╗░██╔╝██╔════╝██╔══██╗██║░░░██║██╔════╝\r\n█████╗░░███████║╚█████╗░░╚████╔╝░╚█████╗░███████║╚██╗░██╔╝█████╗░░\r\n██╔══╝░░██╔══██║░╚═══██╗░░╚██╔╝░░░╚═══██╗██╔══██║░╚████╔╝░██╔══╝░░\r\n███████╗██║░░██║██████╔╝░░░██║░░░██████╔╝██║░░██║░░╚██╔╝░░███████╗\r\n╚══════╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚══════╝ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" .V1");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" (alpha)\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}