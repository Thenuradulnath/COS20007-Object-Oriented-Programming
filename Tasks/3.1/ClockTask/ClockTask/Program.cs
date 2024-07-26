using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClockTask;


namespace CounterTask
{
    class Program
    {
        static void Main()
        {
            Clock clock = new Clock();


            for (int i = 0; i < 3853; i++)
            {
                clock.Tick();

            }

            Console.WriteLine(clock.Time());
        }
    }
}