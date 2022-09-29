using Rozan.Patterns.Creational.AbstractFactory.UfoShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public class UfoEnemyShipFactory : EnemyShipFactory
    {
        public override ESEngine addESEngine()
        {
            return new ESUfoEngine();
        }

        public override ESWeapon addESGun()
        {
            return new ESUfoGun();
        }
    }
}
