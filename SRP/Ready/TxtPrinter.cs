using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ready
{
    class TxtPrinter : IPrinterR
    {
        string _path;

        public TxtPrinter(string path)
        {
            _path = path;
        }

        public void Print(string text)
        {
            using (StreamWriter sw = new StreamWriter(_path, true, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
        }
    }
}
