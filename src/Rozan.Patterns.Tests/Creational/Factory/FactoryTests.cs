using Rozan.Patterns.Creational.Factory;
using Rozan.Patterns.Creational.Factory.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.Creational.Factory
{
    public class FactoryTests
    {
        [Test]
        public void Select_EnemyShip_ReturnUfoEnemyTypeAndEvents()
        {
            // Arrange
            var shipFactory = new EnemyShipFactory();

            // Act
            var ship = shipFactory.MakeEnemyShip("1");

            // Assert
            Assert.That(ship, Is.TypeOf<UfoEnemyShip>());
            ship.DisplayEnemyShip();
            ship.FollowHeroShip();
            ship.EnemyShipShoots();
        }
    }
}
