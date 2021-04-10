using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Areas.Game.Services;
using DMR.WebApp.Models;

namespace DMR.WebApp.Areas.Game.Models.CharacterBodyParts
{
    public class Head : Asset, ICharacterAsset
    {
        public Tag Species { get; set; }
        public int Skin { get; set; }

        // Extra section styles
        public int Horn { get; set; }
        public HairStyle Hair { get; set; }
        public FaceStyle Face { get; set; }
        public EyeStyle Eye { get; set; }
        public EyebrowStyle Eyebrow { get; set; }
        public EarStyle Ear { get; set; }
        public int Cheeks { get; set; }
        public IEnumerable<Mouth> Mouths { get; set; }
        public int Jaw { get; set; }
        public int Beard { get; set; }
        public int Neck { get; set; }
    }


    public enum HairStyle
    {
        HAIR_NORMAL,
        HAIR_FEATHER,
        HAIR_GHOST,
        HAIR_GOO,
        HAIR_ANEMONE
    }

    public enum FaceStyle
    {
        FACE_HUMAN,
        FACE_HORSE,
        FACE_DOG,
        FACE_COW_MINOTAUR,
        FACE_SHARK_TEETH,
        FACE_SNAKE_FANGS,
        FACE_CAT,
        FACE_LIZARD,
        FACE_BUNNY,
        FACE_KANGAROO,
        FACE_SPIDER_FANGS,
        FACE_FOX,
        FACE_DRAGON,
        FACE_RACCOON_MASK,
        FACE_RACCOON,
        FACE_BUCKTEETH,
        FACE_MOUSE
    }

    public enum EyeStyle
    {
        EYES_HUMAN,
        EYES_FOUR_SPIDER_EYES,
        EYES_BLACK_EYES_SAND_TRAP
    }

    public enum EyebrowStyle
    {

    }

    public enum EarStyle
    {

    }

    public enum PiercingStyle
    {

    }
}
