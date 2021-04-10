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

namespace DMR.WebApp.Areas.Info.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly IUserProfileService _userProfileService;

        //public IndexModel(IUserProfileService userProfileService)
        //{
        //    _userProfileService = userProfileService;
        //}

        //public UserProfile UserProfile { get; set; }
        //public bool IsContinueEnabled { get { return (UserProfile.Saves.Count > 0); } }
        public bool IsContinueEnabled => true;

        //public async Task<IActionResult> OnGetAsync()
        //{
        //    //UserProfile = await _userProfileService.OnGetAsync();
        //    return Page();
        //}


        //public async Task<IActionResult> OnPostSleepAsync(int? id)
        //{
        //    //UserProfile = await _context.UserProfiles.FirstOrDefaultAsync(m => m.Id == 1);
        //    Character = await _context.Characters.FirstOrDefaultAsync(m => m.Id == testId);
        //    Character.Slept = ++Character.Slept;
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("./Index");
        //}
    }
}
