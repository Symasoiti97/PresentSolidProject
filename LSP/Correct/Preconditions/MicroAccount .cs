using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Correct.Preconditions
{
    class MicroAccount : Account
    {
        public override void SetCapital(int money)
        {
            if (money < 0)
            {
                throw new Exception("Нельзя положить на счет меньше 0");
            }

            if (money > 100)
            {
                throw new Exception("Нельзя положить на счет больше 100");
            }

            Capital = money;
        }
    }
}
