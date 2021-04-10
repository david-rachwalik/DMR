using DMR.WebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMR.WebApp.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly DMR.WebApp.Data.MainContext _context;

        public IndexModel(DMR.WebApp.Data.MainContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}