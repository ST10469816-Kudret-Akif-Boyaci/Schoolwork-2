using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot.Services
{
    internal class HelpResponder : IResponder
    {
        public bool Canrespond(string message)
        {
            return message.Contains("help") || message.Contains("purpose") || message.Contains("what can I ask");
        }

        public string Getresponse()
        {
            return "you can ask me about passwords, phising,safe browsing, or type history";
        }
    }
}
