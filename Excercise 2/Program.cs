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

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart(); // creating a new Cart object, a list containing Item class objects is created as well

            // Creating Item objects and adding them to the cart list
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
