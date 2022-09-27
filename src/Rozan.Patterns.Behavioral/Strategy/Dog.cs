using Rozan.Patterns.Behavioral.Strategy.FlyingTypes;
using Rozan.Patterns.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Strategy
{
    public class Dog : Animal
    {
        // Constructors.
        public Dog() : base()
        {
            Sound = "Bark";
            flyingType = new CannotFly();
        }

        // Methods.
        public void DigHole()
        {
            Console.WriteLine("Dug a hole.");
        }

        // Private Methods.

    }
}
