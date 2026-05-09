using CyberSecurityBot2.Services;
using CyberSecutiyuBot2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecutiyuBot2.Services
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
