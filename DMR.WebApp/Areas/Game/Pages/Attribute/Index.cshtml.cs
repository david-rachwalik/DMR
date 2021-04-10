using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;

namespace DMR.WebApp.Areas.Game.Pages.Attribute
{
    public class IndexModel : PageModel
    {
        private readonly IAttributeService _attributeService;

        public IndexModel(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

        public IEnumerable<Models.Attribute> Attributes { get; set; }
        public Models.Attribute FirstAttribute { get; set; }


        public async Task OnGetAsync()
        {
            Attributes = await _attributeService.ReadListAsync();
            FirstAttribute = Attributes.First();
        }
    }
}
