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
        public string ServiceDesc { get; set; }
        public int ServicePrice { get; set; }
        public int ServiceHours { get; set; }
    }
}
