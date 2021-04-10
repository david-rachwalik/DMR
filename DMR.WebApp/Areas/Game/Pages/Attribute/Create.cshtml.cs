using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Attribute
{
    public class CreateModel : PageModel
    {
        private readonly IAttributeService _attributeService;

        public CreateModel(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

        [BindProperty]
        public Models.Attribute Attribute { get; set; }


        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }
            
            await _attributeService.CreateAsync(Attribute);

            return RedirectToPage("./Index");
        }
    }
}
