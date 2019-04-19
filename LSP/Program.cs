using LSP.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            TestRectangleArea2(rect);

            Console.Read();
        }

        public static void TestRectangleArea(Rectangle rect)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
                throw new Exception("Некорректная площадь!");
        }

        public static void TestRectangleArea2(Rectangle rect)
        {
            if (rect is Square)
            {
                rect.Height = 5;
                if (rect.GetArea() != 25)
                    throw new Exception("Неправильная площадь!");
            }
            else if (rect is Rectangle)
            {
                rect.Height = 5;
                rect.Width = 10;
                if (rect.GetArea() != 50)
                    throw new Exception("Неправильная площадь!");
            }
        }
    }
}
