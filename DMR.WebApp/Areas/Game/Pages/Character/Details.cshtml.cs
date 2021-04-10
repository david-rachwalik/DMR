using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    public class DetailsModel : PageModel
    {
        private readonly ICharacterTemplateService _characterTemplateService;
        private readonly ITagService _tagService;

        public DetailsModel(ICharacterTemplateService characterTemplateService,
            ITagService tagService)
        {
            _characterTemplateService = characterTemplateService;
            _tagService = tagService;
        }

        public Models.Templates.CharacterTemplate CharacterTemplate { get; set; }
        public IEnumerable<Tag> Species { get; set; }
        public Tag FirstSpecies { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            CharacterTemplate = await _characterTemplateService.ReadAsync(id);
            Species = await _tagService.ReadListAsync("TagGroup.CharacterSpecies");
            FirstSpecies = Species.First();

            if (CharacterTemplate == null) { return NotFound(); }
            return Page();
        }
    }
}
