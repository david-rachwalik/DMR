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

namespace DMR.WebApp.Areas.Game.Pages.Location
{
    public class IndexModel : PageModel
    {
        //private readonly IUserProfileService _userProfileService;
        private readonly ILocationTemplateService _locationService;

        public IndexModel(
            //IUserProfileService userProfileService,
            ILocationTemplateService locationService)
        {
            //_userProfileService = userProfileService;
            _locationService = locationService;
        }

        //public UserProfile UserProfile { get; private set; }
        public IEnumerable<Models.Location> Zones { get; private set; }
        public IEnumerable<Models.Location> Places { get; private set; }
        public IEnumerable<Models.Location> Dungeons { get; private set; }
        public bool IsSpecific { get; private set; }
        public Models.Location Selection { get; private set; }
        

        public async Task OnGetAsync(int? id)
        {
            //UserProfile = await _userProfileService.OnGetAsync();
            Zones = await _locationService.ReadListAsync(LocationGroup.Zone);
            Places = await _locationService.ReadListAsync(LocationGroup.Place);
            Dungeons = await _locationService.ReadListAsync(LocationGroup.Dungeon);
            IsSpecific = id.HasValue;
            Selection = await _locationService.ReadAsync(id);
        }
    }
}
