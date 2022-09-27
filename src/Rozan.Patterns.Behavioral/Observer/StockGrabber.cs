using Rozan.Patterns.Behavioral.Observer.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Observer
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> observers;
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }

        public void Register(IObserver newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(IObserver deleteObserver)
        {
            observers.Remove(deleteObserver);
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(_ibmPrice, _aaplPrice, _googPrice);
            }
        }
        public void SetIbmPrice(double newIbmPrice)
        {
            this._ibmPrice = newIbmPrice;
            NotifyObserver();
        }
        public void SetAaplPrice(double newAaplPrice)
        {
            this._aaplPrice = newAaplPrice;
            NotifyObserver();
        }
        public void SetGoogPrice(double newGoogPrice)
        {
            this._googPrice = newGoogPrice;
            NotifyObserver();
        }

    }
}
