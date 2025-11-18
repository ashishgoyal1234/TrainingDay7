using ConsoleAppCollectionsAndGenerics.Domain;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ConsoleAppCollectionsAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderBasket = new List<OrderItem>();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice=100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", Quantity = 5, UnitPrice=50 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 60 });

            double checkoutPrice = 0;
            foreach (OrderItem temp in orderBasket)
            {
                //OrderItem temp = box as OrderItem;
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + " Name " + temp.Name + " Quantity " + temp.Quantity);
            }
            Console.WriteLine(" Total Cost " + checkoutPrice);

        }
    }
}
