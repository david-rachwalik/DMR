using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Models;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Play
{
    public class DataModel : PageModel
    {
        private const int testId = 0;
        //private readonly IUserProfileService _userProfileService;

        //public DataModel(IUserProfileService userProfileService)
        //{
        //    _userProfileService = userProfileService;
        //}
        public DataModel()
        {
        }

        public UserProfile UserProfile { get; set; }
        public bool IsContinueEnabled { get; set; }


        //public async Task<IActionResult> OnGetAsync()
        //{
        //    //if (id == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    UserProfile = await _userProfileService.ReadAsync(testId);

        //    if (UserProfile == null)
        //    {
        //        return RedirectToPage("./NewGame");
        //    }
        //    else
        //    {
        //        IsContinueEnabled = true;
        //    }

        //    return Page();
        //}
        public async Task<IActionResult> OnGetAsync()
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //UserProfile = await _userProfileService.ReadAsync(testId);
            UserProfile = new UserProfile();

            if (UserProfile == null)
            {
                return RedirectToPage("./NewGame");
            }
            else
            {
                IsContinueEnabled = true;
            }

            return Page();
        }
    }
}
