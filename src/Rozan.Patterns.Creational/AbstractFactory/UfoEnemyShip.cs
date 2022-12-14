using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public class UfoEnemyShip : EnemyShip
    {
        EnemyShipFactory shipFactory;

        public UfoEnemyShip(EnemyShipFactory shipFactory)
        {
            this.shipFactory = shipFactory;
        }

        public override void MakeShip()
        {
            weapon = shipFactory.addESGun();
            engine = shipFactory.addESEngine();
        }
    }
}
