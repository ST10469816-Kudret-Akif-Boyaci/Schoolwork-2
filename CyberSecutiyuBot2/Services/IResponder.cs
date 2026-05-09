using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CyberSecurityBot2.Services
{
    internal interface IResponder
    {
        //can only declare not implement
        bool Canrespond(string message); //implememt later in the inheritance derived class
        string Getresponse();//implememt later in the inheritance derived class
    }
}
