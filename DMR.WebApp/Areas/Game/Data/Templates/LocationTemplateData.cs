using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Models.Templates;
using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data
{
    public class LocationTemplateData
    {
        public static LocationTemplate[] Seed()
        {
            LocationTemplate[] locations = new LocationTemplate[]
            {
                new LocationTemplate
                {
                    Id = 1,
                    Title = "Mareth",
                    Description = "Mareth is the world in which the story of Corruption of Champions takes place. It is an entirely different world to that from which the Champion comes, and the game opens with them being transported there via an interplanar portal.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.World,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Mareth",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Mareth"
                },
                new LocationTemplate
                {
                    Id = 2,
                    Title = "Ingnam",
                    Description = "This is a pre-portal, gem and information gathering prologue to the Corruption of Champions main plot.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.World,
                    Release = "0.9.4",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ingnam"
                },
                
                // CoC Primary Zones, ordered by discovery
                new LocationTemplate
                {
                    Id = 3,
                    ParentId = 1,
                    Title = "Forest",
                    Description = "An old looking forest, inhabited by a variety of (generally low level) enemies.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Forest",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Forest"
                },
                new LocationTemplate
                {
                    Id = 4,
                    ParentId = 1,
                    Title = "Lake",
                    Description = "The shores of a freshwater lake, it is generally considered the lowest level area due to a lack of enemies at level 1. The lake itself can be explored with the lake boat.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Lake",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lake"
                },
                new LocationTemplate
                {
                    Id = 5,
                    ParentId = 1,
                    Title = "Desert",
                    Description = "A wide desert hiding the city of Tel'Adre.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Desert",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Desert"
                },
                new LocationTemplate
                {
                    Id = 6,
                    ParentId = 1,
                    Title = "Mountain",
                    Description = "A tall mountain and home to several higher-level enemies.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Mountain",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Mountain"
                },
                new LocationTemplate
                {
                    Id = 7,
                    ParentId = 1,
                    Title = "Plains",
                    Description = "Wide grasslands, and home to some of the tougher enemies in the game.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Plains",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Plains"
                },
                new LocationTemplate
                {
                    Id = 8,
                    ParentId = 1,
                    Title = "Swamp",
                    Description = "A sweltering and stagnant swamp, home to male and female spider-morphs.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Swamp",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Swamp"
                },

                // CoC Secondary Zones
                new LocationTemplate
                {
                    Id = 9,
                    ParentId = 3,
                    Title = "Deepwoods",
                    Description = "A region of forest hidden behind a wall of trees.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Deepwoods",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Deepwoods"
                },
                new LocationTemplate
                {
                    Id = 10,
                    ParentId = 6,
                    Title = "High Mountain",
                    Description = "A higher region of the Mountains and home to even tougher foes.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/High_Mountain",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/High_Mountain"
                },
                new LocationTemplate
                {
                    Id = 11,
                    ParentId = 8,
                    Title = "Bog",
                    Description = "A particularly dark and humid area inside the Swamp.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Zone,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Bog",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Bog"
                },

                // CoC Places
                new LocationTemplate
                {
                    Id = 12,
                    ParentId = 3,
                    Title = "Campsite",
                    Description = "Built around the portal where you first enter Mareth, the Campsite is a relatively safe place where you can rest and recover between adventures and store some of the items you don't need to bring along on your journeys.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Campsite",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Camp"
                },
                new LocationTemplate
                {
                    Id = 13,
                    ParentId = 4,
                    Title = "Boat",
                    Description = "",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Boat",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Boat"
                },
                new LocationTemplate
                {
                    Id = 14,
                    ParentId = 4,
                    Title = "Farm",
                    Description = "It is home to Marble the cow-girl and Kelt the centaur.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Whitney%27s_Farm",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Whitney%27s_Farm"
                },
                new LocationTemplate
                {
                    Id = 15,
                    ParentId = 4,
                    Title = "Town Ruins",
                    Description = "The Town Ruins is a run down town or village near the Lake.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Town_Ruins",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Town_Ruins"
                },
                new LocationTemplate
                {
                    Id = 16,
                    ParentId = 5,
                    Title = "Cathedral",
                    Description = "The ruins of a Cathedral",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Gargoyle",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Cathedral"
                },
                new LocationTemplate
                {
                    Id = 17,
                    ParentId = 5,
                    Title = "Tel'Adre",
                    Description = "Tel'Adre is a hidden city, relatively free of and concealed from corruption, located in the desert. The city owes its freedom to the Covenant, a powerful group of magic-users who reside in the city.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Tel%27Adre",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Tel%27Adre"
                },
                new LocationTemplate
                {
                    Id = 18,
                    ParentId = 6,
                    Title = "Salon",
                    Description = "The Champion can discover a cleverly concealed doorway hidden within the Mountain, from which they can hear the sounds of blades being sharpened.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Salon",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Salon"
                },
                new LocationTemplate
                {
                    Id = 19,
                    ParentId = 7,
                    Title = "Bizarre Bazaar",
                    Description = "A settlement formed in the Plains from a ring of brightly colored wagons. It serves as a counter to Tel'Adre, in that it welcomes those who are corrupt and rejects those who are pure.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Bizarre_Bazaar",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Bizarre_Bazaar"
                },
                new LocationTemplate
                {
                    Id = 20,
                    ParentId = 7,
                    Title = "Owca",
                    Description = "Owca (aka Gang-bang Village) is a hidden village located in the plains.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Place,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Owca",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Owca_Village"
                },

                // CoC main story dungeons
                new LocationTemplate
                {
                    Id = 21,
                    ParentId = 6,
                    Title = "Demon Factory",
                    Description = "The Demon Factory (aka D1) sits at the foot of the Mountain. It can be found after visiting Marae by using the Boat found at the Lake.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Dungeon,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Demon_Factory",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Demon_Factory"
                },
                new LocationTemplate
                {
                    Id = 22,
                    ParentId = 9,
                    Title = "Deep Cave",
                    Description = "Deep Cave lies within the Deepwoods. It can be found once the Demon Factory is completed.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Dungeon,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Deep_Cave",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Deep_Cave"
                },
                new LocationTemplate
                {
                    Id = 23,
                    ParentId = 10,
                    Title = "Lethice's Stronghold",
                    Description = "The final dungeon in the game. It's located in the High Mountain and can only be found after clearing the Deep Cave.",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Dungeon,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Lethice%E2%80%99s_Stronghold",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lethice%27s_Stronghold"
                },
                // CoC side story dungeons
                new LocationTemplate
                {
                    Id = 24,
                    ParentId = 5,
                    Title = "Desert Cave",
                    Description = "Sand Witch's Dungeon (aka home of the sand witches)",
                    Dimension = Dimension.CoC,
                    Group = LocationGroup.Dungeon,
                    Release = "0.9.4",
                    UriSmutosaurWiki = "https://wiki.smutosaur.us/CoC/Sand_Witch%27s_Dungeon",
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Desert_Cave"
                },
                
                // CoC Revamp
                new LocationTemplate
                {
                    Id = 25,
                    Title = "Glacial Rift",
                    Description = "",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Zone,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Glacial_Rift"
                },
                new LocationTemplate
                {
                    Id = 26,
                    Title = "Volcanic Crag",
                    Description = "",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Zone,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Volcanic_Crag"
                },
                new LocationTemplate
                {
                    Id = 27,
                    Title = "Anzu's Palace",
                    Description = "(Found under Dungeons)",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Place,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Anzu"
                },
                new LocationTemplate
                {
                    Id = 28,
                    Title = "Oasis Tower",
                    Description = "Visit Minerva the Siren in High Mountain.",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Place,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Minerva"
                },
                new LocationTemplate
                {
                    Id = 29,
                    Title = "Prison",
                    Description = "Prison is a place that's the home of Mistress Elly, Scruffy the Imp, and more.",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Place,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Prison"
                },
                new LocationTemplate
                {
                    Id = 30,
                    Title = "Tower of the Phoenix",
                    Description = "",
                    Dimension = Dimension.CoCRevamp,
                    Group = LocationGroup.Dungeon,
                    UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Tower_of_the_Phoenix"
                },
                
                // Custom filler data
                new LocationTemplate
                {
                    Id = 31,
                    Title = "Agora",
                    Description = "Pocket dimension safe zone, smells like cookies",
                    Dimension = Dimension.DMR,
                    Group = LocationGroup.Place
                },
                new LocationTemplate
                {
                    Id = 32,
                    Title = "Colosseum",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Group = LocationGroup.Place
                },
                new LocationTemplate
                {
                    Id = 33,
                    Title = "Amphitheater",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Group = LocationGroup.Place
                },
                new LocationTemplate
                {
                    Id = 34,
                    Title = "Ak-Sar-Ben",
                    Description = "Indoor arena and horse racing complex",
                    Dimension = Dimension.DMR,
                    Group = LocationGroup.Place
                }
            };

            return locations;
        }
    }
}
