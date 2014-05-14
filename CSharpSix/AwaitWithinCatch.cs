using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSix
{
    public class AwaitWithinCatch
    {
        public async void Sample()
        {

            try
            {
                // ...
            }
            catch
            {
                // Now you can await within catch expressions.
                await Task.Factory.StartNew(() => { });
            }
            finally
            {
                //await cleanup();
            }
        }

    }
}
