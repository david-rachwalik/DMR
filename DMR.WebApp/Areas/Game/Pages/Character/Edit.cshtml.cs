using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Areas.Game.Models;

namespace DMR.WebApp.Areas.Game.Pages.Character
{
    public class EditModel : PageModel
    {
        private readonly ICharacterTemplateService _characterTemplateService;
        private readonly ITagService _tagService;

        public EditModel(ICharacterTemplateService characterTemplateService,
            ITagService tagService)
        {
            _characterTemplateService = characterTemplateService;
            _tagService = tagService;
        }

        [BindProperty]
        public Models.Templates.CharacterTemplate CharacterTemplate { get; set; }
        public IEnumerable<Tag> Species { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            CharacterTemplate = await _characterTemplateService.ReadAsync(id);
            Species = await _tagService.ReadListAsync("TagGroup.CharacterSpecies");

            if (CharacterTemplate == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            int changes = await _characterTemplateService.UpdateAsync(CharacterTemplate);
            if (changes == 0) { return NotFound(); }
            return RedirectToPage("./Index");
        }
    }
}
