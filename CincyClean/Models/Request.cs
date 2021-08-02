using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Options;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;


namespace CincyClean.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsCompleted { get; set; }
        public Cleaner Cleaner { get; set; }
        public int? CleanerId { get; set; }
        public decimal TotalPrice { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }

    }
}
