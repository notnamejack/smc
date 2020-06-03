using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMC.Date.Models
{
    public class SortActivity
    {
        public int id { get; set; }
        public string title { get; set; }

        public List<Users> users { get; set; }
    }
}
