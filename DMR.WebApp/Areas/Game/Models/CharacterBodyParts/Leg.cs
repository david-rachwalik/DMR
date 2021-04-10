using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Leg : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }
        
        public int Thigh { get; set; }
        public int Knee { get; set; }
        public int Calf { get; set; }
        public int Shin { get; set; }
    }
}
