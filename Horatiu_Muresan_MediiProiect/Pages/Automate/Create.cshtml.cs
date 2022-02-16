using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Horatiu_Muresan_MediiProiect.Models;

namespace Horatiu_Muresan_MediiProiect.Pages.Automate
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
            return Page();
        }

        [BindProperty]
        public Automat Automat { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Automat.Add(Automat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}