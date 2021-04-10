using DMR.WebApp.Areas.Game.Models.CharacterBodyParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data.CharacterBodyParts
{
    public static class VaginaData
    {
        public static Vagina[] Seed()
        {
            Vagina[] vaginas = new Vagina[]
            {
                new Vagina
                {
                    Id = 1,
                    Title = "Human",
                    Description = "human"
                },
                new Vagina
                {
                    Id = 2,
                    Title = "Black Sand Trap",
                    Description = "black sandtrap"
                }
            };

            return vaginas;
        }
    }
}
