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
    public class GizmosController : ApiController
    {
        public gizmosRepo repo = new gizmosRepo();

        [HttpPost]
        public IEnumerable<Gizmos> getGizmoses()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);
            return repo.GetAll();
        }

        public IEnumerable<Gizmos> getGizmosesp()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);
            return repo.GetAll();
        }
    }
}
