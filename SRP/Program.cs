using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Correct;
using SRP.Ready;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pages = new List<string>() { "page1", "page2", "page3", "page4", "page5" };

            Report report = new Report(pages);

            report.GoToPage(3);
            report.Print();
            report.GoToFirstPage();
            report.Print();

            #region[Ready]
            IPrinterR printerR = new ConsolePrinterR();
            ReportR reportR = new ReportR(pages);

            reportR.GoToPage(3);
            reportR.Print(printerR);
            reportR.GoToFirstPage();
            reportR.Print(printerR);

            #endregion

            Console.ReadKey(true);
        }
    }
}
