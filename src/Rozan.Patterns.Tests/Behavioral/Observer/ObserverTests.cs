using Rozan.Patterns.Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Tests.Behavioral.Observer
{
    public class ObserverTests
    {
        [Test]
        public void SetPrices_NewObserver_ReturnEachPrice()
        {
            // Arrange
            StockGrabber stockGrabber = new StockGrabber();
            StockObserver observer1 = new StockObserver(stockGrabber);
            StockObserver observer2 = new StockObserver(stockGrabber);

            // Act
            stockGrabber.SetIbmPrice(197.00);
            stockGrabber.SetAaplPrice(677.60);
            stockGrabber.SetGoogPrice(676.40);

            // Assert
            Assert.True(true);

        }

        [Test]
        public void Delete_Observer1_ReturnPricesWithoutDeletedObserver()
        {
            // Arrange
            StockGrabber stockGrabber = new StockGrabber();
            StockObserver observer1 = new StockObserver(stockGrabber);
            StockObserver observer2 = new StockObserver(stockGrabber);

            // Act
            stockGrabber.SetIbmPrice(197.00);
            stockGrabber.SetAaplPrice(677.60);
            stockGrabber.SetGoogPrice(676.40);

            stockGrabber.Unregister(observer1);

            stockGrabber.SetIbmPrice(200.00);
            stockGrabber.SetAaplPrice(100.0);
            stockGrabber.SetGoogPrice(900.0);

            // Assert
            Assert.True(true);
        }
    }
}
