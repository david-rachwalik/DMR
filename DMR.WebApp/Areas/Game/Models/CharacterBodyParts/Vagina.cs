using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Vagina : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        public VaginalLooseness Looseness { get; set; }
        public VaginaWetness Wetness { get; set; }
        public bool Virgin { get; set; }

        //Used during sex to determine how full it currently is.  For multi-dick sex.
        public int Fullness { get; set; }
        public bool LabiaPierced { get; set; }
        public string LabiaPShort { get; set; }
        public string LabiaPLong { get; set; }
        public bool ClitPierced { get; set; }
        public string ClitPShort { get; set; }
        public string ClitPLong { get; set; }
    }


    //public enum VaginaTagStyle
    //{
    //    HUMAN = 1,
    //    BLACK_SAND_TRAP
    //}

    public enum VaginalLooseness
    {
        Virgin = 1,
        Normal,
        Loose,
        VeryLoose,
        Gaping,
        Monstrous
    }

    public enum VaginaWetness
    {
        DRY = 1,
        NORMAL,
        WET,
        SLICK,
        DROOLING,
        SLAVERING
    }
}
