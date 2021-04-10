using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data
{
    public static class TagData
    {
        public static Tag[] Seed()
        {
            Tag[] tags = new Tag[]
            {
                // Many fetishes and descriptions from (http://hentaihaven.org/pick-your-poison/)
                // TODO: http://ahegao.online/tags/
                new Tag
                {
                    Id = 10,
                    Title = "Ahegao",
                    Description = "Chicks who get fucked silly. Tongues hanging out, eyes rolling back, that good stuff!",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 11,
                    Title = "Anal",
                    Description = "The wrong hole, but it feels so right.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 12,
                    Title = "BDSM",
                    Description = "Ropes, leather suits, chains, total domination.  What more do you want? -cracks whip-",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 13,
                    Title = "Big Ass",
                    Description = "",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 14,
                    Title = "Big Dick",
                    Description = "",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 15,
                    Title = "Big Tits",
                    Description = "Oppai is love, oppai is life.  Unless you don't like big breasts I suppose.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 16,
                    Title = "Blow Job",
                    Description = "Oral sex, where guys get to relax, sit back and take in the view.  I heard it's quite a mouthful.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 17,
                    Title = "Bondage",
                    Description = "BDSM without a ton of accessories.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 18,
                    Title = "Boob Job",
                    Description = "Boobs on your dick.  Sound good?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 19,
                    Title = "Comedy",
                    Description = "Who said hentai couldn't be funny and sexy at the same time?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 20,
                    Title = "Creampie",
                    Description = "How you were made.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 21,
                    Title = "Multiple Penetration",
                    Description = "Several dicks in a character.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 22,
                    Title = "Facial",
                    Description = "Involves a dude ejaculating on a chick's face.  Mostly cause she ain't up for swallowing...",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 23,
                    Title = "Femdom",
                    Description = "Guess who wears the pants in this relationship? Not you.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 24,
                    Title = "Foot Job",
                    Description = "Who knew someone's feet could be put to good use...",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 25,
                    Title = "Futanari",
                    Description = "Chicks with dicks.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 26,
                    Title = "Gangbang",
                    Description = "When 3 or more people gang up on a single person of the opposite sex, we have this lovely situation play out.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 27,
                    Title = "Gender Bender",
                    Description = "Allows NPCs to transition to another gender.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 28,
                    Title = "Golden Shower",
                    Description = "We're talking about a rain of liquid, and it's not gold.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 29,
                    Title = "Hand Job",
                    Description = "Probably the best place a chick's hand can be.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 30,
                    Title = "Harem",
                    Description = "1 guy, multiple mates.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 31,
                    Title = "Horror",
                    Description = "Involves gore, spooky vibes or other horrifying things.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 32,
                    Title = "Incest",
                    Description = "Wincest",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 33,
                    Title = "Inflation",
                    Description = "When someone's stomach or boobs get bigger due to magic or cum overload.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 34,
                    Title = "Lactation",
                    Description = "Breast milk anyone?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 35,
                    Title = "Licking",
                    Description = "Going down on some pussay!",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 36,
                    Title = "Massocism",
                    Description = "",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 37,
                    Title = "Masturbation",
                    Description = "Helping/watching without touching.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 38,
                    Title = "Milf",
                    Description = "Hot older women.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 39,
                    Title = "Mind Break",
                    Description = "Corrupting the innocent and turning them into sex crazed fiends, what more could you possibly ask for?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 40,
                    Title = "Mind Control",
                    Description = "Sometimes matchmaking isn't easy... unless we involve drugs and magic! (Side effects might include getting raped.)",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 41,
                    Title = "Netorare",
                    Description = "When the person you love cheats on you with someone else - willingly or unwillingly.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 42,
                    Title = "Netori",
                    Description = "When you steal someone else's partner - opposite of netorare.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 43,
                    Title = "Orgy",
                    Description = "A lot of people.  A lot of sex.  Enough said.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 44,
                    Title = "Pregnant",
                    Description = "No need to wear a condom.  How much more pregnant could they get...?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 45,
                    Title = "Public Sex",
                    Description = "Let's do it out here in broad daylight; there's no way someone will see us!",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 46,
                    Title = "Rape",
                    Description = "",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 47,
                    Title = "Rimjob",
                    Description = "Licking ass is never a good idea, butt fuck it...",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 48,
                    Title = "Saddism",
                    Description = "",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 49,
                    Title = "Scat",
                    Description = "If it looks like shit, smells like shit, and tastes like shit, it probably is shit.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 50,
                    Title = "Tentacle",
                    Description = "Do I really need to explain?",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 51,
                    Title = "Threesome",
                    Description = "Like bringing a plus 1 to a 2-person party, but less awkward, more fun.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 52,
                    Title = "Toys",
                    Description = "Vibrators, dildos, and all kinds of Nintendo type shit.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 53,
                    Title = "Tsundere",
                    Description = "We all know a tsundere chick.  They hate you at first, but then in a bizarre turn of events, end up fucking you in a closet.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 54,
                    Title = "Virgin",
                    Description = "Someone untouched... until now.",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 55,
                    Title = "Voyeur",
                    Description = "Creepin without sleepin",
                    Group = "TagGroup.Fetish"
                },
                new Tag
                {
                    Id = 56,
                    Title = "Weight Gain", // BBW
                    Description = "",
                    Group = "TagGroup.Fetish"
                },


                // Species
                // http://wiki.yiffalicious.com/index.php/Characters
                new Tag
                {
                    Id = 100,
                    Title = "Human",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 101,
                    Title = "Slime",
                    Description = "Goo",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 102,
                    Title = "Lamia",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 103,
                    Title = "Harpy",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 104,
                    Title = "Centaur",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 105,
                    Title = "Lagomorph",
                    Description = "Bunny Rabbit",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 106,
                    Title = "Dragon",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 107,
                    Title = "Fox",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 108,
                    Title = "Wolf",
                    Description = "Puppy Dog",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 109,
                    Title = "Cat",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 110,
                    Title = "Pony",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 111,
                    Title = "Raccoon",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 112,
                    Title = "Lizard",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 113,
                    Title = "Bee",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 114,
                    Title = "Goblin",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 115,
                    Title = "Shark",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 116,
                    Title = "Spider",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 117,
                    Title = "Kangaroo",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 118,
                    Title = "Mouse",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },

                // Condition Tags
                new Tag
                {
                    Id = 119,
                    Title = "Demon",
                    Description = "",
                    Group = "TagGroup.EffectLimiter"
                },
                new Tag
                {
                    Id = 120,
                    Title = "Ghost",
                    Description = "",
                    Group = "TagGroup.EffectLimiter"
                },
                new Tag
                {
                    Id = 121,
                    Title = "Mummy",
                    Description = "",
                    Group = "TagGroup.EffectLimiter"
                },
                new Tag
                {
                    Id = 122,
                    Title = "Flying",
                    Description = "",
                    Group = "TagGroup.EffectLimiter"
                },
                new Tag
                {
                    Id = 123,
                    Title = "Invisible",
                    Description = "",
                    Group = "TagGroup.EffectLimiter"
                },

                new Tag
                {
                    Id = 124,
                    Title = "Alien",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 125,
                    Title = "Cow",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 126,
                    Title = "Minotaur",
                    Description = "",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 127,
                    Title = "Lunar Elf",
                    Description = "Has a natural affinity for the void.  Very curvatious with long, pointed back ears.",
                    Group = "TagGroup.CharacterSpecies"
                },
                new Tag
                {
                    Id = 128,
                    Title = "Solar Elf",
                    Description = "Has a natural affinity for the light.  Delightfully lithe and perky with long, pointed up ears.",
                    Group = "TagGroup.CharacterSpecies"
                },

                // Location Tags
                new Tag
                {
                    Id = 129,
                    Title = "Explored",
                    Description = "",
                    Group = "TagGroup.Location"
                },
            };

            return tags;
        }
    }
}
