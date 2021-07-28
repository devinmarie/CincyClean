﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Options;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;


namespace CincyClean.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServicePricePerHour { get; set; }
        public decimal HoursPerRoom { get; set; }
        public List<Request> RequestService { get; set; }
    }
}
