using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blinker
{
    public static class Program
    {

        public static void Main()
        {
            // Create a Timer object that knows to call our TimerCallback
            // method once every 5 seconds.
            Timer t = new Timer(TimeBlinker, null, 0, 1000);
            // Wait for the user to hit <Enter>
            Console.ReadLine();
        }

        private static void TimeBlinker(Object o)
        {
            // Display the date/time when this method got called.
            string ticker = (Convert.ToInt32((DateTime.Now.Second)) % 2 == 0) ? "Tick" : "Tock";
            Console.WriteLine(ticker + " : " + DateTime.Now);
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}
