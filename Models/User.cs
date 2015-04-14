using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateRendererApp
{
    public class User
    {
        public User()
        {
            PastJobs = new List<string>();
        }

        public string Name { get; set; }

        public List<string> PastJobs { get; set; }
    }
}
