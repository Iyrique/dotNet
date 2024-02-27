using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Panther : Animal
    {
        public Panther()
        {
            Speed = 0;
        }

        public override void Move()
        {
            Speed = Math.Min(Speed + 10, 100);
        }

        // Реализация метода стоять
        public override void Stand()
        {
            Speed = Math.Max(Speed - 10, 0);
        }

        public string Roar()
        {
            return "RRRRRRR!!!";
        }

    
        public string ClimbTree()
        {
            return "The panther climbed a tree";
        }
    }
}
