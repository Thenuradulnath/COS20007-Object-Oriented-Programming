using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class Batch : Thing
    {
        //private string _number;
        private List<Thing> _items;

        public Batch(string number, string name) : base(number, name)
        {
            _items = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            _items.Add(thing);
        }
        public override void Print()
        {
            Console.WriteLine($"Batch sale: #{Number}, {Name}");
            if (_items.Count == 0)
            {
                Console.WriteLine("This order is empty.");
            }
            else
            {
                for(int i =  0; i < _items.Count; i++)
                {
                    _items[i].Print();
                }
            }
        }
        public override decimal Total()
        {
            decimal total = 0;
            for(int i = 0 ; i < _items.Count ; i++) 
            {
                _items[i].Print();
                total = total + _items[i].Total();
            }
            return total;
        }
    }
}
