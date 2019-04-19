using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ready
{
    class CookR
    {
        public string Name { get; set; }


        public CookR(string name)
        {
            Name = name;
        }

        public void MakeDinner(params IMealR[] mealR)
        {
            foreach (var m in mealR)
            {
                m.MakeDinner();
            }
        }
    }
}