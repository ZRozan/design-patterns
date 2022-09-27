using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.Behavioral.Observer.Interfaces
{
    public interface IObserver
    {
        public void Update(
            double ibmPrice, double aaplPrice, double googPrice
            );
    }
}
