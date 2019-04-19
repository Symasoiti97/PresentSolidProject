using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP.Ready;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region[Ready]
            CookR cookR = new CookR("Bob");
            cookR.MakeDinner(new PotatoMealR());
            #endregion

            Console.ReadKey(true);
        }
    }
}
