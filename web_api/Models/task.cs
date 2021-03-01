using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Models
{
    public class task
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string OwnerID { get; set; }
        public string Status { get; set; }
    }
}
