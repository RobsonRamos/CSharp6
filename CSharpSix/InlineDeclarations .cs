using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSix
{
    public class InlineDeclarations
    {

        public void Sample()
        {
            var dictionary = new Dictionary<string, string>()
            {
                // Indexed Members again?!
                $x = "X",
                $y = "Y"
            };


            // Declare an out variable. IT DOESN'T ANYMORE!
            if (dictionary.TryGetValue("", out string myString))
            {
                int i = myString.Length;
            }
        }
    }
}
