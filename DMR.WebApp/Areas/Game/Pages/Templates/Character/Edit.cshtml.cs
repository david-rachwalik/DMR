using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Areas.Game.Models.Templates;
using DMR.WebApp.Data;

namespace DMR.WebApp.Areas.Game.Pages.Templates.Character
{
    public class EditModel : PageModel
    {
        private readonly DMR.WebApp.Data.ApplicationContext _context;

        public EditModel(DMR.WebApp.Data.ApplicationContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CharacterTemplate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterTemplateExists(CharacterTemplate.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CharacterTemplateExists(int id)
        {
            return _context.CharacterTemplates.Any(e => e.Id == id);
        }
    }
}
