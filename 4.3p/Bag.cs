using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Bag : Item
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory(); ////
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else if(_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            return null;
        }
        public string FullDesciption
        {
            get
            {
                string s = this.Name + ", containing:\n" + _inventory.ItemList;
                return s;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

    }
}
