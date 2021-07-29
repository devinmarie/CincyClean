using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Pages.Cleaners
{
    public class EditModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public EditModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cleaner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CleanerExists(Cleaner.CleanerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CleanerExists(int id)
        {
            return _context.Cleaner.Any(e => e.CleanerId == id);
        }
    }
}
