using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.Factory.SubClasses
{
    public class UfoEnemyShip : EnemyShip
    {
        public UfoEnemyShip()
        {
            Name = "UFO Enemy Ship";
            AmountDamage = 20.0;
        }
    }
}
