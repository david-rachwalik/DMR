using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Areas.Game.Models;

namespace DMR.WebApp.Areas.Game.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private readonly IUserProfileService _userProfileService;
        private readonly ITagService _tagService;

        public IndexModel(
            IUserProfileService userProfileService,
            ITagService tagService)
        {
            _userProfileService = userProfileService;
            _tagService = tagService;
        }

        public UserProfile UserProfile { get; set; }
        public IEnumerable<Tag> Species { get; set; }
        public IEnumerable<Tag> Conditions { get; set; }
        public IEnumerable<Tag> Fetishes { get; set; }

        public async Task OnGetAsync()
        {
            int testId = 1;
            UserProfile = await _userProfileService.ReadAsync(testId);
            Species = await _tagService.ReadListAsync("TagGroup.CharacterSpecies");
            Conditions = await _tagService.ReadListAsync("TagGroup.EffectLimiter");
            Fetishes = await _tagService.ReadListAsync("TagGroup.Fetish");
        }
    }
}
