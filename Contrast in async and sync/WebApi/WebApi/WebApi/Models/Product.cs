using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Product
    {
        //data
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        //ctor
        public Product() { }
        public Product(int id)
        {
            this.ID = id;
            this.ProductName = "product" + id;
            this.Price = id * 10;
        }
    }
}