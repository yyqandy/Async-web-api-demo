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
    public class WidgetController : ApiController
    {
        public widgetRepo repo = new widgetRepo();

        [HttpPost]
        public IEnumerable<Widget> getWidgetsp()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);
            return repo.GetAll();
        }

        public IEnumerable<Widget> getWidgets()
        {
            HttpContext.Current.Session["AccountName"] = "sdfasdf";
            Thread.Sleep(5000);
            return repo.GetAll();
        }
    }
}
