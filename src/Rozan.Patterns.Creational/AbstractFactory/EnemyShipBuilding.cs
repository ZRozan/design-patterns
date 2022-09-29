using Rozan.Patterns.Creational.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(string typeOfShip);
       
        public EnemyShip OrderTheShip(string typeOfShip)
        {
            EnemyShip theEnemy = MakeEnemyShip(typeOfShip);

            theEnemy.MakeShip();
            Console.WriteLine(theEnemy.ToString());

            return theEnemy;
        }
    }
}
