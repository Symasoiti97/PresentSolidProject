using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Correct
{
    class Book
    {
        public string Text { get; set; }
        public ConsolePrinter Printer { get; set; }

        public void Print()
        {
            Printer.Print(Text);
        }
    }
}
