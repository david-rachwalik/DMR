using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Mouth : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public TongueStyle Tongue { get; set; }
        public int Teeth { get; set; }
    }


    public enum TongueStyle
    {
        TONUGE_HUMAN,
        TONUGE_SNAKE,
        TONUGE_DEMONIC,
        TONUGE_DRACONIC
    }
}
