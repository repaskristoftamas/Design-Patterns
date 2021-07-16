using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TempSensor tempSensor = new TempSensor();
            TempObserver tempObserver = new TempObserver(tempSensor);
            tempSensor.AddObserver(tempObserver);
            tempSensor.Temp = 28.5f;
            tempSensor.Temp = 24.5f;
            tempSensor.Temp = 17.5f;
            tempSensor.RemoveObserver(tempObserver);
            Console.ReadLine();
        }
    }
}
