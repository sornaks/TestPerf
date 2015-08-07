using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;

namespace TemplateRendererApp
{
    public class User
    {
        public User()
        {
            PastJobs = new List<SelectListItem>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomePhone { get; set; }

        public string Mobile { get; set; }

        public string MailId { get; set; }

        public string CurrentJob { get; set; }

        public IEnumerable<SelectListItem> PastJobs { get; set; }
    }
}
