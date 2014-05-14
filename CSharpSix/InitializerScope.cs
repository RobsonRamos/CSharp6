using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSix
{
                                  // Where is the constructor?!            // Calling other class!
    public class InitializerScope(string message, protected string xpto) : Exception(message)
    {
        public string OtherMessage { get; } = message; // Readonly auto properties!!!!!!!!

    }

    public class OtherScope(string message, protected string xpto) :  InitializerScope(message, xpto)
    {

        public bool IsAsync { get; } = Equals(null, null); // Readonly auto properties! 

        public void Test()
        {
            xpto = ""; // Remember the protected field ?!
        }

       
    }
}
