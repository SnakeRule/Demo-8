using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            Item milk = new Item { Name = "Milk", Price = "0,9 e" };
            cart.AddtoCart(milk);

            Item beer = new Item { Name = "Beer", Price = "1 e" };
            cart.AddtoCart(beer);

            Item salmon = new Item { Name = "Salmon", Price = "10 e" };
            cart.AddtoCart(salmon);

            cart.PrintCart();
        }
    }
}
