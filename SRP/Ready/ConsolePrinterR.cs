using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ready
{
    class ConsolePrinterR : IPrinterR
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
