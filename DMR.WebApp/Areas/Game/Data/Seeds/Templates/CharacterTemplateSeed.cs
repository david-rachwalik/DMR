using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Areas.Game.Models.Templates;

namespace DMR.WebApp.Areas.Game.Data.Seeds.Templates;
 
public static class CharacterTemplateSeed
{
    public static CharacterTemplate[] Data()
    {
        CharacterTemplate[] characters = new CharacterTemplate[]
        {
            new CharacterTemplate
            {
                Id = 1,
                Title = "David Default"
            },
            new CharacterTemplate
            {
                Id = 2,
                Title = "Miia"
            },
            new CharacterTemplate
            {
                Id = 3,
                Title = "Papi"
            },
            new CharacterTemplate
            {
                Id = 4,
                Title = "Centorea"
            },
            new CharacterTemplate
            {
                Id = 5,
                Title = "Suu"
            },
            new CharacterTemplate
            {
                Id = 6,
                Title = "Mero"
            },
            new CharacterTemplate
            {
                Id = 7,
                Title = "Rachnera"
            },
            new CharacterTemplate
            {
                Id = 8,
                Title = "Lala"
            },

            // CoC
            new CharacterTemplate
            {
                Id = 9,
                Title = "Rathazul",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Rathazul",
                CampRecruit = true,
                Follower = true
            },
            new CharacterTemplate
            {
                Id = 10,
                Title = "Shouldra",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Shouldra",
                CampRecruit = true,
                Follower = true
            },
            new CharacterTemplate
            {
                Id = 11,
                Title = "Valeria",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Valeria",
                CampRecruit = true,
                Follower = true
            },
            new CharacterTemplate
            {
                Id = 12,
                Title = "Helspawn",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Helspawn",
                CampRecruit = true,
                Follower = true
            },
            new CharacterTemplate
            {
                Id = 13,
                Title = "Ember",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ember",
                CampRecruit = true,
                Follower = true
            },
            new CharacterTemplate
            {
                Id = 14,
                Title = "Sophie",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Sophie",
                CampRecruit = true,
                Follower = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 15,
                Title = "Jojo",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Jojo",
                CampRecruit = true,
                Follower = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 16,
                Title = "Bath Girl",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Bath_Girl",
                CampRecruit = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 17,
                Title = "Ceraph",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ceraph",
                CampRecruit = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 18,
                Title = "Vapula",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Vapula",
                CampRecruit = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 19,
                Title = "Latex Girl",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Latex_Goo-Girl",
                CampRecruit = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 20,
                Title = "Amily",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Amily",
                CampRecruit = true,
                Lover = true,
                Slave = true
            },
            new CharacterTemplate
            {
                Id = 21,
                Title = "Arian",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Arian",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 22,
                Title = "Isabella",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Isabella",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 23,
                Title = "Izma",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Izma",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 24,
                Title = "Kiha",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Kiha",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 25,
                Title = "Marble",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 26,
                Title = "Nieve",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Marble",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 27,
                Title = "Phylla",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Phylla",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 28,
                Title = "Helia",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Helia",
                CampRecruit = true,
                Lover = true
            },
            new CharacterTemplate
            {
                Id = 29,
                Title = "Hollicynthia",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Holli",
                CampRecruit = true
            },
            new CharacterTemplate
            {
                Id = 30,
                Title = "Anemone kid",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Kid_A",
                CampRecruit = true
            },

            // Player
            new CharacterTemplate
            {
                Id = 31,
                Title = "Champion",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Champion"
            },
                
            // Persistent Characters 
            new CharacterTemplate
            {
                Id = 32,
                Title = "Akbal",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Akbal"
            },
            new CharacterTemplate
            {
                Id = 33,
                Title = "Benoit",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Benoit"
            },
            new CharacterTemplate
            {
                Id = 34,
                Title = "Brooke",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Brooke"
            },
            new CharacterTemplate
            {
                Id = 35,
                Title = "Callu",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Callu"
            },
            new CharacterTemplate
            {
                Id = 36,
                Title = "Ceraph",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ceraph"
            },
            new CharacterTemplate
            {
                Id = 37,
                Title = "Cinnabar",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Cinnabar"
            },
            new CharacterTemplate
            {
                Id = 38,
                Title = "Cotton",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Cotton"
            },
            new CharacterTemplate
            {
                Id = 39,
                Title = "Edryn",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Edryn"
            },
            new CharacterTemplate
            {
                Id = 40,
                Title = "Erlking",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Erlking"
            },
            new CharacterTemplate
            {
                Id = 41,
                Title = "Essrayle",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Essrayle"
            },
            new CharacterTemplate
            {
                Id = 42,
                Title = "Faerie",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Faerie"
            },
            new CharacterTemplate
            {
                Id = 43,
                Title = "Frosty",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Frosty"
            },
            new CharacterTemplate
            {
                Id = 44,
                Title = "Gargoyle",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Gargoyle"
            },
            new CharacterTemplate
            {
                Id = 45,
                Title = "Giacomo",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Giacomo"
            },
            new CharacterTemplate
            {
                Id = 46,
                Title = "Greta",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Greta"
            },
            new CharacterTemplate
            {
                Id = 47,
                Title = "Heckel",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Heckel"
            },
            new CharacterTemplate
            {
                Id = 48,
                Title = "Hellhound Master",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Hellhound_Master"
            },
            new CharacterTemplate
            {
                Id = 49,
                Title = "Ifris",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ifris"
            },
            new CharacterTemplate
            {
                Id = 50,
                Title = "Izumi",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Izumi"
            },
            new CharacterTemplate
            {
                Id = 51,
                Title = "Jasun",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Jasun"
            },
            new CharacterTemplate
            {
                Id = 52,
                Title = "Kami",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Kami"
            },
            new CharacterTemplate
            {
                Id = 53,
                Title = "Katherine",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Katherine"
            },
            new CharacterTemplate
            {
                Id = 54,
                Title = "Kelt",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Kelt"
            },
            new CharacterTemplate
            {
                Id = 55,
                Title = "Loppe",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Loppe"
            },
            new CharacterTemplate
            {
                Id = 56,
                Title = "Lottie",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lottie"
            },
            new CharacterTemplate
            {
                Id = 57,
                Title = "Lucia",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lucia"
            },
            new CharacterTemplate
            {
                Id = 58,
                Title = "Lumi",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lumi"
            },
            new CharacterTemplate
            {
                Id = 59,
                Title = "Lynette",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Lynette"
            },
            new CharacterTemplate
            {
                Id = 60,
                Title = "Maddie",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Madeleine"
            },
            new CharacterTemplate
            {
                Id = 61,
                Title = "Minerva",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Minerva"
            },
            new CharacterTemplate
            {
                Id = 62,
                Title = "Marcus",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Marcus"
            },
            new CharacterTemplate
            {
                Id = 63,
                Title = "Naga",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Naga"
            },
            new CharacterTemplate
            {
                Id = 64,
                Title = "Nancy",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Aunt_Nancy"
            },
            new CharacterTemplate
            {
                Id = 65,
                Title = "Niamh",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Niamh"
            },
            new CharacterTemplate
            {
                Id = 66,
                Title = "Oswald",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Oswald"
            },
            new CharacterTemplate
            {
                Id = 67,
                Title = "Quinn",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Quinn"
            },
            new CharacterTemplate
            {
                Id = 68,
                Title = "Raphael",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Raphael"
            },
            new CharacterTemplate
            {
                Id = 69,
                Title = "Rebecc",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Rebecc"
            },
            new CharacterTemplate
            {
                Id = 70,
                Title = "Ro'Gar",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Ro%27Gar"
            },
            new CharacterTemplate
            {
                Id = 71,
                Title = "Roxanne",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Roxanne_Poisontail"
            },
            new CharacterTemplate
            {
                Id = 72,
                Title = "Rubi",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Rubi"
            },
            new CharacterTemplate
            {
                Id = 73,
                Title = "Sanura",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Sanura"
            },
            new CharacterTemplate
            {
                Id = 74,
                Title = "Scylla",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Scylla"
            },
            new CharacterTemplate
            {
                Id = 75,
                Title = "Sheila",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Sheila"
            },
            new CharacterTemplate
            {
                Id = 76,
                Title = "Tamani",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Tamani"
            },
            new CharacterTemplate
            {
                Id = 77,
                Title = "Tamani's Daughters",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Tamani%27s_Daughters"
            },
            new CharacterTemplate
            {
                Id = 78,
                Title = "Urta",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Urta"
            },
            new CharacterTemplate
            {
                Id = 79,
                Title = "Vala",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Vala"
            },
            new CharacterTemplate
            {
                Id = 80,
                Title = "Venus",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Venus"
            },
            new CharacterTemplate
            {
                Id = 81,
                Title = "Victoria",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Victoria"
            },
            new CharacterTemplate
            {
                Id = 82,
                Title = "Whitney",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Whitney"
            },
            new CharacterTemplate
            {
                Id = 83,
                Title = "Yara",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Yara"
            },
            new CharacterTemplate
            {
                Id = 84,
                Title = "Yvonne",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Yvonne"
            },
            new CharacterTemplate
            {
                Id = 85,
                Title = "Zetaz",
                Dimension = Dimension.CoC,
                Release = "0.9.4",
                UriRevampWikia = "http://coc-revamp.wikia.com/wiki/Zetaz"
            },

            // CoC Beastiary
            //new CharacterTemplate
            //{
            //    Id = 000,
            //    Title = "",
            //    Dimension = Dimension.CoC,
            //    Release = "0.9.4",
            //    UriRevampWikia = ""
            //},
        };

        return characters;
    }
}