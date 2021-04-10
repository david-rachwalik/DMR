using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Pages.Character
{
    public class DeleteModel : PageModel
    {
        private readonly ICharacterTemplateService _characterTemplateService;
        private readonly ITagService _tagService;

        public DeleteModel(ICharacterTemplateService characterTemplateService,
            ITagService tagService)
        {
            _characterTemplateService = characterTemplateService;
            _tagService = tagService;
        }

        [BindProperty]
        public Models.Templates.CharacterTemplate CharacterTemplate { get; set; }
        public IEnumerable<Tag> Species { get; set; }
        public Tag FirstSpecies { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            CharacterTemplate = await _characterTemplateService.ReadAsync(id);
            Species = await _tagService.ReadListAsync();
            FirstSpecies = Species.First();

            if (CharacterTemplate == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            int changes = await _characterTemplateService.DeleteAsync(id);
            if (changes == 0) { return NotFound(); }
            return RedirectToPage("./Index");
        }
    }
}
