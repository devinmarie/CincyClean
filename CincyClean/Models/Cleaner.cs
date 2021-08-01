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
    public class Cleaner
    {
        public int CleanerId { get; set; }
        public string CleanerName { get; set; }
        public List<Request> RequestCleaner { get; set; }
    }
}
