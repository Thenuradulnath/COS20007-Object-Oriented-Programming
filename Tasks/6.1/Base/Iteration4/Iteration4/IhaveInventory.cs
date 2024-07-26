using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration4
{
    public interface IHaveInventory
    {
        public string name 
        { 
            get; 
        }
        public GameObject Locate(string id);
        
    }
}
