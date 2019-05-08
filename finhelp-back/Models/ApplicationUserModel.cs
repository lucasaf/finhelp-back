using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finhelp_back.Models
{
    public class ApplicationUserModel
    {
        public string user_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
    }
}
