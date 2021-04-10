using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Data;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Pages.Profile
{
    public class CreateModel : PageModel
    {
        private readonly IUserProfileService _userProfileService;

        public CreateModel(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [BindProperty]
        public UserProfile UserProfile { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            await _userProfileService.CreateAsync(UserProfile);

            return RedirectToPage("./Index");
        }
    }
}
