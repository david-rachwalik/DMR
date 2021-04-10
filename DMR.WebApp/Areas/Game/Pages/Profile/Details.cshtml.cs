using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Data;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Pages.Profile
{
    public class DetailsModel : PageModel
    {
        private readonly IUserProfileService _userProfileService;

        public DetailsModel(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        public UserProfile UserProfile { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            UserProfile = await _userProfileService.ReadAsync(id);

            if (UserProfile == null) { return NotFound(); }
            return Page();
        }
    }
}
