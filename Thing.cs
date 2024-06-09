using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterTest
{
    public abstract class Thing
    {
        private string _number;
        private string _name;
        public Thing(string number, string name)
        {
            _number = number;
            _name = name;
        }
        public abstract void Print();
        public abstract decimal Total();
        
        public String Number
        {
            get { return _number; }
        }
        public String Name
        {
            get { return _name; }
        }
    }
}
