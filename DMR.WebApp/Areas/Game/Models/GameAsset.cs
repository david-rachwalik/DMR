using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models
{
    public abstract class GameAsset : Asset
    {
        public Dimension Dimension { get; set; } // Worlds are within realms/dimensions
        public string Release { get; set; } // TODO: generate release/patch from build when not provided
        // Moderator scan approve and stash or approve and make live
        public bool IsLive { get; set; }
    }


    public enum Dimension
    {
        None,
        DMR,
        Nimin,
        CoC,
        CoCRevamp
    }
}
