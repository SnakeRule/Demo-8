using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    public class InvoiceItem
    {
        /// <summary>
        /// The invoice item data is stored here
        /// </summary>
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        
        /// <summary>
        /// Method for counting how much multiple items cost
        /// </summary>
        /// <returns></returns>
        public double Total()
        {
            return Price * Quantity;
        }
    }
}
