using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
namespace WebApi.Repo
{
    public class gizmosRepo
    {
        public IEnumerable<Gizmos> GetAll()
        {
            List<Gizmos> gizmoses = new List<Gizmos> { 
            new Gizmos(1),
            new Gizmos(2),
            new Gizmos(3)
            };
            return gizmoses;
        }
    }
}