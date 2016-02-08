using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice { CustomerName = "Piitu" };
            InvoiceItem milk = new InvoiceItem { Name = "Milk", Price = 0.8, Quantity = 2 };
            invoice1.AddItem(milk);

            InvoiceItem beer = new InvoiceItem { Name = "Beer", Price = 0.9, Quantity = 24 };
            invoice1.AddItem(beer);

            InvoiceItem cheese = new InvoiceItem { Name = "Cheese", Price = 4.5, Quantity = 1 };
            invoice1.AddItem(cheese);


            Console.WriteLine(invoice1.ToString());
        }
    }
}
