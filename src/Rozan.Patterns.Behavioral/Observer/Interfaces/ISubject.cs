using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Observer.Interfaces
{
    public interface ISubject
    {
        public void Register(IObserver o);
        public void Unregister(IObserver o);
        public void NotifyObserver();
    }
}
