using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObserver
    {
        void Update(float temp);
        void Update(ISubject subject);
    }
}
