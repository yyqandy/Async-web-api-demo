using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebMVC.Models;
using System.Threading;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
       //async
        public async Task<ActionResult> PWGAsync()
        {
            pwgVM vm = await pwgService.RunTaskGetAll();
            return View(vm);
        }      

        public async Task<JsonResult> TesAsync1()
        {
            pwgVM vm = await pwgService.RunTaskGetAll();
            var result = new JsonResult();
            result.Data = vm;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }
        public async Task<JsonResult> TesAsync2()
        {
            pwgVM vm = await pwgService.RunTaskGetAll();
            var result = new JsonResult();
            result.Data = vm;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }
        public async Task<JsonResult> TesAsync3()
        {
            pwgVM vm = await pwgService.RunTaskGetAll();
            var result = new JsonResult();
            result.Data = vm;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }


        public JsonResult Testaction1()
        {
            string result = "asdf";
            Thread.Sleep(5000);
            return new JsonResult() { Data = result, JsonRequestBehavior=JsonRequestBehavior.AllowGet };
        }
        public JsonResult Testaction2()
        {
            string result = "asdf";
            Thread.Sleep(5000);
            return new JsonResult() { Data = result, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult Testaction3()
        {
            string result = "asdf";
            Thread.Sleep(5000);
            return new JsonResult() { Data = result, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}
