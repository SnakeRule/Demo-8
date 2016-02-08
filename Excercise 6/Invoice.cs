/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 8.2.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_6
{
    public class Invoice
    {
        public List<InvoiceItem> invoice;
        public string CustomerName { get; set; }

        /// <summary>
        /// A new list is created as a new Invoice object is created
        /// </summary>
        public Invoice()
        {
            invoice = new List<InvoiceItem>();
        }


        /// <summary>
        /// For adding an item to the invoice list
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(InvoiceItem item)
        {
            invoice.Add(item);
        }


        /// <summary>
        /// In this Total method the costs of all items in the list are added together for a total price
        /// </summary>
        /// <returns></returns>
        public string Total()
        {
            double total = 0;
            foreach (InvoiceItem invoice in invoice)
            {
                total = total + invoice.Total();
            }
            return ("Sum of all items = " + total);
        }


        /// <summary>
        /// In this showitems method the items in the list are returned as a string
        /// </summary>
        /// <returns></returns>
        private string showitems()
        {
            string items = "";
            foreach(InvoiceItem invoice in invoice)
            {
                items = items + invoice.Name + " " + invoice.Price + "e " + invoice.Quantity + " Pieces " + invoice.Total() + " Total\n";
            }
            return items;
        }


        /// <summary>
        /// For printing out the invoice
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Customer " + CustomerName + "\n=============================\n" + showitems() + "=============================\n" + Total(); 
        }
    }
}
