using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Foot : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public int Ankle { get; set; }
        public int Heel { get; set; }
        public int Arch { get; set; }
        public int Ball { get; set; }
        public int Toes { get; set; }
        public int Nails { get; set; }
    }
}
