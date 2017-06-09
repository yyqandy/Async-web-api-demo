using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using WebMVC.Models;
namespace WebMVC
{
    public class pwgService
    {
        public static async Task<pwgVM> RunTaskGetAll()
        {
            var task1 = TaskGetItem<Product>();
            var task2 = TaskGetItem<Gizmos>();
            var task3 = TaskGetItem<Widget>();
            await Task.WhenAll(task1,task2,task3);
            pwgVM vm = new pwgVM(task1.Result,task2.Result,task3.Result);
            return vm;
        }

        #region
        public static async Task<List<Product>> TaskGetProduct()
        {
            using(HttpClient client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52593/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json =await client.GetStringAsync("api/Product/Products");
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }
        public static async Task<List<Widget>> TaskGetWidget()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52593/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = await client.GetStringAsync("api/Widget/Widgets");
                return JsonConvert.DeserializeObject<List<Widget>>(json);
            }
        }
        public static async Task<List<Gizmos>> TaskGetGizmos()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52593/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = await client.GetStringAsync("api/Gizmos/Gizmoss");
                return JsonConvert.DeserializeObject<List<Gizmos>>(json);
            }
        }
        #endregion

        //泛型版本
        public static async Task<List<T>> TaskGetItem<T>() where T:class
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52593/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string typename = typeof(T).Name;
                string json = await client.GetStringAsync("api/"+typename+"/"+typename+"s");
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }
    }
}