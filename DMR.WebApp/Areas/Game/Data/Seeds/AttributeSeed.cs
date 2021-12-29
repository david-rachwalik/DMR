using DMR.WebApp.Areas.Game.Models;
using Attribute = DMR.WebApp.Areas.Game.Models.Attribute;

namespace DMR.WebApp.Areas.Game.Data.Seeds;

public static class AttributeSeed
{
    public static Attribute[] Data()
    {
        //string runtimeVersion = typeof(Startup)
        //    .GetTypeInfo()
        //    .Assembly
        //    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
        //    .InformationalVersion;

        Attribute[] attributes = new Attribute[]
        {
            new Attribute()
            {
                Id = 1,
                Title = "Agility",
                Abbreviation = "AGI",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Dexterity and speed"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 2,
                Title = "Strength",
                Abbreviation = "STR",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Ability to weild grander weapons and strike with greater efficiency"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 3,
                Title = "Speed",
                Abbreviation = "SPE",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Hastens the pace of combat flow"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 4,
                Title = "Vitality",
                Abbreviation = "VIT",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Toughness and resilience"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 5,
                Title = "Intelligence",
                Abbreviation = "INT",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Boosts attack of spells and ability to cast more effectively (conjuration, alchemy, alteration, illusion)"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 6,
                Title = "Willpower",
                Abbreviation = "WIL",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Increases mana capacity and regen (restoration, mysticism)"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 7,
                Title = "Luck",
                Abbreviation = "LUK",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Effects nearly everything nominally"
                //Release = runtimeVersion
            },
            new Attribute()
            {
                Id = 8,
                Title = "Esteem",
                Abbreviation = "EST",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Description = "Enhances personality, charisma, and confidence (tease)"
                //Release = runtimeVersion
            },

            // Corruption of Champions
            new Attribute()
            {
                Id = 9,
                Title = "Strength",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "str",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 10,
                Title = "Toughness",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "tou",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 11,
                Title = "Speed",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "spe",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 12,
                Title = "Intelligence",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "inte",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 13,
                Title = "Sensitivity",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "sens",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 14,
                Title = "Libido",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "lib",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core,
                Value = 15
            },
            new Attribute()
            {
                Id = 15,
                Title = "Corruption",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "cor",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Core
            },
            new Attribute()
            {
                Id = 16,
                Title = "Lust",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "lust",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Sexual
            },
            new Attribute()
            {
                Id = 17,
                Title = "Experience",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "XP",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Utility
            },
            new Attribute()
            {
                Id = 18,
                Title = "Level",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "lvl",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Utility
            },
            new Attribute()
            {
                Id = 19,
                Title = "HP",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "HP",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Defense
            },
            new Attribute()
            {
                Id = 20,
                Title = "Gems",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "gems",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Utility
            },
            new Attribute()
            {
                Id = 21,
                Title = "Fatigue",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "fati",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Utility
            },


            new Attribute()
            {
                Id = 22,
                Title = "cumMultiplier",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "cumx",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Sexual
            },
            new Attribute()
            {
                Id = 23,
                Title = "hoursSinceCum",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Abbreviation = "tcum",
                Format = AttributeFormat.Integer,
                Style = AttributeStyle.Sexual
            }
        };

        return attributes;
    }
}
