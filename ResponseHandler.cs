 // Handles chatbot responses
using System;

namespace CyberSecurityChatbot
{
    class ResponseHandler
    {
        private string _username;

        public void SetUsername(string username)
        {
            _username = username;
        }

        public string GetResponse(string input)
        {
            string response = "";

            switch (input.ToLower())
            {
                case "password":
                    response += "Create strong passwords by:\n- Using at least 12 characters\n- Mixing letters, numbers, and symbols\n- Avoiding personal information\n- Using a password manager";
                    break;
                case "phishing":
                    response += "Watch out for phishing:\n- Suspicious emails or links\n- Urgent requests for personal info\n- Poor spelling and grammar";
                    break;
                case "browsing":
                    response += "Browse safely by:\n- Using secure websites (https)\n- Avoiding unknown links\n- Keeping your software updated";
                    break;
                case "help":
                    response += "You can ask me about:\n- Password safety\n- Phishing scams\n- Secure browsing";
                    break;
                case "purpose":
                    response += "My purpose is to guide you on how to protect yourself online and understand basic cybersecurity practices.";
                    break;
                default:
                    response += "I didn’t understand that. Try asking about passwords, phishing, or browsing.";
                    break;
            }

            return response;
        }
    }
}
