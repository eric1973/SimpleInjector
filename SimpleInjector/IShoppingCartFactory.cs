﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjector
{
    public interface IShoppingCartFactory
    {
        IShoppingCart CreateNew(string shoppingCartId);
    }
}
