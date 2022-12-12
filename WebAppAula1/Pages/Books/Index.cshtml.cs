using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAula1.Data;
using WebAppAula1.Models;

namespace WebAppAula1.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly WebAppAula1.Data.WebAppAula1Context _context;

        public IndexModel(WebAppAula1.Data.WebAppAula1Context context)
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
