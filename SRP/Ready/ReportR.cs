using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ready
{
    class ReportR
    {
        private List<string> _pages;

        private uint _currentPage;

        public ReportR(List<string> pages)
        {
            _pages = pages;
            _currentPage = 0;
        }

        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(uint pageNumber)
        {
            if (pageNumber < _pages.Count)
            {
                Console.WriteLine($"Переход к странице {pageNumber}");
                _currentPage = pageNumber;
            }
            else
            {
                Console.WriteLine($"Страницы {pageNumber} не существует");
            }
        }

        public void Print(IPrinterR printer)
        {
            printer.Print($"Отображение страницы {_currentPage}\n{_pages[(int)_currentPage]}");
        }
    }
}
