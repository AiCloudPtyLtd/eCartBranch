﻿using eCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCart.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            var myProduct = new Product();
            myProduct.ProductName = ProductName;
            myProduct.Description = ProductDesc;
            myProduct.UnitPrice = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.CategoryID = Convert.ToInt32(ProductCategory);
            using (ProductContext _db = new ProductContext())
            {
                _db.Products.Add(myProduct);
                _db.SaveChanges();
            }
            return true;
        }
    }
}