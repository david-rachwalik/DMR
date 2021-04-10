using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Breast : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }
        public int Nipples { get; set; }
    }
}
