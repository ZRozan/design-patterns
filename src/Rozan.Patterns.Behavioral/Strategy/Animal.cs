using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozan.Patterns.Behavioral.Strategy.Interfaces;

namespace Rozan.Patterns.Behavioral.Strategy
{
    public class Animal
    {
        // Fields.
        private string _name;
        private int _weight;
        private string _sound;

        public IFlys flyingType { get; set; }

        // Properties.
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Weight), "Should be greater than zero");
            }
        }

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        public string TryToFly()
        {
            return flyingType.fly();
        }
    }
}
