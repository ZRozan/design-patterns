using Rozan.Patterns.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Strategy.FlyingTypes
{
    public class Hovers : IFlys
    {
        public string fly()
        {
            return "I fall with style";
        }
    }
}
