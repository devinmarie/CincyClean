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
        [Key]
        public int RequestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime PreferredDate { get; set; }
        public int Price { get; set; }
        public bool ConfirmPrice { get; set; }
        public List<Cleaner> Cleaners { get; set; }
        public List<Service> Services { get; set; }
    }
}
