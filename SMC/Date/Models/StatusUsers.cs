using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMC.Date.Models
{
    public class StatusUsers
    {
        public int id { get; set; }
        public string status { get; set; }

        public List<Users> users { get; set; }
    }
}
