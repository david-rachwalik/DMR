using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Models.Templates;

namespace DMR.WebApp.Areas.Game.Data.Seeds.Templates;

public static class ItemTemplateSeed
{
    public static ItemTemplate[] Data()
    {
        ItemTemplate[] items = new ItemTemplate[]
        {
            new ItemTemplate
            {
                Id = 1,
                Title = "Comfortable Under Clothes",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Gift,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 2,
                Title = "Comfortable Clothes",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Gift,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 3,
                Title = "Fur Loincloth",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 4,
                Title = "Goo Armor",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 5,
                Title = "Inquisitor's Corset",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 6,
                Title = "Inquisitor's Robes",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 7,
                Title = "Leather Armor Segments",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 8,
                Title = "Lusty Maiden's Armor",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 9,
                Title = "Seductive Armor",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },
            new ItemTemplate
            {
                Id = 10,
                Title = "Slutty Swimwear",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Armor
            },

            new ItemTemplate
            {
                Id = 11,
                Title = "Beautiful Sword",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 12,
                Title = "Dragon Shell Shield",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 13,
                Title = "Eldritch Staff",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 14,
                Title = "Fists",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 15,
                Title = "Huge Warhammer",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 16,
                Title = "Jeweled Rapier",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 17,
                Title = "Large Claymore",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 18,
                Title = "Large Hammer",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 19,
                Title = "Raphael's Rapier",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 20,
                Title = "Spellblade",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },
            new ItemTemplate
            {
                Id = 21,
                Title = "Wizard's Staff",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Weapon
            },

            new ItemTemplate
            {
                Id = 22,
                Title = "Bee Honey",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 23,
                Title = "Bimbo Liqueur",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 24,
                Title = "De Bimbo",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 25,
                Title = "Gro Plus",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 26,
                Title = "Hair Extension Serum",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 27,
                Title = "Kitsune Gift",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 28,
                Title = "Lust Stick",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 29,
                Title = "Oviposition Elixir",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 30,
                Title = "Phouka Whiskey",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 31,
                Title = "Reducto",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 32,
                Title = "Rizza Root",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },
            new ItemTemplate
            {
                Id = 33,
                Title = "Wing Stick",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                Origin = ItemOrigin.Encounter,
                Group = ItemGroup.Consumable
            },

            // DMR
            new ItemTemplate
            {
                Id = 34,
                Title = "Iridescent Anklet",
                Dimension = Dimension.DMR,
                Origin = ItemOrigin.Gift, // Must get from a boyfriend event
                Group = ItemGroup.Apparel
            },
            // Game Grumps - Ninja Gaiden Sigma, Ep2
            // https://youtu.be/av2LWb9QWf0?list=PLCMX5qohdITFN38_ivrE_3eN7nheMagM7&t=385
            new ItemTemplate
            {
                Id = 35,
                Title = "The Ancient Scroll of a Thousand Whatevers",
                Description = "You can no longer be bothered by death or much else for that matter.  You take on an undamaged undead form, emotionless and cold.  Immune to cold and poison damage.",
                Dimension = Dimension.DMR,
                Group = ItemGroup.Trinket
            },
            new ItemTemplate
            {
                Id = 36,
                Title = "Negligee",
                Dimension = Dimension.DMR,
                Group = ItemGroup.Apparel
            },
            new ItemTemplate
            {
                Id = 37,
                Title = "Lightning Daggers",
                Dimension = Dimension.DMR,
                Group = ItemGroup.Weapon
            }
        };

        return items;
    }
}