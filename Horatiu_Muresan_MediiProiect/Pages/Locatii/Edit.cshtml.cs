using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Pages.Locatii
{
    public class EditModel : PageModel
    {
        private readonly Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext _context;

        public EditModel(Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Locatie Locatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Locatie = await _context.Locatie.FirstOrDefaultAsync(m => m.ID == id);

            if (Locatie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Locatie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocatieExists(Locatie.ID))
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

        private bool LocatieExists(int id)
        {
            return _context.Locatie.Any(e => e.ID == id);
        }
    }
}
