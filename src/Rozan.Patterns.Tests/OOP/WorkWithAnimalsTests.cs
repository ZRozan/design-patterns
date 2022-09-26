using Rozan.Patterns.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.OOP
{
    public class WorkWithAnimalsTests
    {
        [Test]
        public void PlayWithCatAndDog()
        {
            // Arrange
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Act
            dog.Name = "fido";
            Console.WriteLine($"Dog's name is: {dog.Name}");

            dog.DigHole();

            // Assert
            Assert.True(true);
        }
    }
}
