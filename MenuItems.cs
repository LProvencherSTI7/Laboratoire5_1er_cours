using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratoire5
{
    class MenuItems
    {
        List<Item> Items;

        public MenuItems()
        {
            this.Items = new List<Item>();
        }

        public void AjouterItem(Item i)
        {
            this.Items.Add(i);
        }
    }
}
