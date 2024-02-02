using Microsoft.Win32;
using pj09_3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pj09_3
{
    internal class Player
    {
 //      List<Item> items = new List<Item>();

        private List<Item> items;
        public Player()
        {
            this.items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            this.items.Add(item);
        }
        public void UseItems()
        {
            //Console.WriteLine("{0}を使った", items);
            foreach (Item item in items)
            {
             item.Use();
            }
        }
    }
}
