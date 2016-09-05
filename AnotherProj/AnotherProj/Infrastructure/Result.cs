using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherProj.Infrastructure
{
    public class Result : IView
    {
        public string Controller { get; set; }
        public string Action { get; set; }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            writer.WriteLine(Controller);
            writer.WriteLine(Action);
            writer.Close();            
        }
    }
}