using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Areas.Game.Models.Templates;
using DMR.WebApp.Data;

namespace DMR.WebApp.Areas.Game.Pages.Templates.Character
{
    public class IndexModel : PageModel
    {
        private readonly DMR.WebApp.Data.ApplicationContext _context;

        public IndexModel(DMR.WebApp.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<CharacterTemplate> CharacterTemplate { get;set; }

        public async Task OnGetAsync()
        {
            CharacterTemplate = await _context.CharacterTemplates.ToListAsync();
        }
    }
}
