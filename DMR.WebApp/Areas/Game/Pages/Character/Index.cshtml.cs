using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Character
{
    public class IndexModel : PageModel
    {
        private readonly ICharacterTemplateService _characterTemplateService;
        private readonly ITagService _tagService;

        public IndexModel(ICharacterTemplateService characterTemplateService,
            ITagService tagService)
        {
            _characterTemplateService = characterTemplateService;
            _tagService = tagService;
        }

        public IEnumerable<Models.Templates.CharacterTemplate> CharacterTemplates { get; private set; }
        public Models.Templates.CharacterTemplate FirstCharacterTemplate { get; private set; }
        public IEnumerable<Tag> Species { get; private set; }
        public Tag CurrentSpecies => Species.Where(c => c.Id == 51).FirstOrDefault();


        public async Task OnGetAsync()
        {
            CharacterTemplates = await _characterTemplateService.ReadListAsync();
            FirstCharacterTemplate = CharacterTemplates.First();
            Species = await _tagService.ReadListAsync("TagGroup.CharacterSpecies");
        }
    }
}
