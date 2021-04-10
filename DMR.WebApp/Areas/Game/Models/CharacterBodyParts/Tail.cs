using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Tail : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public int Recharge { get; set; }
        public int Venom { get; set; }
    }


    //public enum TailTagStyle
    //{
    //    NONE,
    //    HORSE,
    //    DEMONIC,
    //    COW,
    //    SPIDER_ADBOMEN,
    //    BEE_ABDOMEN,
    //    SHARK,
    //    CAT,
    //    LIZARD,
    //    RABBIT,
    //    HARPY,
    //    KANGAROO,
    //    FOX,
    //    DRACONIC,
    //    RACCOON,
    //    MOUSE
    //}
}
