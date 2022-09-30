using Rozan.Patterns.Creational.Singleton;

namespace Rozan.Patterns.Tests.Creational.Singleton
{
    public class SingletonTests
    {
        [Test]
        public void GetTiles_RequestThreeTiles_ReturnsRandomizedThreeTiles()
        {
            // Arrange
            int countExpected = 3;
            var instance = ScrabbleSingleton.Instance;

            // Act
            var resultA = instance.GetLetterTiles(countExpected);
            Console.WriteLine("First result: " + String.Join(", ", resultA));

            var resultB = instance.GetLetterTiles(countExpected);
            Console.WriteLine("Second result: " + String.Join(", ", resultB));

            // Assert
            Assert.That(resultA.Count, Is.EqualTo(countExpected));
            Assert.That(resultB.Count, Is.EqualTo(countExpected));
            Assert.That(instance.AllLetersInBag.Count - (countExpected * 2), Is.EqualTo(instance.Availableletters.Count));
        }
    }
}
