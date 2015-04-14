using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;

namespace TemplateRendererApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var pastJobs = new List<string>();
            for (var i=0; i<20000; i++)
            {
                pastJobs.Add("hello");
                pastJobs.Add("world");
            }

            ViewBag.PastJobs = new SelectList(pastJobs);

            return View();
        }
    }
}