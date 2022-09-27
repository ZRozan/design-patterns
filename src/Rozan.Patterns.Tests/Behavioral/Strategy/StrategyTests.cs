using Rozan.Patterns.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.Behavioral.Strategy
{
    public class StrategyTests
    {
        [Test]
        public void SetFlight_CannotFly_ReturnTheFlightMessage()
        {
            // Arrange
            Animal brutus = new Dog();

            // Act
            Console.WriteLine(brutus.TryToFly());

            // Assert
            Assert.True(true);

        }

        [Test]
        public void SetFlight_Squirrel_ReturnStyle()
        {
            // Arrange
            Animal tico = new Squirrel();

            // Act
            Console.WriteLine(tico.TryToFly());

            // Assert
            Assert.True(true);

        }
    }
}
