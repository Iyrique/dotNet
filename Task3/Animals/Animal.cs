using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Animal
    {
        public int Speed { get; set; }

        public abstract void Move();
        public abstract void Stand();
    }
}
