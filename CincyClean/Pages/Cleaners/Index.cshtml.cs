using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Pages.Cleaners
{
    public class IndexModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public IndexModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        public IList<Cleaner> Cleaner { get;set; }

        public async Task OnGetAsync()
        {
            Cleaner = await _context.Cleaner.ToListAsync();
        }
    }
}
