using Rozan.Patterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.Creational.Singleton
{
    public class SingletonTests
    {
        [Test]
        public void GetTiles_RequestThreeTiles_ReturnsRandomizedThreeTiles()
        {
            int countExpected = 3;
            var instance = ScrabbleSingleton.Instance;

            var result = instance.GetLetterTiles(countExpected);
            Console.WriteLine(String.Join(", ", result));

            Assert.That(result.Count, Is.EqualTo(countExpected));
            Assert.That(instance.AllLetersInBag.Count - countExpected, Is.EqualTo(instance.Availableletters.Count));
        }
    }
}
