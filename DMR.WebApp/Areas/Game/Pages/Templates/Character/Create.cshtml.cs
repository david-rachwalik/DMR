using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DMR.WebApp.Areas.Game.Models.Templates;
using DMR.WebApp.Data;

namespace DMR.WebApp.Areas.Game.Pages.Templates.Character
{
    public class CreateModel : PageModel
    {
        private readonly DMR.WebApp.Data.ApplicationContext _context;

        public CreateModel(DMR.WebApp.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CharacterTemplate CharacterTemplate { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CharacterTemplates.Add(CharacterTemplate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
