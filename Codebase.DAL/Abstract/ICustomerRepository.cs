﻿using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Abstract
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
    }
}