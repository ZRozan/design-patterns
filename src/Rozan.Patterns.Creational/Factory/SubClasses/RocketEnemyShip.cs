using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Factory.SubClasses
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            Name = "Rocket Enemy Ship";
            AmountDamage = 10.0;
        }
    }

}
