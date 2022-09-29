using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Creational.AbstractFactory
{
    public class UfoEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(string typeOfShip)
        {
            EnemyShip theEnemy = null;

            if (typeOfShip.Equals("UFO"))
            {
                EnemyShipFactory shipPartsFactory = new UfoEnemyShipFactory();
                theEnemy = new UfoEnemyShip(shipPartsFactory);
                theEnemy.Name = "UFO Grunt Ship";
            }
            else if (typeOfShip.Equals("UFO BOSS"))
            {

                EnemyShipFactory shipPartsFactory = new UfoBossEnemyShipFactory();

                theEnemy = new UfoBossEnemyShip(shipPartsFactory);

                theEnemy.Name = "UFO Boss Ship";
            }

            return theEnemy;
        }
    }
}
