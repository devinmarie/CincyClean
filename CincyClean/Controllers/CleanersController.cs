using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CincyClean.Data;
using CincyClean.Models;

namespace CincyClean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanersController : ControllerBase
    {
        private readonly CincyCleanContext _context;

        public CleanersController(CincyCleanContext context)
        {
            _context = context;
        }

        // GET: api/Cleaners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cleaner>>> GetCleaner()
        {
            return await _context.Cleaner.ToListAsync();
        }

        // GET: api/Cleaners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cleaner>> GetCleaner(int id)
        {
            var cleaner = await _context.Cleaner.FindAsync(id);

            if (cleaner == null)
            {
                return NotFound();
            }

            return cleaner;
        }

        // PUT: api/Cleaners/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCleaner(int id, Cleaner cleaner)
        {
            if (id != cleaner.CleanerId)
            {
                return BadRequest();
            }

            _context.Entry(cleaner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CleanerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cleaners
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cleaner>> PostCleaner(Cleaner cleaner)
        {
            _context.Cleaner.Add(cleaner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCleaner", new { id = cleaner.CleanerId }, cleaner);
        }

        // DELETE: api/Cleaners/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cleaner>> DeleteCleaner(int id)
        {
            var cleaner = await _context.Cleaner.FindAsync(id);
            if (cleaner == null)
            {
                return NotFound();
            }

            _context.Cleaner.Remove(cleaner);
            await _context.SaveChangesAsync();

            return cleaner;
        }

        private bool CleanerExists(int id)
        {
            return _context.Cleaner.Any(e => e.CleanerId == id);
        }
    }
}
