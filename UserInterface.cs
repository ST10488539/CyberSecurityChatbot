using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    class UserInterface
    {
        public void TypeText(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void Divider(char symbol = '=', int length = 50)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(symbol, length));
            Console.ResetColor();
        }

        public void Header(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Divider();
            Console.WriteLine($" {title.ToUpper()}");
            Divider();
            Console.ResetColor();
        }

        public void ShowWelcomeScreen()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   _____      _               _____                      _ _            _____ _           _   _           _   \r\n  / ____|    | |             / ____|                    (_) |          / ____| |         | | | |         | |  \r\n | |    _   _| |__   ___ _ _| (___   ___  ___ _   _ _ __ _| |_ _   _  | |    | |__   __ _| |_| |__   ___ | |_ \r\n | |   | | | | '_ \\ / _ \\ '__\\___ \\ / _ \\/ __| | | | '__| | __| | | | | |    | '_ \\ / _` | __| '_ \\ / _ \\| __|\r\n | |___| |_| | |_) |  __/ |  ____) |  __/ (__| |_| | |  | | |_| |_| | | |____| | | | (_| | |_| |_) | (_) | |_ \r\n  \\_____\\__, |_.__/ \\___|_| |_____/ \\___|\\___|\\__,_|_|  |_|\\__|\\__, |  \\_____|_| |_|\\__,_|\\__|_.__/ \\___/ \\__|\r\n         __/ |                                                  __/ |                                         \r\n        |___/                                                  |___/                                           ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===== DATA CENTER =====");
            TypeText("Welcome to Data Center");

            Console.Write("\nWhat is your name? ");
            string name = Console.ReadLine();

            TypeText($"Hi {name}. Welcome to Cyber Data Center");

            Console.ResetColor();
        }

        public void InvalidOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid option selected.");
            Console.ResetColor();
        }

        public void ReturnToMain(Action menuMethod)
        {
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
            menuMethod();
        }
    }
}