using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mocan_Karola_Lab2.Data;
using Mocan_Karola_Lab2.Models;

namespace Mocan_Karola_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Mocan_Karola_Lab2.Data.Mocan_Karola_Lab2Context _context;

        public IndexModel(Mocan_Karola_Lab2.Data.Mocan_Karola_Lab2Context context)
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
