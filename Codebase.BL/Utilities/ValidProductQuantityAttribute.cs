﻿using Codebase.BL.Abstract;
using Codebase.BL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Utilities
{
    public class ValidProductQuantityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var quantity = Convert.ToInt32(value);
            var orderVM = (OrderVM)validationContext.ObjectInstance;
            if (quantity < orderVM.CustomerProduct.Product.Quantity)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Stokta belirtilen miktarda ürün yok.");
        }
    }
}