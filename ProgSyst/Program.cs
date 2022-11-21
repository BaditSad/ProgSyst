using System;

namespace System
{
    public class Program
    {
        static void Main()
        {
            bool start = true;
            string key;
            while (true) //temporaire
            {
                //Verification
                //"Source", "Target", "LogJ", "LogEtat".
                string path = Directory.GetCurrentDirectory();
                if (!Directory.Exists(path + "path_source"))
                {
                    Console.WriteLine($"Directory {path + "path_source"} does not exist!");
                    Directory.CreateDirectory(path + "path_source");
                    Console.WriteLine("OK...");
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
                    Console.WriteLine("OK...");
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
                    Console.WriteLine("OK...");
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
                    Console.WriteLine("OK...");
                }
                else
                {
                    Console.WriteLine($"Directory {path + "path_statelog"} exists!");
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(" _______     ___           _______.____    ____  _______.     ___   ____    ____  _______ ");
                Console.WriteLine("|   ____|   /   \\         /       |\\   \\  /   / /       |    /   \\  \\   \\  /   / |   ____|");
                Console.WriteLine("|  |__     /  ^  \\       |   (----` \\   \\/   / |   (----`   /  ^  \\  \\   \\/   /  |  |_");
                Console.WriteLine("|   __|   /  /_\\  \\       \\   \\      \\_    _/   \\   \\      /  /_\\  \\  \\      /   |   __| ");
                Console.WriteLine("|  |____ /  _____  \\  .----)   |       |  | .----)   |    /  _____  \\  \\    /    |  |____ ");
                Console.WriteLine("|_______/__/     \\__\\ |_______/        |__| |_______/    /__/     \\__\\  \\__/     |_______|");
                Console.WriteLine("\nCurrent folder : " + path);
                Console.WriteLine("\n\n1 - Save\n2 - Show saves\n3 - Delete folders\n4 - Close\n");
                key = Console.ReadLine();
                if (key == "1")
                {
                    Console.Clear();
                    ModelViewSave save = new ModelViewSave();
                }
                else if (key == "2")
                {
                    Console.Clear();
                    ModelViewShow show = new ModelViewShow();
                }
                else if (key == "3")
                {
                    Console.Clear();
                    Directory.Delete(path + "path_source");
                    Console.WriteLine($"Directory {path + "path_source"} deleted!");
                    Thread.Sleep(500);
                    Directory.Delete(path + "path_target");
                    Console.WriteLine($"Directory {path + "path_target"} deleted!");
                    Thread.Sleep(500);
                    Directory.Delete(path + "path_dailylog");
                    Console.WriteLine($"Directory {path + "path_dailylog"} deleted!");
                    Thread.Sleep(500);
                    Directory.Delete(path + "path_statelog");
                    Console.WriteLine($"Directory {path + "path_statelog"} deleted!");
                    Thread.Sleep(500);
                }
                else if (key == "4")
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
    }
}