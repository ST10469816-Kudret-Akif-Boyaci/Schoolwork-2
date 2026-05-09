using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CyberSecurityBot2.Models
{
    public class UserProfile  // access modifier - need to be able to publicly access information
    {

        public string name { get; set; } = ""; // automatic properties
        public DateTime logintime { get; set; } = DateTime.Now; //for each text - labeled with a DateTime.now
    }
}
