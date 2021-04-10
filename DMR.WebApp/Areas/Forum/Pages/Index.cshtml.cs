using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Forum.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly IUserProfileService _userProfileService;

        //public IndexModel(IUserProfileService userProfileService)
        //{
        //    _userProfileService = userProfileService;
        //}

        //public UserProfile UserProfile { get; set; }
        //public bool IsContinueEnabled => UserProfile.Saves.Count > 0;
        public bool IsContinueEnabled => true;

        //public async Task<IActionResult> OnGetAsync()
        //{
        //    UserProfile = await _userProfileService.OnGetAsync();
        //    return Page();
        //}

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
