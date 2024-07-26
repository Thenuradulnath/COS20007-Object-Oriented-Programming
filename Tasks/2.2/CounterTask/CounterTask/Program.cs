using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CounterTask
{
    public class Program
    {
             static void PrintCounts(Counter[] counters)
            {
                foreach (Counter c in counters)
                {
                    Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
                }
            }
             static void Main(string[] args)
            {
                Counter[] myCounter = new Counter[3];
                myCounter[0] = new Counter("Counter 1");
                myCounter[1] = new Counter("Counter 2");
                myCounter[2] = myCounter[0];
                for (int i = 0; i <= 9; i++)
                {
                    myCounter[0].Increment();
                }
                for (int i = 0; i <= 14; i++)
                {
                    myCounter[1].Increment();
                }
                PrintCounts(myCounter);
                myCounter[2].Reset();
                PrintCounts(myCounter);
            }
        }
    }
