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
            for (var i=0; i<10; i++)
            {
                pastJobs.Add("hello");
                pastJobs.Add("world");
            }

            var users = new List<User>();
            for (var i=0; i<50; i++)
            {
                users.Add(new User
                {
                    FirstName = "Simple",
                    LastName = "User",
                    HomePhone = "81275-912854-1",
                    Mobile = "18295710923",
                    MailId = "something@something.com",
                    CurrentJob = "Some Random Job",
                    PastJobs = new SelectList(pastJobs)
                });
            }

            return View(users);
        }

        public IActionResult Edit(User user)
        {
            var result = new ContentResult();
            result.Content = user.FirstName;
            return result;
        }
    }
}