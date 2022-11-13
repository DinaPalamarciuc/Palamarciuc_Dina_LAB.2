using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Palamarciuc_Dina_LAB._2.Data;
using Palamarciuc_Dina_LAB._2.Models;

namespace Palamarciuc_Dina_LAB._2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context _context;

        public CreateModel(Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
