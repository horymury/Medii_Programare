using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Pages.Produse
{
    public class CreateModel : PageModel
    {
        private readonly Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext _context;

        public CreateModel(Horatiu_Muresan_MediiProiect.Models.Horatiu_Muresan_MediiProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AutomatID"] = new SelectList(_context.Automat, "ID", "automatIdent");
        ViewData["LocatieID"] = new SelectList(_context.Locatie, "ID", "locatieDenumire");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}