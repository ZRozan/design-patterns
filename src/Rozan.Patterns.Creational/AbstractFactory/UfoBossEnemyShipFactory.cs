using Rozan.Patterns.Creational.AbstractFactory.UfoShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public class UfoBossEnemyShipFactory : EnemyShipFactory
    {
        public override ESEngine addESEngine()
        {
            return new ESUfoBossEngine();
        }

        public override ESWeapon addESGun()
        {
            return new ESBossUfoGun();
        }
    }
}
