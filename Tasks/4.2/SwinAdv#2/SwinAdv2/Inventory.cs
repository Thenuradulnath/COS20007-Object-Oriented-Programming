using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration2
{
    public class Inventory
    {
        private List<Item> _items;
        public Inventory()
        {
            _items = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach (var item in _items)
            {
                if (item.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }
        public void Put(Item i)
        {
            _items.Add(i);
        }
        public Item Take(string id)
        {
            foreach (var item in _items)
            {
                if (item.AreYou(id))
                {
                    _items.Remove(item);
                    return item;
                }

            }
            return null;
        }
        public Item Fetch(string id)
        {
            foreach (var item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;

                }
            }
            return null;
        }
        public string ItemList
        {
            get
            {
                string listItem = "";
                foreach (Item i in _items)
                {
                    listItem = listItem + i.ShortDescription +"\n";
                }
                return listItem;
            }
        }
    }
}


