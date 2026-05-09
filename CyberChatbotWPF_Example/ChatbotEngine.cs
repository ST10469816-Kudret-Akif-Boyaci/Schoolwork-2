using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberChatbotWPF_Example
{
    public class ChatbotEngine
    {
        private Random random = new Random();
        private UserMemory memory;// = new UserMemory();

        private Dictionary<string, List<string>> keyworkResponses;

        public ChatbotEngine(UserMemory userMemory)
        {
            memory = userMemory;

            keyworkResponses = new Dictionary<string, List<string>>()
            {
                {
                    "password",
                        new List<string>()
                        {
                            "use strong passwords for every account.",
                            "avoid using your name or birthday",
                            "use a password manager"
                        }
                },
                {
                    "scam",
                        new List<string>()
                        {
                            "be carefull of urgent messages asking for money or details",
                            "Scammers often pretend to be trusted organizations",
                            "always verify susticious emails, messages or calls before responding."
                        }
                },
                {
                      "phising",
                        new List<string>()
                        {
                            "never click suspicious links in emails or sms messsages",
                            "check sender address carefully before trusting an email",
                            "phising attacks often create urgency to trick you reacting quickly."
                        }
                }
            };
        }
        public string getresponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "please type a message";

            string lowerInput = input.ToLower();

            foreach (var keyword in keyworkResponses.Keys)
            {
                if (lowerInput.Contains(keyword))
                {
                    memory.lasttopic = keyword;
                    return getrandomresponses(keyword);
                }
            }
            return "I am not sure I understand, please rephrase";
        }
        private string getrandomresponses(string keyword)
        {
            List<string> responses = keyworkResponses[keyword];
            int index = random.Next(responses.Count);
            return responses[index];
        }
    }
}
