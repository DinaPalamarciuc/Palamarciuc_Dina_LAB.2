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
    public class IndexModel : PageModel
    {
        private readonly Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context _context;

        public IndexModel(Palamarciuc_Dina_LAB._2.Data.Palamarciuc_Dina_LAB_2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
