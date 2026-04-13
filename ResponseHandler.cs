 // Handles chatbot responses
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class ResponseHandler
    {
        private string _username;
        private bool _hasGreeted = false;

        public void SetUsername(string username)
        {
            _username = username;
        }

        public string GetResponse(string input)
        {
            string response = "";

            if (!_hasGreeted)
            {
                response += $"Hi {_username}, I'm here to help you stay safe online. Choose a topic you'd like help with, such as passwords, phishing, or safe browsing.\n\n";
                _hasGreeted = true;
            }

            switch (input.ToLower())
            {
                case "purpose":
                    response += "My purpose is to guide you on how to protect yourself online and understand basic cybersecurity practices.";
                    break;

                case "help":
                    response += "You can ask me about:\n" +
                                "- Password safety\n" +
                                "- Phishing scams\n" +
                                "- Secure browsing\n" +
                                "Just type the topic you're interested in!";
                    break;

                case "password":
                    response += "Create strong passwords by:\n" +
                                "- Using at least 12 characters\n" +
                                "- Mixing letters, numbers, and symbols\n" +
                                "- Avoiding personal information\n" +
                                "- Using a password manager";
                    break;

                case "phishing":
                    response += "Watch out for phishing:\n" +
                                "- Suspicious emails or links\n" +
                                "- Urgent requests for personal info\n" +
                                "- Poor spelling and grammar";
                    break;

                case "browsing":
                    response += "Browse safely by:\n" +
                                "- Using secure websites (https)\n" +
                                "- Avoiding unknown links\n" +
                                "- Keeping your software updated";
                    break;

                default:
                    response += "I didn’t understand that. Try asking about passwords, phishing, or browsing.";
                    break;
            }

            return response;
        }
    }
}
