using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CincyClean.Models
{
    public class Service
    {
            public int ServiceId { get; set; }
            public string ServiceName { get; set; }
            public decimal PricePerService { get; set; }
            public List<Request> Requests { get; set; }

        }

}
