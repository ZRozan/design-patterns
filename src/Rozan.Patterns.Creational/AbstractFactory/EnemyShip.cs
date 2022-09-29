using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public abstract class EnemyShip
    {
        private string _name;

        public ESWeapon weapon;
        public ESEngine engine;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void MakeShip();

        public override string ToString()
        {
            string info = $"{Name}: has a top speed of {engine} and an attack power of {weapon}";
            return info;
        }
    }
}
