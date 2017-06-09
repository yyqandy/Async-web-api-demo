using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;
namespace WebMVC.Models
{
    public class pwgVM
    {
        public List<Product> prodList;
        public List<Widget> widgList;
        public List<Gizmos> gizmList;
        public pwgVM(List<Product> pro,List<Gizmos> giz,List<Widget> wig)
        {
            prodList = pro;
            widgList = wig;
            gizmList = giz;
        }
    }
}