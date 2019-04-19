using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Persons
{
    class Gnom : IPerson
    {
        protected string _name;
        public int health { get; set; } = 100;
        protected virtual int damage { get; set; } = 30;
        protected virtual string weapon { get; set; } = "Baton";

        public Gnom(string name)
        {
            if (name.Length < 3)
            {
                throw new Exception("Имя слишком короткое");
            }

            _name = name;
        }

        public virtual string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Имя слишком короткое");
                }

                _name = value;
            }
        }

        public void Attack()
        {
            Console.WriteLine($"{_name} нанес урона {damage}");
        }

        public void Treat()
        {
            Console.WriteLine($"{_name} вылечил себя!");
        }
    }
}
