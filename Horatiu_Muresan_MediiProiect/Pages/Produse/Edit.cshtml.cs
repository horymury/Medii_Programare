using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Pages.Produse
{
    public class EditModel : PageModel
    {
        private readonly Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext _context;

        public EditModel(Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produs Produs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produs = await _context.Produs
                .Include(p => p.Automat)
                .Include(p => p.Locatie).FirstOrDefaultAsync(m => m.ID == id);

            if (Produs == null)
            {
                return NotFound();
            }
           ViewData["AutomatID"] = new SelectList(_context.Automat, "ID", "automatIdent");
           ViewData["LocatieID"] = new SelectList(_context.Locatie, "ID", "locatieDenumire");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdusExists(Produs.ID))
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

        private bool ProdusExists(int id)
        {
            return _context.Produs.Any(e => e.ID == id);
        }
    }
}
