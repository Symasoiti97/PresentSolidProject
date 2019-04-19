using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Correct.Invariants
{
    class MicroAccount : Account
    {
        public MicroAccount(int sum) : base(sum)
        {
        }

        public override int Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }
        }
    }
}
