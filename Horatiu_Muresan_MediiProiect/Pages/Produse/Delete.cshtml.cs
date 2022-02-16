using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Pages.Produse
{
    public class DeleteModel : PageModel
    {
        private readonly Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext _context;

        public DeleteModel(Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produs = await _context.Produs.FindAsync(id);

            if (Produs != null)
            {
                _context.Produs.Remove(Produs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
