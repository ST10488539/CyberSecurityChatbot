 // Main chatbot logic and menu system

using System;

namespace CyberSecurityChatbot
{
    class Chatbot
    {
        private UserInterface ui = new UserInterface();
        private AudioPlayer audio = new AudioPlayer();
        private ResponseHandler responder = new ResponseHandler();

        public void Start()
        {
            Console.Title = "Cyber Security Chatbot";

            ui.DrawHeader();

            audio.PlayGreeting();

            Console.Write("\nEnter your name: ");
            string username = Console.ReadLine()?.Trim();
            responder.SetUsername(username);

            ui.TypeText($"\nHi {username}! Welcome to the Cyber Security Chatbot.");
            ui.TypeText("You can ask me anything about cybersecurity, like password safety, phishing, or safe browsing.");
            ui.TypeText("Type 'exit' at any time to leave the chat.");
            ui.TypeText("Please ask your question below:\n");

            RunChat();
        }

        private void RunChat()
        {
            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠ Please enter a question or command.");
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("\nExiting chat... Goodbye!");
                    break;
                }

                string response = responder.GetResponse(input);
                ui.TypeText("Bot: " + response);
                ui.TypeText("\nYou can ask another question or type 'exit' to leave the chat.\n");
            }
        }
    }
}
