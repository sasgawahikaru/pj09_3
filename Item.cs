using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pj09_3
{
    internal class Item
    {
        private string name;
        public Item(string name)
        {
            this.name = name;
        }

        public void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }
    }
}
