using Rozan.Patterns.Behavioral.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Observer
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        private static int _oberverIdTracker = 0;

        private int _observerId;

        private ISubject _stockGrabber;

        public StockObserver(ISubject stockgrabber)
        {
            this._stockGrabber = stockgrabber;

            this._observerId = ++_oberverIdTracker;

            stockgrabber.Register(this);
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this._ibmPrice = ibmPrice;
            this._aaplPrice = aaplPrice;
            this._googPrice = googPrice;

            PrintPrices();
        }

        private void PrintPrices()
        {
            Console.WriteLine($"{_observerId}");
            Console.WriteLine($"IBM: {_ibmPrice}");
            Console.WriteLine($"Apple:{_aaplPrice}");
            Console.WriteLine($"Google:{_googPrice}");
        }
    }
}
