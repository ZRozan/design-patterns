using Rozan.Patterns.Creational.AbstractFactory;
using Rozan.Patterns.Creational.AbstractFactory.UfoShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.Creational.AbstractFactory
{
    public class AbstractFactoryTests
    {
        [Test]
        public void BuildUfoShip_ReturnTheRightWeaponAndEngine()
        {
            // Arrange
            EnemyShipBuilding newUfoShip = new UfoEnemyShipBuilding();

            // Act
            EnemyShip ship = newUfoShip.OrderTheShip("UFO");

            // Assert
            Assert.That(ship, Is.TypeOf<UfoEnemyShip>());
            Assert.That(ship.engine, Is.TypeOf<ESUfoEngine>());
            Assert.That(ship.weapon, Is.TypeOf<ESUfoGun>());
        }

        [Test]
        public void BuildBossUfoShip_ReturnTheRightWeaponAndEngine()
        {
            // Arrange
            EnemyShipBuilding newUfoShip = new UfoEnemyShipBuilding();

            // Act
            EnemyShip ship = newUfoShip.OrderTheShip("UFO BOSS");

            // Assert
            Assert.That(ship, Is.TypeOf<UfoBossEnemyShip>());
            Assert.That(ship.engine, Is.TypeOf<ESUfoBossEngine>());
            Assert.That(ship.weapon, Is.TypeOf<ESBossUfoGun>());
        }
    }
}
