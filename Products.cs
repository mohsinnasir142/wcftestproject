﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Communicator
{

    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
    public class Products
    {

        public List<Product> ProductList
        {
            get
            {
                return products;
            }
        }

        private List<Product> products = new List<Product>()
        {
         new Product() { ProductId = 1, Name = "Product 1", CategoryName = "Category 1", Price=10},
         new Product() { ProductId = 1, Name = "Product 2", CategoryName = "Category 2", Price=5},
         new Product() { ProductId = 1, Name = "Product 3", CategoryName = "Category 3", Price=15},
         new Product() { ProductId = 1, Name = "Product 4", CategoryName = "Category 1", Price=9}
         };
    }

   
}