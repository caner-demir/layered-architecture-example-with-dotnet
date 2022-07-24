﻿using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Abstract
{
    public interface IProductService
    {
        Product Get(int id);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void DecreaseProductQuantity(Product product, int quantity);
        void Delete(int id);
    }
}