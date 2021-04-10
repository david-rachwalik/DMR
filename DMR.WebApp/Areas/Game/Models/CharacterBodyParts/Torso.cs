using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    // https://en.wikipedia.org/wiki/Torso
    public class Torso : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        // Extra section styles
        public int Shoulder { get; set; }
        public int Chest { get; set; }
        public int Waist { get; set; }
        public int Hips { get; set; }
        public int Abdomen { get; set; }
        public int Naval { get; set; }
        public int Back { get; set; }
        public int Stomach { get; set; } // Tummy
    }
}
