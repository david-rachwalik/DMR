using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Hand : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public int Palm { get; set; }
        public int Fingers { get; set; }
        public int Nails { get; set; }
    }


    public enum FingerStyle
    {
        Thumb = 1,
        Index,
        Middle,
        Ring,
        Little,
        Nail
    }
}
