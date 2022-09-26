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
        public void AnimalsTests()
        {
            // Arrange
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal wolf = new Wolf(hierarchy: "Leader");

            List<Animal> animals = new List<Animal> { dog, cat, wolf};

            // Act
            foreach (var item in animals)
            {
                Console.WriteLine($"The {item.GetType().Name} sound is {item.Sound}");

                if (item.GetType() == typeof(Dog)
                    || item.GetType().IsSubclassOf(typeof(Dog)))
                {
                    Console.WriteLine("The animal also: ");

                    //Dog g = (Dog)item;
                    ((Dog)item).DigHole();

                    if(item.GetType() == typeof(Wolf))
                    {
                        ((Wolf)item).Howl();
                    }
                }
            }

            // Assert
            Assert.True(true);
        }
    }
}
