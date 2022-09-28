using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Factory.SubClasses
{
    public class BigUfoEnemyShip : UfoEnemyShip
    {
        public BigUfoEnemyShip()
        {
            Name = "Big UFO Enemy Ship";
            AmountDamage = 40.0;
        }
    }
}
