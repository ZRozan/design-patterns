using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public abstract class EnemyShipFactory
    {
        public abstract ESWeapon addESGun();
        public abstract ESEngine addESEngine();
    }
}
