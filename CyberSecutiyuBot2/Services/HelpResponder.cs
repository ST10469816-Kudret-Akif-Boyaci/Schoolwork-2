using CyberSecutiyuBot2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyberSecurityBot2.Services
{
    internal class HelpResponder : IResponder
    {
        public bool Canrespond(string message)
        {
            return message.Contains("help") || message.Contains("purpose") || message.Contains("help");
        }

        public string Getresponse()
        {
            return "you can ask me about passwords, phising,safe browsing, or type history";
        }
    }
}
