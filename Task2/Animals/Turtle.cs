using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Turtle : Animal
    {
        public Turtle()
        {
            Speed = 0;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 5, 20);

        }

        public override void Stand()
        {
            Speed = Math.Max(Speed - 5, 0);

        }
    }
}
