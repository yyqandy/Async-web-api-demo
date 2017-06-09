using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
namespace WebApi.Repo
{
    public class productRepo
    {
        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product> { 
            new Product(1),
            new Product(2),
            new Product(3)
            };
            return products;
        }
    }
}