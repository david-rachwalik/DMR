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
    public class IndexModel : PageModel
    {
        private const int testId = 0;
        //private readonly IUserProfileService _userProfileService;

        //public IndexModel(IUserProfileService userProfileService)
        //{
        //    _userProfileService = userProfileService;
        //}

        //public Models.UserProfile UserProfile { get; set; }
        public bool IsContinueEnabled { get; set; }


        public IActionResult OnGet()
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //UserProfile = await _userProfileService.OnGetAsync(testId);
            //if (UserProfile == null)
            //{
            //    return RedirectToPage("./NewGame");
            //}
            //else
            //{
            //    IsContinueEnabled = true;
            //}
            IsContinueEnabled = true;
            
            return Page();
        }
    }
}
