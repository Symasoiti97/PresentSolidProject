using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Correct.Postconditions
{
    class MicroAccount : Account
    {
        public override decimal GetInterest(decimal sum, int month, int rate)
        {
            if (sum < 0 || month > 12 || month < 1 || rate < 0)
            {
                throw new Exception("Некорректные данные");
            }

            decimal result = sum;

            for (int i = 0; i < month; i++)
            {
                result += result * rate / 100;
            }

            return result;
        }
    }
}
