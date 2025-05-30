using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColdConnectApp.Data;
using ColdConnectApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColdConnectApp.Pages
{
    public class AbrigosModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AbrigosModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Abrigo> Abrigos { get;set; }

        public async Task OnGetAsync()
        {
            Abrigos = await _context.Abrigos.Include(a => a.Doacoes).ToListAsync();
        }
    }
}
