using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Pages.Requests
{
    public class CreateModel : PageModel
    {
        private readonly CincyClean.Data.CincyCleanContext _context;

        public CreateModel(CincyClean.Data.CincyCleanContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
          ViewData["CleanerId"] = new SelectList(_context.Cleaner, "CleanerId", "CleanerId");
          ViewData["ServiceId"] = new SelectList(_context.Set<Service>(), "ServiceId", "ServiceId");
            return Page();
        }

        [BindProperty]
        public Request Request { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Request.Add(Request);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
