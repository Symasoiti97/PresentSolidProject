﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Correct.Invariants
{
    class Account
    {
        protected int capital;

        public Account(int sum)
        {
            if (sum < 100)
                throw new Exception("Некорректная сумма");
            this.capital = sum;
        }

        public virtual int Capital
        {
            get
            {
                return capital;
            }
            set
            {
                if (value < 100)
                    throw new Exception("Некорректная сумма");
                capital = value;
            }
        }
    }
}
