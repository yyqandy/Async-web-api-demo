using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Repo;
using System.Threading;
using System.Web;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        public productRepo repo = new productRepo();

        [HttpPost]
        public IEnumerable<Product> getProductsp()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);  
            return repo.GetAll();
        }

     
        public IEnumerable<Product> getProducts()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);
            return repo.GetAll();
        }
    }
}
