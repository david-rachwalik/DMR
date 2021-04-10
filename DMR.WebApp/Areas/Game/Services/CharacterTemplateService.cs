using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Data;
using DMR.WebApp.Areas.Game.Models.Templates;

namespace DMR.WebApp.Areas.Game.Services
{
    public interface ICharacterTemplateService
    {
        Task<CharacterTemplate> ReadAsync(int? id);
        Task<IEnumerable<CharacterTemplate>> ReadListAsync();
        Task<int> CreateAsync(CharacterTemplate character);
        Task<int> UpdateAsync(CharacterTemplate character);
        Task<int> DeleteAsync(int? id);
    }


    public class CharacterTemplateService : ICharacterTemplateService
    {
        private readonly ApplicationContext _context;

        public CharacterTemplateService(ApplicationContext context)
        {
            _context = context;
        }


        // Private Methods
        private bool Exists(int id)
        {
            return _context.Characters.Any(e => e.Id == id);
        }


        // Public Methods
        public async Task<CharacterTemplate> ReadAsync(int? id)
        {
            if (id == null) { return null; }
            CharacterTemplate character = await _context.CharacterTemplates.FirstOrDefaultAsync(m => m.Id == id);
            return await Task.FromResult(character);
        }

        public async Task<IEnumerable<CharacterTemplate>> ReadListAsync()
        {
            //IEnumerable<CharacterTemplate> characters = new List<CharacterTemplate>();

            //characters = await _context.Characters.ToListAsync();
            //return await Task.FromResult(characters);

            return await Task.FromResult(await _context.CharacterTemplates.ToListAsync());
        }

        public async Task<int> CreateAsync(CharacterTemplate character)
        {
            _context.Characters.Add(character);
            int changes = await _context.SaveChangesAsync();

            return await Task.FromResult(changes);
        }

        public async Task<int> UpdateAsync(CharacterTemplate character)
        {
            _context.Attach(character).State = EntityState.Modified;
            int changes = await _context.SaveChangesAsync();
            
            return await Task.FromResult(changes);
        }

        public async Task<int> DeleteAsync(int? id)
        {
            int changeCount = 0;
            CharacterTemplate character = await ReadAsync(id);

            if (character != null)
            {
                _context.Characters.Remove(character);
                changeCount = await _context.SaveChangesAsync();
            }

            return await Task.FromResult(changeCount);
        }
    }
}
