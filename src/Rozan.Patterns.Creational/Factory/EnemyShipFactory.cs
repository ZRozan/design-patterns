using Rozan.Patterns.Creational.Factory.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Factory
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string newShipType)
        {
            EnemyShip newShip = null;

            if (newShipType == "1")
                return new UfoEnemyShip();
            else if (newShipType == "2")
                return new RocketEnemyShip();
            else if (newShipType == "3")
                return new BigUfoEnemyShip();
            else
                return null;
        }
    }
}
