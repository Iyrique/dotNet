using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Dog : Animal
    {
        public Dog()
        {
            Speed = 0;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 10, 50);

        }

        public override void Stand()
        {
            Speed = Math.Max(Speed - 10, 0);

        }

        public string Roar()
        {
            return "Gav gav!!!";
        }
    }
}
