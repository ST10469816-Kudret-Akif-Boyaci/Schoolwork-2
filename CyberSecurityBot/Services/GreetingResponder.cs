using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot.Services
{
    internal class GreetingResponder : IResponder
    {
        public bool Canrespond(string message)
        {
            return message.Contains("how are you") || message.Contains("hello") || message.Contains("how are you");
        }

        public string Getresponse()
        {
            return " I am functioning normally and ready to assist you";
        }
    }
}
