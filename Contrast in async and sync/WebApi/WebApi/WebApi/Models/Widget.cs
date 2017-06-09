using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Widget
    {
        //data
        public int ID { get; set; }
        public string WidgetName { get; set; }
        public int Price { get; set; }

        //ctor
        public Widget() { }

        public Widget(int id)
        {
            this.ID = id;
            this.WidgetName = "widget"+id;
            this.Price = id * 10;
        }
    }
}