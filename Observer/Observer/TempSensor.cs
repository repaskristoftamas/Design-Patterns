using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class TempSensor : ISubject
    {
        private List<IObserver> observers;
        private float temp;
        public float Temp
        {
            set
            {
                temp = value;
                TempChanged();
            }
        }

        public TempSensor() { observers = new List<IObserver>(); }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = observers.IndexOf(observer);
            if (i >= 0)
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                //IObserver observer = observers.ElementAt(i);
                //PUSH
                observers[i].Update(temp);
                //PULL
                observers[i].Update(this);
            }
        }

        private void TempChanged()
        {
            NotifyObservers();
        }
    }
}
