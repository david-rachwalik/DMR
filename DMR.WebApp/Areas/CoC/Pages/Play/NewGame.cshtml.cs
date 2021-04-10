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

namespace DMR.WebApp.Areas.Game.Pages.Play
{
    public class NewGameModel : PageModel
    {
        private const int testId = 1;
        //private readonly IUserProfileService _userProfileService;

        //public NewGameModel(IUserProfileService userProfileService)
        //{
        //    _userProfileService = userProfileService;
        //}

        //public UserProfile UserProfile { get; set; }

        
        public async Task<IActionResult> OnGetAsync()
        {
            return await Task.FromResult(Page());
        }

        //public async Task<IActionResult> OnPostNewGameAsync()
        //{
        //    //int changeCount = await _userProfileService.OnPostNewGameAsync();
        //    return RedirectToPage("./Index");
        //}
    }
}
