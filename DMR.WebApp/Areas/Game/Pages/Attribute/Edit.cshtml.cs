using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Attribute
{
    public class EditModel : PageModel
    {
        //private readonly IUserProfileService _userProfileService;
        private readonly IAttributeService _attributeService;

        public EditModel(
            //IUserProfileService userProfileService,
            IAttributeService attributeService)
        {
            //_userProfileService = userProfileService;
            _attributeService = attributeService;
        }

        //public UserProfile UserProfile { get; private set; }
        [BindProperty]
        public Models.Attribute Attribute { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            //UserProfile = await _userProfileService.OnGetAsync();
            Attribute = await _attributeService.ReadAsync(id);

            if (Attribute == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            await _attributeService.UpdateAsync(Attribute);

            return RedirectToPage("./Index");
        }
    }
}
