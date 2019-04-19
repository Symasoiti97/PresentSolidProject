using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Persons
{
    class LittleElf : Elf
    {
        protected override string weapon { get; set; } = "LittleBow";
        protected override int damage { get; set; } = 20;

        public LittleElf(string name) : base(name)
        {
            
        }

        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
