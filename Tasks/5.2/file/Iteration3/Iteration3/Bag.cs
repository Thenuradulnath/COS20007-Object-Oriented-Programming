using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration3
{
    public class Bag : Item
    {
        private Inventory _inventory;
        public Bag(string[] ids, string name,string desc):base(ids, name, desc)
        {
            _inventory = new Inventory(); 
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
                { 
                    return this;
                }
            else if (_inventory.HasItem(id)) 
                { 
                    return _inventory.Fetch(id);
                }
            else 
                { 
                    return null; 
                }
        }
        public override String FullDescription
        {
            get
            {
                return $"{this.name}, containing:\n" + _inventory.ItemList;

            }
        }
         
        public Inventory Inventory
        { 
            get { return _inventory; } 
        }
    }
}
