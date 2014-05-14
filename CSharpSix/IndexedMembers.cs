using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace CSharpSix
{

    public class IndexedMembers
    {
        // Declare an Array.
        public Dictionary<string, string> dictionary;

        public IndexedMembers()
        {
            dictionary = new Dictionary<string, string>()
            {
                // OOps... ["x"] is not necessary anymore. Coollllll.
                $x = "X Index",
                $y = "Y Index"
            };

            var valorDeX = dictionary.$x;

            WriteLine(valorDeX);

            if (dictionary.TryGetValue("", out string myString))
            {
                WriteLine(myString);       
            }


        }
    }

}
