using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Pages.Effect
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public IEnumerable<string> Elements { get; set; }


        public async Task OnGetAsync()
        {
            Elements = await Task.FromResult(Enum.GetNames(typeof(Element)));
        }
    }
}
