﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IOrder _order;

        public IShoppingCart ChildShoppingCart { get; set; }

        public ShoppingCart(IOrder order)
        {
            _order = order;
        }

        public void CheckOut()
        {
            Console.WriteLine(this.GetType().Name + " gets checked out ...");
            _order.Process();
        }
    }
}
