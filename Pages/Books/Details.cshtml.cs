using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Palamarciuc_Dina_LAB._2.Data;
using Palamarciuc_Dina_LAB._2.Models;

namespace Palamarciuc_Dina_LAB._2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context _context;

        public DetailsModel(Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.iD == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
