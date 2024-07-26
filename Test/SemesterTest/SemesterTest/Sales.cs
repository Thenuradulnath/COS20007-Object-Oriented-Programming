using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
   
    public class Sales
    {
        private List<Thing> _orders;
        //private List<Transaction> _single_orders;

        public Sales()
        {
            _orders = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            _orders.Add(thing);
        }

        public void PrintOrders()
        {
            decimal TotSales = 0;
            for (int i = 0; i < _orders.Count; i++)
            {
                _orders[i].Print();
                TotSales = TotSales + _orders[i].Total();
            }
            Console.WriteLine($"Total Sales is: ${TotSales}");
        }
    }

}
