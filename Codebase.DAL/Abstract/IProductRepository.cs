﻿using Codebase.Core.DataAccess;
using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
