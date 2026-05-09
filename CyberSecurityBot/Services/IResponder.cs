using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot.Services
{
    internal interface IResponder
    {
        //can only declare not implement
        bool Canrespond(string message); //implememt later in the inheritance derived class
        string Getresponse();//implememt later in the inheritance derived class
    }
}
