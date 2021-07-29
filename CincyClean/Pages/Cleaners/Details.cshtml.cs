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
    public class DetailsModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public DetailsModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        public Cleaner Cleaner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cleaner = await _context.Cleaner.FirstOrDefaultAsync(m => m.CleanerId == id);

            if (Cleaner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
