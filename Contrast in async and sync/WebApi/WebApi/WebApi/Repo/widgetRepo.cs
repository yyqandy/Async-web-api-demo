using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
namespace WebApi.Repo
{
    public class widgetRepo
    {
        public IEnumerable<Widget> GetAll()
        {
            List<Widget> widgets = new List<Widget> { 
            new Widget(1),
            new Widget(2),
            new Widget(3)
            };
            return widgets;
        }
    }
}