﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; set; }
        Product this[string name] { get; }
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}