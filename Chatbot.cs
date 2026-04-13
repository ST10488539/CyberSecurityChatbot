 // Main chatbot logic and menu system

using System;

namespace CyberSecurityChatbot
{
    class Chatbot
    {
        private UserInterface ui = new UserInterface();
        private AudioPlayer audio = new AudioPlayer();
        private ResponseHandler responder = new ResponseHandler();

        private string username;
        private string password;
        private string email;

        private bool isRunning = true;

        public void Start()
        {
            Console.Title = "Cyber Security Chatbot";

            audio.PlayGreeting();
            ui.ShowWelcomeScreen();

            MainLoop();
        }

        private void MainLoop()
        {
            while (isRunning)
            {
                ShowMainMenu();
            }
        }

        private void ShowMainMenu()
        {
            ui.Header("Main Menu");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Enter your Details");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Chat with Bot 🤖");
            Console.WriteLine("4. Exit");
            Console.ResetColor();

            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    EnterDetails();
                    break;

                case "2":
                    ShowSummary();
                    break;

                case "3":
                    RunChat();
                    break;

                case "4":
                    ExitApp();
                    break;

                default:
                    ui.InvalidOption();
                    break;
            }
        }

        private void EnterDetails()
        {
            Console.Clear();
            ui.Header("User Input");

            Console.Write("Enter your name : ");
            username = Console.ReadLine();

          
         
            ui.ReturnToMain(ShowMainMenu);
        }

        private void ShowSummary()
        {
            Console.Clear();
            ui.Header("Summary");

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No data available. Please enter details first.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Username: {username}");
               
                Console.ResetColor();
            }

            ui.ReturnToMain(ShowMainMenu);
        }

        private void RunChat()
        {
            Console.Clear();
            ui.Header("Cyber Chat Mode 🤖");

            Console.WriteLine("hi "+username+" Ask anything about cybersecurity etc password,phishing,browsing!");
            Console.WriteLine("Type 'exit' to return to main menu.\n");

            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠ Please enter something "+ username);
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("Leaving chat mode...");
                    break;
                }

                string response = responder.GetResponse(input);

                ui.TypeText("Bot: " + response);
            }

            ui.ReturnToMain(ShowMainMenu);
        }

        private void ExitApp()
        {
            ui.Header("Goodbye");
            ui.TypeText("Thanks for using the Cyber Security Chatbot!");

            isRunning = false;
        }
    }
}
