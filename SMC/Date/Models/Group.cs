using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMC.Date.Models
{
    public class Group
    {
        public int id { get; set; }
        public string names { get; set; }

        public List<Users> users { get; set; }
    }
}
