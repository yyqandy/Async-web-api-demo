using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Product
    {
        //data
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}