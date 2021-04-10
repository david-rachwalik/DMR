using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Data;
using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Character
{
    public class CreateModel : PageModel
    {
        private readonly ICharacterTemplateService _characterTemplateService;

        public CreateModel(ICharacterTemplateService characterTemplateService)
        {
            _characterTemplateService = characterTemplateService;
        }

        [BindProperty]
        public Models.Templates.CharacterTemplate CharacterTemplate { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (await TryUpdateModelAsync(CharacterTemplate,
                "character",
                c => c.Title,
                c => c.Description,
                c => c.Species))
            {
                int changes = await _characterTemplateService.CreateAsync(CharacterTemplate);
                return RedirectToPage("./Index");
            }
            return null;
        }
    }
}
