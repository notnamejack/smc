using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMC.Date.Models
{
    public class Users
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fio { get; set; }
        public string phone { get; set; }
        public int statusUserId { get; set; }
        public StatusUsers statusUsers { get; set; }
        public int groupId { get; set; }
        public Group group { get; set; }
        public int SortActivityId { get; set; }
        public SortActivity sortActivity { get; set; }
    }
}
