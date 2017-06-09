using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Gizmos
    {
        //data
        public int ID { get; set; }
        public string GizmosName { get; set; }
        public int Price { get; set; }

        //ctor
        public Gizmos() { }
        public Gizmos(int id)
        {
            this.ID = id;
            this.GizmosName = "Gizmos" + id;
            this.Price = id * 10;
        }
    }
}