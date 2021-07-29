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
        public bool VacuumFlag { get; set; }
        public bool DustFlag { get; set; }
        public bool MopFlag { get; set; }
        public bool KitchenFlag { get; set; }
        public bool BathroomFlag { get; set; }
        public int Price { get; set; }
        public bool ConfirmPrice { get; set; }
        public Cleaner Cleaner { get; set; }
        public int CleanerId { get; set; }
        public bool CompleteFlag { get; set; }
    }
}
