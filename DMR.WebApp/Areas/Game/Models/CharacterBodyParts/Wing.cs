using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Wing : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public WingSize Size { get; set; }
    }


    public enum WingSize
    {
        Normal = 1,
        Small,
        Large
    }

    //public enum WingTagStyle
    //{
    //    NONE = 1,
    //    BEE_LIKE_SMALL,
    //    BEE_LIKE_LARGE,
    //    HARPY,
    //    IMP,
    //    BAT_LIKE_TINY,
    //    BAT_LIKE_LARGE,
    //    SHARK_FIN,
    //    FEATHERED_LARGE,
    //    DRACONIC_SMALL,
    //    DRACONIC_LARGE,
    //    GIANT_DRAGONFLY
    //}
}
