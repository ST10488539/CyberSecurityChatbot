 // Handles UI formatting and display
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

        public void DrawHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(
@"   _____      _               _____                      _ _            _____ _           _   _           _   
  / ____|    | |             / ____|                    (_) |          / ____| |         | | | |         | |  
 | |    _   _| |__   ___ _ _| (___   ___  ___ _   _ _ __ _| |_ _   _  | |    | |__   __ _| |_| |__   ___ | |_ 
 | |   | | | | '_ \ / _ \ '__\___ \ / _ \/ __| | | | '__| | __| | | | | |    | '_ \ / _` | __| '_ \ / _ \| __|
 | |___| |_| | |_) |  __/ |  ____) |  __/ (__| |_| | |  | | |_| |_| | | |____| | | | (_| | |_| |_) | (_) | |_ 
  \_____\\__, |_.__/ \___|_| |_____/ \___|\___|\__,_|_|  |_|\\__|\__, |  \_____|_| |_|\__,_|\__|_.__/ \___/ \__|
         __/ |                                                  __/ |                                         
        |___/                                                  |___/                                           ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===== DATA CENTER =====");
            Console.ResetColor();
        }

        public void InvalidOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid option selected.");
            Console.ResetColor();
        }
    }
}
