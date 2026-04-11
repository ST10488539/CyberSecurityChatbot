using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    internal class ResponseHandler
    {
        public string GetResponse(string input)
        {
            if (input == "how are you")
                return "I'm good, thanks!";

            if (input == "purpose")
                return "I help you stay safe online.";

            if (input == "help")
                return "You can ask about passwords, phishing, and safe browsing.";

            if (input == "password")
                return "Use strong passwords and don't share them.";

            if (input == "phishing")
                return "Phishing is fake messages used to steal your information.";

            if (input == "browsing")
                return "Only visit secure websites and avoid unknown links.";

            return "I don't understand.";
        }
    }
}