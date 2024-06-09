using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public class Transaction : Thing
    {
        private Decimal _amount;
        
        public Transaction(String number, String name, Decimal amount): base(number, name)
        {
            _amount = amount;
        }
        public override void Print()
        {
            Console.WriteLine($"Batch sale: #{Number}, {Name}, ${_amount}");
        }
        public override decimal Total()
        {
            return _amount;
        }
    }
}
