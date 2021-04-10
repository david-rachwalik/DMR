using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Blog.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        //public IEnumerable<Models.Character> Characters { get; set; }

        //public async Task OnGetAsync()
        //{
        //    Characters = await _characterService.OnGetListAsync();
        //}
    }
}
