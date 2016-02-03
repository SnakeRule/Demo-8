using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Cart
    {
        public List<Item> items;

        public Cart()
        {
            items = new List<Item>();
        }

        public void AddtoCart(Item item)
        {
            items.Add(item);
        }

        public void PrintCart()
        {
            foreach(Item item in items)
            {
                Console.WriteLine("Item name {0}, price : {1}", item.Name, item.Price);
            }
        }
    }
}
