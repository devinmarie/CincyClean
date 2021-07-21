using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public IndexModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Service = await _context.Service.ToListAsync();
        }
    }
}
