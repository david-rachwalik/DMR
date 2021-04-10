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

namespace DMR.WebApp.Areas.Game.Pages.Item
{
    public class IndexModel : PageModel
    {
        private readonly IItemTemplateService _itemService;

        public IndexModel(IItemTemplateService itemService)
        {
            _itemService = itemService;
        }

        public IEnumerable<Models.Item> Items { get; private set; }
        public Models.Item FirstItem { get; private set; }
        public Models.Item SelectedItem { get; private set; }


        public async Task OnGetAsync(int? id)
        {
            if (id != null && id > 0)
            {
                SelectedItem = await _itemService.ReadAsync(id);
            }
            else
            {
                Items = await _itemService.ReadListAsync();
                FirstItem = Items.First();
            }
        }
    }
}
