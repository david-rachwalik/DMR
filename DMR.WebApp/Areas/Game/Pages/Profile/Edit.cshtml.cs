using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
    public class EditModel : PageModel
    {
        private readonly IUserProfileService _userProfileService;

        public EditModel(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [BindProperty]
        public UserProfile UserProfile { get; set; }
        public Setting_Theme Theme { get; set; }
        public IEnumerable<string> ThemeNames => Enum.GetNames(typeof(Setting_Theme)).Cast<string>().ToList();


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            UserProfile = await _userProfileService.ReadAsync(id);

            if (UserProfile == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            await _userProfileService.UpdateAsync(UserProfile);
            
            return RedirectToPage("./Index");
        }
    }
}
