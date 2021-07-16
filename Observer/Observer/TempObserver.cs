using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class TempObserver : IObserver
    {
        private float temp;
        private ISubject tempSensor;

        public TempObserver(ISubject subject) { tempSensor = subject; }

        public void Update(float temp)
        {
            this.temp = temp;
            Console.WriteLine(this.temp);
        }

        public void Update(ISubject subject)
        {
            tempSensor = subject;
        }
    }
}
