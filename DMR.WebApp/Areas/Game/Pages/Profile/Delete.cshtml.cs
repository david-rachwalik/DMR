using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    public class DeleteModel : PageModel
    {
        private readonly IUserProfileService _userProfileService;

        public DeleteModel(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [BindProperty]
        public UserProfile UserProfile { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            UserProfile = await _userProfileService.ReadAsync(id);

            if (UserProfile == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            await _userProfileService.DeleteAsync(id);
            
            return RedirectToPage("./Index");
        }
    }
}
