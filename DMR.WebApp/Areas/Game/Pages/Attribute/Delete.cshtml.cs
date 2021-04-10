using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Attribute
{
    public class DeleteModel : PageModel
    {
        private readonly IAttributeService _attributeService;

        public DeleteModel(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

        [BindProperty]
        public Models.Attribute Attribute { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) { return NotFound(); }

            Attribute = await _attributeService.ReadAsync(id);

            if (Attribute == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) { return NotFound(); }
            
            await _attributeService.DeleteAsync(id);
            
            return RedirectToPage("./Index");
        }
    }
}
