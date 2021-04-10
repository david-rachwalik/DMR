using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }


        // GET: api/Tag
        [HttpGet]
        public async Task<IEnumerable<Tag>> Get()
        {
            return await _tagService.ReadListAsync();
        }

        // GET: api/Tag/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Tag> Get(int id)
        {
            return await _tagService.ReadAsync(id);
        }

        // POST: api/Tag
        [HttpPost]
        public async Task<int> Post([FromBody] Tag tag)
        {
            return await _tagService.CreateAsync(tag);
        }

        // PUT: api/Tag/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Tag tag)
        {
            return await _tagService.UpdateAsync(tag);
        }

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public async void Delete(int id)
        //{
        //    return await _tagService.OnDeleteAsync(id);
        //}
    }
}