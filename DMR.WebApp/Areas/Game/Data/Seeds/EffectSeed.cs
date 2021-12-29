using DMR.WebApp.Areas.Game.Models;

namespace DMR.WebApp.Areas.Game.Data.Seeds;

public static class EffectSeed
{
    public static Effect[] Data()
    {
        Effect[] effects = new Effect[]
        {
            new Effect
            {
                Id = 1,
                Title = "Damage",
                Description = "Character suffers health loss"
            },
            new Effect
            {
                Id = 2,
                Title = "Heal",
                Description = "Perform a healing act upon another character.  Not unlike reversing damage though often accompanied with benefits."
            },
            new Effect
            {
                Id = 3,
                Title = "Sleep",
                Description = "Character is overcome by an intense, persuasive influence to slumber."
            },
            new Effect
            {
                Id = 4,
                Title = "Knockout",
                Description = "Character drops like a rock."
            },
            new Effect
            {
                Id = 5,
                Title = "Blind",
                Description = "Character's chance to hit is reduced 50% with 5% chance of harming self or ally."
            },
            new Effect
            {
                Id = 6,
                Title = "Disarm",
                Description = "Character has fumbled their weapon/shield; unable to perform physical abilities for duration."
            },
            new Effect
            {
                Id = 7,
                Title = "Silence",
                Description = "Mouth sealed like Neo (woah); unable to perform magic abilities for duration."
            },
            new Effect
            {
                Id = 8,
                Title = "Stun",
                Description = "Character is unable to act, immobilized by fear, shackles, or some other force at work."
            },
            new Effect
            {
                Id = 9,
                Title = "Absorb",
                Description = "Prevent incoming damage or healing."
            },
            new Effect
            {
                Id = 10,
                Title = "Solar Teleportation",
                Description = "Provides you with instant travel across the world."
            },
            new Effect
            {
                Id = 11,
                Title = "Lunar Teleportation",
                Description = "You can freely shift among parallel dimensions."
            },
            new Effect()
            {
                Id = 12,
                Title = "Burn",
                Description = "Take damage after every action",
                Element = Element.Fire
            },
            new Effect()
            {
                Id = 13,
                Title = "Chill",
                Description = "Action speed greatly reduced"
            },
            new Effect()
            {
                Id = 14,
                Title = "Freeze",
                Description = "Unable to take actions"
            },
            new Effect()
            {
                Id = 15,
                Title = "Shock",
                Description = "Unable to take actions; melee against shocked opponent may cause feedback"
            },
            new Effect()
            {
                Id = 16,
                Title = "Stun",
                Description = ""
            },
            new Effect()
            {
                Id = 17,
                Title = "Daze",
                Description = ""
            },
            new Effect()
            {
                Id = 18,
                Title = "Dizzy",
                Description = "Attack accuracy greatly reduced"
            },
            new Effect()
            {
                Id = 19,
                Title = "Forget",
                Description = "Unable to use skills"
            },
            new Effect()
            {
                Id = 20,
                Title = "Sleep",
                Description = "Unable to take actions; HP/MP slowly restore"
            },
            new Effect()
            {
                Id = 21,
                Title = "Confuse",
                Description = "Throw away gold/item, attack ally, do nothing"
            },
            new Effect()
            {
                Id = 22,
                Title = "Fear",
                Description = "High chance of ignoring commands, chance of running from battle"
            },
            new Effect()
            {
                Id = 23,
                Title = "Despair",
                Description = "Unable to cast, MP depleats; character is incapacitated after too many turns"
            },
            new Effect()
            {
                Id = 24,
                Title = "Rage",
                Description = "AP increased, defense decreased; character won't listen to orders, auto-melee"
            },
            new Effect()
            {
                Id = 25,
                Title = "Brainwash",
                Description = "Heal an enemy, attack ally, or support enemy"
            },
            new Effect()
            {
                Id = 26,
                Title = "Amenable",
                Description = ""
            },
            new Effect()
            {
                Id = 27,
                Title = "Flustered",
                Description = ""
            },
            new Effect()
            {
                Id = 28,
                Title = "Tender",
                Description = ""
            },
            new Effect()
            {
                Id = 29,
                Title = "Bubble",
                Description = "It grants absorb based on 100% of Max HP."
            },
            new Effect()
            {
                Id = 30,
                Title = "Neutralized",
                Description = ""
            },
            new Effect()
            {
                Id = 31,
                Title = "Asleep",
                Description = ""
            },
            new Effect()
            {
                Id = 32,
                Title = "Restrained",
                Description = ""
            },
            new Effect()
            {
                Id = 33,
                Title = "Frog",
                Description = ""
            }
        };

        return effects;
    }
}