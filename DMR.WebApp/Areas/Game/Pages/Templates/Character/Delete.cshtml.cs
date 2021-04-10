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
    public class DeleteModel : PageModel
    {
        private readonly DMR.WebApp.Data.ApplicationContext _context;

        public DeleteModel(DMR.WebApp.Data.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CharacterTemplate CharacterTemplate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterTemplate = await _context.CharacterTemplates.FirstOrDefaultAsync(m => m.Id == id);

            if (CharacterTemplate == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterTemplate = await _context.CharacterTemplates.FindAsync(id);

            if (CharacterTemplate != null)
            {
                _context.CharacterTemplates.Remove(CharacterTemplate);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
