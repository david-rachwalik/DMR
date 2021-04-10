using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Data;
using DMR.WebApp.Models;

namespace DMR.WebApp.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly DMR.WebApp.Data.ApplicationContext _context;

        public IndexModel(DMR.WebApp.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Departments
                .Include(d => d.Administrator).ToListAsync();
        }
    }
}
