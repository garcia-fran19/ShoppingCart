﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
