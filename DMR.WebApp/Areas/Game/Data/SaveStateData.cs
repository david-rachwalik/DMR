using DMR.WebApp.Areas.Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data
{
    public static class SaveStateData
    {
        public static SaveState[] Seed()
        {
            SaveState[] saveState = new SaveState[]
            {
                new SaveState
                {
                    Id = 1,
                    Title = "The Player"
                }
            };

            return saveState;
        }
    }
}
