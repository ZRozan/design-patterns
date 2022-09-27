using Rozan.Patterns.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Strategy
{
    public class Squirrel : Animal
    {
        public Squirrel() : base()
        {
            Sound = "Squee!";
            flyingType = new Hovers();
        }
    }
}
