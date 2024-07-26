using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration5
{
    public interface IhaveInventory
    {
        public string name
        {
            get;
        }
        public GameObject Locate(string id);

    }
}
