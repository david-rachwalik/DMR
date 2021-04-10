using DMR.WebApp.Areas.Game.Models;
using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Data
{
    public static class SkillData
    {
        public static Skill[] Seed()
        {
            Skill[] skills = new Skill[]
            {
                // https://wiki.smutosaur.us/CoC/Perk_(CoC)

                // Corruption of Champions: Starter Perks
                new Skill
                {
                    Id = 1,
                    Title = "Big Clit",
                    Description = "Allows your clit to grow larger more easily and faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Female, choose \"Big Clit\" during character creation.",
                    Effect = "Your clit starts 1\" longer than normal, and increases its growth rate by ?%."
                },
                new Skill
                {
                    Id = 2,
                    Title = "Big Cock",
                    Description = "Gains cock size 25% faster and with less limitations.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Male, choose \"Big Cock\" during character creation.",
                    Effect = "Your cock starts 2\" longer than normal, increases at 25% the rate, and neglects hardcaps on penis-enlarging items(?)."
                },
                new Skill
                {
                    Id = 3,
                    Title = "Big Tits",
                    Description = "Makes your tits grow larger more easily.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Female, choose \"Big Breasts\" during character creation.",
                    Effect = "Your tits start as DD-cups, and grow ?% larger from size-increasing items."
                },
                new Skill
                {
                    Id = 4,
                    Title = "Fast",
                    Description = "Gain speed 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Speed\" during character creation.",
                    Effect = "You start with +5 Speed. You gain speed 25% faster."
                },
                new Skill
                {
                    Id = 5,
                    Title = "Fertile",
                    Description = "Makes you 15% more likely to become pregnant.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Female, choose \"Fertile\" during character creation.",
                    Effect = "Increases your fertility by 15."
                },
                new Skill
                {
                    Id = 6,
                    Title = "Lusty",
                    Description = "Gains lust 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Libido\" during character creation.",
                    Effect = "You start with +5 Libido. (Additional effects? +lust over time? +lust from everything? Increased libido gains?)"
                },
                new Skill
                {
                    Id = 7,
                    Title = "Messy Orgasms",
                    Description = "Produces 50% more cum volume.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Male, choose \"Lots of Jizz\" during character creation.",
                    Effect = "Increases your cum production by 50%."
                },
                new Skill
                {
                    Id = 8,
                    Title = "Sensitive",
                    Description = "Gain sensitivity 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Touch\" during character creation.",
                    Effect = "You start with +5 Sensitivity. Your sensitivity increases 25% faster."
                },
                new Skill
                {
                    Id = 9,
                    Title = "Smart",
                    Description = "Gains intelligence 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Smarts\" during character creation.",
                    Effect = "You start with +5 Intelligence. Intelligence gains are boosted by +25%."
                },
                new Skill
                {
                    Id = 10,
                    Title = "Strong",
                    Description = "Gains strength 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Strength\" during character creation.",
                    Effect = "You start with +5 Strength. Strength gains are boosted by +25%."
                },
                new Skill
                {
                    Id = 11,
                    Title = "Tough",
                    Description = "Gains toughness 25% faster.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Choose \"Toughness\" during character creation ",
                    Effect = "You start with +5 Toughness. Toughness gains are boosted by +25%."
                },
                new Skill
                {
                    Id = 12,
                    Title = "Wet Pussy",
                    Description = "",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_StarterPerk,
                    Prerequisites = "Female, Choose \"Wet Vagina\" during character creation",
                    Effect = "Start with +1 vaginal wetness."
                },

                // Corruption of Champions: History Perks
                new Skill
                {
                    Id = 13,
                    Title = "Alchemist",
                    Description = "Alchemical experience makes items more reactive to your body.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Increases maximum amount of transformations by one for most transformation items."
                },
                new Skill
                {
                    Id = 14,
                    Title = "Fighter",
                    Description = "You spent much of your time fighting other children, and you had plans to find work as a guard when you grew up.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Past full of conflict increases physical damage dealt by 10%."
                },
                new Skill
                {
                    Id = 15,
                    Title = "Healer",
                    Description = "You often spent your free time with the village healer, learning how to tend to wounds.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Healing experience increases HP gains by 20%."
                },
                new Skill
                {
                    Id = 16,
                    Title = "Religious",
                    Description = "You spent a lot of time at the village temple, and learned how to meditate. Replaces masturbate with meditate when corruption less than or equal to 66.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Meditation only lowers lust by 50, but also lowers corruption. It doesn't reset \"hours since cum\" counter."
                },
                new Skill
                {
                    Id = 17,
                    Title = "Scholar",
                    Description = "You spent much of your time in school, and even begged the richest man in town, Mr. Savin, to let you read some of his books.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Time spent focusing your mind makes spellcasting 20% less fatiguing."
                },
                new Skill
                {
                    Id = 18,
                    Title = "Slacker",
                    Description = "You spent a lot of time slacking, avoiding work, and otherwise making a nuisance of yourself.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Regenerate fatigue 20% faster."
                },
                new Skill
                {
                    Id = 19,
                    Title = "Slut",
                    Description = "You managed to spend most of your time having sex. Quite simply, when it came to sex, you were the village bicycle - everyone got a ride.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Sexual experience has made you more able to handle large insertions and more resistant to stretching."
                },
                new Skill
                {
                    Id = 20,
                    Title = "Smith",
                    Description = "You managed to get an apprenticeship with the local blacksmith. Because of your time spent at the blacksmith's side, you've learned how to fit armor for maximum protection.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Knowledge of armor and fitting increases armor effectiveness by roughly 10%."
                },
                new Skill
                {
                    Id = 21,
                    Title = "Whore",
                    Description = "You managed to to find work as a whore. Because of your time spent trading seduction for profit, you're more effective at teasing (+15% tease damage).",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_HistoryPerk,
                    Prerequisites = "",
                    Effect = "Seductive experience causes your tease attacks to be 15% more effective."
                },
                // * Choosing either the 'slut' or 'whore' history perks will cause your character to start without being a virgin.
                
                // Corruption of Champions: Tier 0 Perks
                new Skill
                {
                    Id = 22,
                    Title = "Corrupted Libido",
                    Description = "Reduces lust gain by 33%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater corruption.",
                    Effect = "Increases to the character's lust are reduced by 33%."
                },
                new Skill
                {
                    Id = 23,
                    Title = "Acclimation",
                    Description = "Reduces the rate at which your lust increases.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "40 or greater minimum lust, the Corrupted Libido perk, and 50 or greater corruption.",
                    Effect = "Increases to the character's lust are reduced by 40%"
                },
                new Skill
                {
                    Id = 24,
                    Title = "Evade",
                    Description = "Increases chances of evading enemy attacks",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater speed.",
                    Effect = "Grants the character an additional 10% chance to dodge enemies' standard attacks, an increased chance to dodge some enemy special attacks, and an additional chance to succeed at some out-of-combat checks."
                },
                new Skill
                {
                    Id = 25,
                    Title = "Runner",
                    Description = "The Runner perk increases your chances of escaping combat significantly, and may help with out of combat escapes as well.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Evade perk and 25 or greater speed.",
                    Effect = "Grants the character an additional 50% chance to flee from combat."
                },
                new Skill
                {
                    Id = 26,
                    Title = "Double Attack",
                    Description = "Allows you to perform two melee attacks per round",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Evade perk, the Runner perk, and 50 or greater speed.",
                    Effect = "The character is given the ability to toggle use of this perk if their strength is above 60. While using the perk their strength will effectively become 60 if it is greater than that amount. While the character's strength is 60 or less, the character will attack twice when making a standard attack. If the character's strength is greater than 60, he will only attack once at full strength."
                },
                new Skill
                {
                    Id = 27,
                    Title = "Fertility+",
                    Description = "Increases Fertility and cum volume by up to 50%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater libido.",
                    Effect = "+50% bonus to Cum Production, +15% bonus to Fertility (pregnancy chance), and +3% bonus to hidden Virility stat."
                },
                new Skill
                {
                    Id = 28,
                    Title = "Hot Blooded",
                    Description = "Raises minimum lust by up to 20.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "50 or greater libido.",
                    Effect = "Increases the character's minimum lust to 20. When combined with Nymphomania, minimum Lust is 40. When combined with Omnibus' Gift, minimum Lust is 45. With all three, minimum Lust is 60."
                },
                new Skill
                {
                    Id = 29,
                    Title = "Mage",
                    Description = "Increases the strength of your spells even more than 'Spellpower', up to 100%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Spellpower perk and 50 or greater intelligence.",
                    Effect = "Increases the character's spell modifier to 2."
                },
                new Skill
                {
                    Id = 30,
                    Title = "Nymphomania",
                    Description = "Raises minimum lust by up to 30.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Corrupted Libido perk and 75 or greater corruption.",
                    Effect = "Increases the character's minimum lust to 30. When combined with Omnibus' Gift, minimum Lust is 50. When combined with Hot Blooded, minimum Lust is 40. With all three, minimum Lust is 60."
                },
                new Skill
                {
                    Id = 31,
                    Title = "Precision",
                    Description = "Reduces enemy damage resistance by 10.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater intelligence.",
                    Effect = "If the character's intelligence is 25 or greater upon when entering combat, enemy's armor defense is lowered by 10, to a minimum of 0."
                },
                new Skill
                {
                    Id = 32,
                    Title = "Regeneration",
                    Description = "Regenerates 2% Max HP/hour and 1% Max HP/round.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Tank perk and 50 or greater toughness.",
                    Effect = "The character regains 2% of his/her maximum hit points per hour outside of combat, and 1% of his/her maximum hit point per round when in combat."
                },
                new Skill
                {
                    Id = 33,
                    Title = "Seduction",
                    Description = "Upgrades your tease attack, making it more effective.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "50 or greater corruption, and the character must have fully corrupted Jojo.",
                    Effect = "Replaces the Tease Special with the more powerful Seduce command.",
                    Note = "Maintaining >50 corruption doesn't seem to be necessary for this perk"
                },
                new Skill
                {
                    Id = 34,
                    Title = "Spellpower",
                    Description = "Increases the effects of your spells by up to 50%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "50 or greater intelligence.",
                    Effect = "Increases the character's spell modifier to 1.5."
                },
                new Skill
                {
                    Id = 35,
                    Title = "Strong Back",
                    Description = "Enables fourth item slot.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater strength.",
                    Effect = "Unlocks inventory slot 4."
                },
                new Skill
                {
                    Id = 36,
                    Title = "Strong Back 2: Strong Harder",
                    Description = "Enables fifth item slot.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "The Strong Back perk and 50 or greater strength.",
                    Effect = "Unlocks inventory slot 5."
                },
                new Skill
                {
                    Id = 37,
                    Title = "Tank",
                    Description = "The Tank perk adds an additional 50 HP to your maximum hit points, allowing you take more damage before losing a fight.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier0Perk,
                    Prerequisites = "25 or greater toughness.",
                    Effect = "Raises max HP by 50."
                },
                
                // Corruption of Champions: Tier 1 Perks
                new Skill
                {
                    Id = 38,
                    Title = "Agility",
                    Description = "Boosts armor points by a portion of your speed on light/medium armors.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Runner perk, 75 or greater speed, and the character must be wearing light or medium armour.",
                    Effect = "The defense stats of armor with the Light or Medium perks are increased by a fraction of the character's speed. Armour with the Light perk is increased by 1/8th, and armour with the Medium perk by 1/13th"
                },
                new Skill
                {
                    Id = 39,
                    Title = "Arousing Aura",
                    Description = "Exude a lust-inducing aura (Req's corruption of 70 or more)",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Corrupted Libido perk and 70 or greater corruption.",
                    Effect = "So long as the character's corruption is 70 or greater, enemies will gain lust each round of combat."
                },
                new Skill
                {
                    Id = 40,
                    Title = "Brutal Blows",
                    Description = "Reduces enemy armor with each hit.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "75 or greater strength. If strength drops below 75, perk stops working.",
                    Effect = "Reduces enemy's armor by 10 on each hit."
                },
                new Skill
                {
                    Id = 41,
                    Title = "Channeling",
                    Description = "Increases base spell strength by 50%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Spellpower perk, the Mage perk, 60 or greater intelligence, and the character must know at least one spell.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 42,
                    Title = "Immovable Object",
                    Description = "Grants 20% physical damage reduction",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "75 or greater toughness. If toughness drops below 75, perk stops working.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 43,
                    Title = "Lightning Strikes",
                    Description = "Increases the attack damage for non-heavy weapons",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "60 or greater speed. If speed drops below 60, perk stops working.",
                    Effect = "+([speed-50]/3) attack damage."
                },
                new Skill
                {
                    Id = 44,
                    Title = "Masochist",
                    Description = "Take 30% less physical damage, but gain lust when damaged",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "60 or greater libido and 50 or greater corruption.",
                    Effect = "So long as the character's libido is 60 or greater, damage taken is reduced by 30% but causes a slight lust gain (2 points before resistances)."
                },
                new Skill
                {
                    Id = 45,
                    Title = "Medicine",
                    Description = "Grants 15% chance per round of cleansing poisons/drugs from your body",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "60 or greater intelligence.",
                    Effect = "Each round in combat, the character has a 15% chance to remove the effects of harpy lip-gloss, Naga venom, red potions (thrown by Tamani, Zetaz, and Goblins), and green poison (thrown by Tamani and Goblins)"
                },
                new Skill
                {
                    Id = 46,
                    Title = "Regeneration 2",
                    Description = "Gain 2% of max HP per round of combat and 4% of max HP per hour out of combat ",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Regeneration perk, clear the Demon Factory, 70 or greater toughness.",
                    Effect = "Double the effectiveness of the Regeneration perk. The character regenerate 2% of his/her maximum HP in combat and 4% of his/her maximum HP outside of combat per hour."
                },
                new Skill
                {
                    Id = 47,
                    Title = "Resistance",
                    Description = "Reduces lust gain by 10%",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "No additional requirements beyond having level 6.",
                    Effect = "Lust resistance is increased by 10%."
                },
                new Skill
                {
                    Id = 48,
                    Title = "Sadist",
                    Description = "Deal 20% more damage, but gain lust at the same time",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Corrupted Libido perk and 60 or greater corruption. If your minimum lust is 20 or above you need Acclimation first.",
                    Effect = "Damage done with standard attacks, the kick and gore special attacks is increased by 20%, but causes a slight lust gain with each attack (3 points before resistances)."
                },
                new Skill
                {
                    Id = 49,
                    Title = "Speedy Recovery",
                    Description = "Regain fatigue 50% faster",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Evade perk and 60 or greater speed.",
                    Effect = "Fatigue regains 50% faster when sleeping or resting."
                },
                new Skill
                {
                    Id = 50,
                    Title = "Tactician",
                    Description = "Increases critical hit chance by up to 10% (Intelligence-based)",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "50 or greater intelligence. If intelligence drops below 50, perk stops working.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 51,
                    Title = "Tank 2",
                    Description = "+1 extra HP per point of toughness",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "The Tank perk and 60 or greater toughness.",
                    Effect = "The character's maximum hitpoints is increased by an amount equal to their toughness stat (with fractions rounded to the nearest integer)."
                },
                new Skill
                {
                    Id = 52,
                    Title = "Thunderous Strikes",
                    Description = "+20% 'Attack' damage while strength is at or above 80",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "80 or greater strength.",
                    Effect = "Damage dealt by regular attacks in combat is increased by 20% while strength is 80 or greater."
                },
                new Skill
                {
                    Id = 53,
                    Title = "Weapon Mastery",
                    Description = "Doubles damage bonus of weapons classified as 'large'",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "60 or greater strength.",
                    Effect = "The attack stat of weapons with the large perk is doubled."
                },
                new Skill
                {
                    Id = 54,
                    Title = "Well Adjusted",
                    Description = "You gain half as much lust as time passes in Mareth",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier1Perk,
                    Prerequisites = "Libido of 60 or greater.",
                    Effect = "Lust gains due to passing time are reduced by 50%, and dirty dreams will not trigger an additional lust increase."
                },
                
                // Corruption of Champions: Tier 2 Perks
                new Skill
                {
                    Id = 55,
                    Title = "Archmage",
                    Description = "Increases base spell strength by 50%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "75 or greater intelligence, Mage perk. If intelligence drops below 75, perk stops working.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 56,
                    Title = "Berzerker",
                    Description = "Grants 'Berzerk' ability",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "75 or greater strength. If strength drops below 75, perk stops working.",
                    Effect = "Unlocks Berzerk special attack. Berzerking increases attack and lust resistance but reduces physical defenses."
                },
                new Skill
                {
                    Id = 57,
                    Title = "Blademaster",
                    Description = "Gain +10% to critical strike chance when wielding a sword and not using a shield",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 58,
                    Title = "Iron Man",
                    Description = "Reduces the fatigue cost of physical specials by 50%",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "60 Toughness or greater. If Toughness decrease below 60 the perk may stop working.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 59,
                    Title = "Lunging Attacks",
                    Description = "Grants 50% armor penetration for standard attacks",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "75 or greater speed. If speed drops below 75, perk stops working.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 60,
                    Title = "Resolute",
                    Description = "Grants immunity to stuns and some statuses",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_Tier2Perk,
                    Prerequisites = "75 or greater toughness. If toughness drops below 75, perk stops working.",
                    Effect = "Grants immunity to: Gnoll spear-thrower's special spear that slows player and Isabella's stun."
                },
                
                // Corruption of Champions: Transformation Perks
                new Skill
                {
                    Id = 61,
                    Title = "Bee Ovipositor",
                    Description = "Allows you to lay eggs through a special organ on your insect abdomen, though you need at least 10 eggs to lay.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Possess a Bee Abdomen and a high enough bee score.",
                    Effect = "You start producing eggs. Once you have at least 10 eggs, special sex scenes with some NPCs and monsters become unlocked. For every 20 eggs you currently have, your minimum lust level will be raised 10 points. Minimum Lust will reset to its normal level once you implant someone with your eggs."
                },
                new Skill
                {
                    Id = 62,
                    Title = "Bunny Eggs",
                    Description = "Laying eggs has become a normal part of your bunny-body's routine.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Consume a Neon Pink Egg while your Bunny score is at least 5. Lost if bunny score drops below 3.",
                    Effect = "Causes you to lay eggs once every 30 days when not otherwise pregnant. Decreases timer to 15 days if both Bunny Eggs and Oviposition are obtained, or if character is otherwise highly fertile."
                },
                new Skill
                {
                    Id = 63,
                    Title = "Corrupted Nine-Tails",
                    Description = "The mystical energy of the nine-tails surges through you, filling you with phenomenal cosmic power! Your boundless magic allows you to recover quickly after casting spells, but your method of attaining it has corrupted the transformation, preventing you from achieving true enlightenment.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Must have already gained fox ears and have obtained your 8th tail by consuming the Mystic Jewel. Another use may give your 9th and final tail.",
                    Effect = "The Champion will gain the Corrupted Fox Fire and Terror special attacks. Additionally the Champions recovers Fatigue at an increased rate. Must maintain at least 80 intelligence and 9 tails, or lose the perk. --NOTE: Having high corruption is not needed to gain or keep this perk active, my test character succeeded with 28 corruption and the feat worked perfectly. There is a very small chance the Mystic Jewel give you two tails at the same time instead of one if your actual value is seven or lower. If seven you may obtain this perk immediately. The fatigue recovery is increased randomly each time an action in combat is performed, the bonus usually vary from 1 to 5 points."
                },
                new Skill
                {
                    Id = 64,
                    Title = "Diapause",
                    Description = "Pregnancy does not advance normally, but develops quickly after taking in fluids.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "May be gained by consuming kanga fruit while the character has a vagina and a kangaroo score greater than 4.",
                    Effect = "Consuming fluids will increase a character's fluid store by 3-5 hours. Pregnancies progress faster while the character still has a fluid store, but will not progress when the fluid store is empty."
                },
                new Skill
                {
                    Id = 65,
                    Title = "Dragonfire",
                    Description = "Allows access to a dragon breath attack.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Gained from repeatedly drinking Ember's blood. Requires a Dragon Score of at least 4 and no more than one other transformation during the scene in order to unlock the perk.",
                    Effect = "Unlocks the DragonFire M.Attack. --NOTE: Only once a day by default.",
                    Note = "Eating Ember's Dragon Eggs, having sex with Ember or drinking Ember's blood will remove the cooldown for the day. Eating a Dragon Egg while not in cooldown will give a +50% boost."
                },
                new Skill
                {
                    Id = 66,
                    Title = "Enlightened Nine-Tails",
                    Description = "The mystical energy of the nine-tails surges through you, filling you with phenomenal cosmic power! Your boundless magic allows you to recover quickly after casting spells.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Must have already gained fox ears and have your 8th tail. Using the gem again your character may \"feel\" that he/she need to do meditate at the Shrine of the Ninetails to gain its ninth tail, which can be found as a random encounter in the Deepwoods, while having a Fox Jewel in your inventory.",
                    Effect = "The Champion will gain the Fox Fire and Illusion special attacks. Additionally the Champions recovers Fatigue at an increased rate. Must maintain at least 80 intelligence and 9 tails or lose the perk."
                },
                new Skill
                {
                    Id = 67,
                    Title = "Flexibility",
                    Description = "Grants cat-like flexibility. Useful for dodging and 'fun'.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Having a cat tail, cat legs and cat ears. Lost if any of these characteristics are lost.",
                    Effect = "Allows the character to attempt cat-like autofellatio or autocunnilingus. Grants the character an additional chance to dodge some attacks, similar to Evade, but with a generally lower chance of success."
                },
                new Skill
                {
                    Id = 68,
                    Title = "Harpy Womb",
                    Description = "Increases all laid eggs to large size so long as you have harpy legs and a harpy tail.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "May be gained when consuming a golden seed or a magic seed while having both harpy legs and a harpy tail.",
                    Effect = "While the character has both harpy legs and a harpy tail, eggs birthed by the character will always be large. The effect is lost if either of these two transformations are lost, but will return if they are regained."
                },
                new Skill
                {
                    Id = 69,
                    Title = "Incorporeality",
                    Description = "Allows you to fade into a ghost-like state and temporarily possess others.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "Consuming ectoplasm while having white or sable skin and transparent hair.",
                    Effect = "The character's legs are described as partially transparent. Allows for use of the Possess special attack in combat."
                },
                new Skill
                {
                    Id = 70,
                    Title = "Oviposition",
                    Description = "Causes you to regularly lay eggs when not otherwise pregnant.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk,
                    Prerequisites = "May be gained by drinking Reptilum while having a vagina and a lizard score over 3. Lost if lizard score drops below 3.",
                    Effect = "Causes you to lay eggs once every 30 days when not otherwise pregnant. Decreases timer to 15 days if both Bunny Eggs and Oviposition are obtained, or if character is otherwise highly fertile."
                },
                new Skill
                {
                    Id = 71,
                    Title = "Spider Ovipositor",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_TFPerk
                },

                // Corruption of Champions: Other Perks
                new Skill
                {
                    Id = 72,
                    Title = "Androgyny",
                    Description = "No gender limits on facial masculinity or femininity.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Gained from consuming sufficient amounts of trap oil or by visiting Joey at the S. Squeeze.",
                    Effect = "Your femininity score no longer is capped by a minimum and/or maximum based on your genitalia."
                },
                new Skill
                {
                    Id = 73,
                    Title = "Basilisk Womb",
                    Description = "Enables your eggs to be properly fertilized into basilisks of both genders!",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "See Benoit.",
                    Effect = "Causes you to be able to lay female basilisks; grants Oviposition perk if unobtained. Oviposition no longer goes away if the required racial scores are not met."
                },
                new Skill
                {
                    Id = 74,
                    Title = "Bimbo Body",
                    Description = "Gives the body of a bimbo. Tits will never stay below a 'DD' cup, libido is raised, lust resistance is raised, and upgrades tease.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drink Bimbo Liqueur."
                },
                new Skill
                {
                    Id = 75,
                    Title = "Bimbo Brains",
                    Description = "Now that you've drank bimbo liquer[sic], you'll never, like, have the attention span and intelligence you once did! But it's okay, 'cause you get to be so horny an' stuff!",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drink Bimbo Liqueur."
                },
                new Skill
                {
                    Id = 76,
                    Title = "Bro Body",
                    Description = "Grants an ubermasculine body that's sure to impress.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drink a Bro Brew.",
                    Effect = "Minimum lust is increased by 40 (for interactions with other minimum lust boosting perks and effects, see the minimum lust article). Lust gains are reduced by 25%. Libido gains are increased by 100% and libido losses are decreased by 50%. Cum production is increased by 30% and the character gains a bonus 200 mL increase. +5% bonus to hidden Virility stat. The Tease or Seduce special attack is replaced with Bro Tease. If the character ever loses all their penises they will grow a 10\" long and 2.75\" wide cock. If their penis ever drops below 10\" in length it increases to 10\", and thickens to 2\" if narrower.If they are missing their testicles they gain a pair of 3\" diameter balls."
                },
                new Skill
                {
                    Id = 77,
                    Title = "Bro Brains",
                    Description = "Makes thou... thin... fuck, that shit's for nerds.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drink a Bro Brew.",
                    Effect = "Intelligence gains are reduced by 50% and intelligence losses are increased by 100%. Unlocks bro versions of some scenes."
                },
                new Skill
                {
                    Id = 78,
                    Title = "Brood Mother",
                    Description = "Pregnancy moves twice as fast as a normal woman's.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Give birth ten times. (Do anal pregnancies count?)",
                    Effect = "Your pregnancy speed multiplier is increased by 1."
                },
                new Skill
                {
                    Id = 79,
                    Title = "Bulge Armor",
                    Description = "Grants a 5 point damage bonus to dick-based tease attacks.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Requires Dickgartuan possession; random scenario.",
                    Note = "equipping different armor causes Bulge Armor to disappear until Exgartuan grants it again. (Does de-possession cause Bulge Armor to disappear?)"
                },
                new Skill
                {
                    Id = 80,
                    Title = "Chi Reflow - Attack",
                    Description = "Regular attacks boosted, but damage resistance decreased.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Access to Uma's Clinic in Tel'Adre",
                    Effect = "Physical attacks do 10% more damage. Magical attacks do 10% less damage."
                },
                new Skill
                {
                    Id = 81,
                    Title = "Chi Reflow - Defense",
                    Description = "Passive damage resistance, but caps speed",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Access to Uma's Clinic in Tel'Adre",
                    Effect = "Speed is capped at 60. Gain 50 extra HP. Improve defense by 10%."
                },
                new Skill
                {
                    Id = 82,
                    Title = "Chi Reflow - Lust",
                    Description = "Lust resistance and Tease are enhanced, but Libido and Sensitivity gains increased.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Access to Uma's Clinic in Tel'Adre",
                    Effect = "Ingame testing pending."
                },
                new Skill
                {
                    Id = 83,
                    Title = "Chi Reflow - Magic",
                    Description = "Magic attacks are boosted, but regular attacks are weaker.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Access to Uma's Clinic in Tel'Adre",
                    Effect = "Magic attacks do 25% more damage. Physical attacks do 25% less damage."
                },
                new Skill
                {
                    Id = 84,
                    Title = "Chi Reflow - Speed",
                    Description = "Speed reductions halved but caps strength.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Access to Uma's Clinic in Tel'Adre",
                    Effect = "Strength is capped at 60, speed losses are halved."
                },
                new Skill
                {
                    Id = 85,
                    Title = "Cleansing Palm",
                    Description = "A ranged fighting technique of Jojo’s order, allows you to blast your enemies with waves of pure spiritual energy, weakening them and hurting the corrupt.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Training at least 10 times with pure Jojo at camp. Disabled if Corruption is 10 or higher.",
                    Effect = "Teaches the Cleansing Palm seventh Magic spell. Hurts any target with more than 20 Corruption. Normal damage at 45 Corruption, capped at 57.5 Corruption or more."
                },
                new Skill
                {
                    Id = 86,
                    Title = "Controlled Breath",
                    Description = "Jojo’s training allows you to recover more quickly. Increases rate of fatigue regeneration by 10%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Training at least 5 times with pure Jojo at camp. Disabled if Corruption is 30 or higher.",
                    Effect = "+10% Fatigue regeneration. Stacks additively with the History: Slacker perk for up to 30% regeneration."
                },
                new Skill
                {
                    Id = 87,
                    Title = "Enlightened",
                    Description = "Jojo’s tutelage has given you a master’s focus and you can feel the universe in all its glory spread out before you. You’ve finally surpassed your teacher.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Training at least 16 times with pure Jojo at camp. Requires 70 Intelligence to unlock. Disabled if Corruption is 10 or higher.",
                    Effect = "White Magic now allows for up to 85 Lust instead of 75. Meditation can be done alone and restores 50 HP in addition to the regular -50 Lust and -0.3 Corruption.",
                    Note = "As the description and the teacher himself both state, this is Jojo's last lesson and further training will only cause Fatigue."
                },
                new Skill
                {
                    Id = 88,
                    Title = "Feeder",
                    Description = "Lactation does not decrease and gives a compulsion to breastfeed others.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Chance to obtain by drinking LaBova or ProBova while having heavily lactating breasts of DD size or larger and 35 or greater corruption. Lost by reducing corruption to 20 or below.",
                    Effect = "Prevents the character's lactation output from decreasing and breasts from shrinking below DD size. Allows the character to force some defeated foes to drink from their breasts. Can drastically reduce the intelligence loss from using the Breast Milker. Not having been milked within the last 72 hours (3 days) will increase sensitivity by 2 plus 0.05 for every hour past 70 at 14:00 every day. This replaces lactating breasts getting \"overfilled\"."
                },
                new Skill
                {
                    Id = 89,
                    Title = "Fire Lord",
                    Description = "Akbal's blessings grant the ability to breath burning green flames.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "This perk can only be obtained by submitting when Akbal is encountered. If you fight him even once before you get the perk, he will become hostile. The only way to get the perk then is through save editing. Fighting Akbal after obtaining Fire Lord will not remove the perk, and neither will lowering your corruption.",
                    Effect = "Unlocks the Fire Breath special attack.",
                    Note = "80% chance of success. On failure or if silenced, will cause 10-29 Fire damage and increase Fatigue by 10. On success, deals LV*10+45+0..9 Fire damage - if under Goo Armor Silence, removes the status and deals 25 extra damage (Web Silence is not removed). Uses the same rules as all Fire spells (except ethereal, such as Whitefire, FoxFire and Corrupt FoxFire) - don't use it against Isabella, Vala or a concentrated Amily. Recommended at very high levels (20+) due to low random variation."
                },
                new Skill
                {
                    Id = 90,
                    Title = "Futa Faculties",
                    Description = "It's super hard to think about stuff that like, isn't working out or fucking!",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drinking both Bimbo Liqueur and Bro Brew, in either order.",
                    Effect = "Intelligence gains are reduced by 50% and intelligence losses are increased by 100%."
                },
                new Skill
                {
                    Id = 91,
                    Title = "Futa Form",
                    Description = "It's super hard to think about stuff that like, isn't working out or fucking!",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Drinking both Bimbo Liqueur and Bro Brew, in either order.",
                    Effect = "Minimum lust is increased by 40 (for interactions with other minimum lust boosting perks and effects, see the minimum lust article). Reduces lust gains by 25%. Libido gains are increased by 100% and libido losses are decreased by 50%. The Tease or Seduce special attack is replaced with Futa Tease. Ensures that your body fits the Futa look (Tits DD+, Dick 8\"+, & Pussy)."
                },
                new Skill
                {
                    Id = 92,
                    Title = "Hellfire",
                    Description = "Grants a corrupted fire breath attack, like the hellhounds in the mountains.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Give a piece of Marae's Lethicite to the hellhound master. Giving up all the lethicite leads to a bad end. Unlocks the Hellfire special attack.",
                    Effect = "Unlocks the Corrupted Fire Breath special attack.",
                    Note = "The in save description give more details on its functionality: Deals HP or lust damage based on corruption. If the target intelligence less than 10, deals HP damage, otherwise deals lust damage."
                },
                new Skill
                {
                    Id = 93,
                    Title = "Luststick Adapted",
                    Description = "Grants immunity to the lust-increasing effects of lust-stick and allows its use.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Spending a large amount of time under the effects of Sophie or a harpy's lust-increasing lipstick. The counter increases by half of the duration of harpy lipstick with every application, and decreases by 1 every day. A counter value of 50 is required to unlock the perk.",
                    Effect = "Minimum lust is increased by 10 (for interactions with other minimum lust boosting perks and effects, see the minimum lust article). lust gains are reduced by 10%. The character is no longer affected by harpy lipstick, and bimbo Sophie will surprise the character in camp with a kiss less frequently."
                },
                new Skill
                {
                    Id = 94,
                    Title = "Magical Fertility",
                    Description = "Fucking cheater-nozzle.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Blessing from the Cum Witch.",
                    Effect = "10% higher chance of pregnancy and increased pregnancy speed."
                },
                new Skill
                {
                    Id = 95,
                    Title = "Magical Virility",
                    Description = "200 mLs more cum per orgasm and enhanced virility.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Blessing from the Cum Witch",
                    Effect = "As in description, plus: +5% bonus to hidden Virility stat."
                },
                new Skill
                {
                    Id = 96,
                    Title = "Marae's Gift - Buttslut",
                    Description = "Makes your anus provide lubrication when aroused.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "After failing to steal Marae's Lethicite and gaining Marae's Gift - Fertility, return to Marae's island as a female and choose to stay. Males and herms will receive Marae's Gift - Stud instead.",
                    Effect = "The character's anal wetness is increased to 2. Anal wetness will never drop below 2."
                },
                new Skill
                {
                    Id = 97,
                    Title = "Marae's Gift - Fertility",
                    Description = "Greatly increases fertility and halves base pregnancy speed.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 98,
                    Title = "Marae's Gift - Profractory",
                    Description = "Causes your cum to build up at 3x the normal rate.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Effect = "Causes base Cum Production to increase by 3 times the normal rate."
                },
                new Skill
                {
                    Id = 99,
                    Title = "Marae's Gift - Stud",
                    Description = "Increases your cum production and potency greatly.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 100,
                    Title = "Marble Resistant",
                    Description = "Provides resistance to the addictive effects of bottled LaBova milk.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 101,
                    Title = "Marble's Milk",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 102,
                    Title = "Minotaur Cum Addict",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 103,
                    Title = "Misdirection",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 104,
                    Title = "Omnibus' Gift",
                    Description = "Increases minimum lust but provides some lust resistance.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 105,
                    Title = "Purity Blessing",
                    Description = "Reduces the rate at which your corruption, libido, and lust increase.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Consume Pure Pearl"
                },
                new Skill
                {
                    Id = 106,
                    Title = "Slime Core",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 107,
                    Title = "Spellcasting Affinity",
                    Description = "Reduces spell costs by 20%/35%/50%.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 108,
                    Title = "Thick Skin",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Gained through continued use of the item Numb Rocks.",
                    Effect = "Increases armor by 2."
                },
                new Skill
                {
                    Id = 109,
                    Title = "Whispered",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Submit to Akbal without fighting 5 times with 40 or more corruption.",
                    Effect = "Grants Whisper special attack."
                },
                
                // Corruption of Champions: Event Perks
                new Skill
                {
                    Id = 110,
                    Title = "Cornucopia",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Cockgobbler nightfall on November 22 in player's camp, choose \"Main Course\" option",
                    Effect = "Increase vaginal and anal capacity by 30 each."
                },
                new Skill
                {
                    Id = 111,
                    Title = "Elven Bounty",
                    Description = "Increases fertility by X% and cum production by XXmLs.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Christmas Elf between December 25 and 31 in player's camp after sleeping, corruptionm >= 90, no corrupted/bimbo followers, \"Unwrap Elf\" option",
                    Effect = "+250 mls to cum volume (cock) or +15 to fertility (vagina) with appropriate option (reportedly stacks with each new year's application)"
                },
                new Skill
                {
                    Id = 112,
                    Title = "Fera's Boon - Alpha",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Fera in Deepwoods between October 27 and November 2, cock"
                },
                new Skill
                {
                    Id = 113,
                    Title = "Fera's Boon - Breeding Bitch",
                    Description = "Increases fertility and reduces the time it takes to birth young.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Fera in Deepwoods between October 27 and November 2, vagina, vaginal wetness >= 2 or Fertility >= 30"
                },
                new Skill
                {
                    Id = 114,
                    Title = "Fera's Boon - Milking Twat",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Fera in Deepwoods between October 27 and November 2; +1 year, previous Fera Perk, vagina, \"Tight\" option"
                },
                new Skill
                {
                    Id = 115,
                    Title = "Fera's Boon - Seeder",
                    Description = "Increases cum output by 1,000 mL.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Fera in Deepwoods between October 27 and November 2; +1 year, previous Fera Perk, cock or choose \"Dick\" option (with vagina and no cock)"
                },
                new Skill
                {
                    Id = 116,
                    Title = "Fera's Boon - Wide Open",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Fera in Deepwoods between October 27 and November 2; +1 year, previous Fera Perk, vagina, \"Gape\" option"
                },
                new Skill
                {
                    Id = 117,
                    Title = "One Track Mind",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 118,
                    Title = "Pilgrim's Bounty",
                    Description = "Causes you to always cum as hard as if you had max lust.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk,
                    Prerequisites = "Encounter Cockgobbler nightfall on November 22 in player's camp, choose \"Stuff her\" option",
                    Effect = "Increase cum amount."
                },
                new Skill
                {
                    Id = 119,
                    Title = "Pure and Loving",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                new Skill
                {
                    Id = 120,
                    Title = "Sensual Lover",
                    Description = "Your sensual attitude towards love and romance makes your tease ability slightly more effective.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_OtherPerk
                },
                
                // Corruption of Champions: Item Perks
                new Skill
                {
                    Id = 121,
                    Title = "Blood Mage",
                    Description = "Spellcasting now consumes health instead of fatigue!",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk,
                    Prerequisites = "Wear the Inquisitor's Robes or Inquisitor's Corset.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 122,
                    Title = "Lusty Regeneration",
                    Description = "",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 123,
                    Title = "Midas Cock",
                    Description = "Increases the gems awarded from victory in battle.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk,
                    Prerequisites = "Wear the Glided cocksock.",
                    Effect = ""
                },
                new Skill
                {
                    Id = 124,
                    Title = "Pent Up",
                    Description = "",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 125,
                    Title = "Phallic Potential",
                    Description = "",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 126,
                    Title = "Phallic Restraint",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 127,
                    Title = "Pierced: Crimstone",
                    Description = "Increases minimum lust by X.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 128,
                    Title = "Pierced: Fertite",
                    Description = "Increases cum production by XX% and fertility by X.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 129,
                    Title = "Pierced: Furrite",
                    Description = "Increases chances of encountering 'furry' foes.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 130,
                    Title = "Pierced: Lethite",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 131,
                    Title = "Slutty Seduction",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 132,
                    Title = "Wizard's Endurance",
                    Description = "Reduces fatigue cost of spells by 30%",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                new Skill
                {
                    Id = 133,
                    Title = "Wizard's Focus",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_ItemPerk
                },
                
                // Corruption of Champions: Unimplemented Perks
                new Skill
                {
                    Id = 134,
                    Title = "Brawler",
                    Description = "Brawling experience allows you to make two unarmed attacks in a turn.",
                    Dimension = Dimension.CoC,
                    Style = SkillStyle.Perk,
                    Subgroup = SkillSubgroup.CoC_UnimplementedPerk,
                    Prerequisites = "Save Editing",
                    Effect = "Appears to have no actual ingame effect."
                },

                // DMR
                new Skill
                {
                    Id = 1000,
                    Title = "Explore",
                    Description = "Combine water and cold magic to rocket propel jetison a high speed lance from the nether.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Causes 8% (+0.08% * SP) of target's health in Frost Damage and slows the target by 50% for 2 actions.",
                    TravelTime = DateTimeOffset.Parse("2s")
                },
                new Skill
                {
                    Id = 1001,
                    Title = "Teleport",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1002,
                    Title = "Masturbate",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1003,
                    Title = "Meditate",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1004,
                    Title = "Sleep",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1005,
                    Title = "Attack",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1006,
                    Title = "Tease",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Sometimes may occur as a begging motion.",
                    RankMax = 5
                },
                new Skill
                {
                    Id = 1007,
                    Title = "Flee",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },
                new Skill
                {
                    Id = 1008,
                    Title = "Rape",
                    Description = "",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = ""
                },



                new Skill
                {
                    Id = 1100,
                    Title = "Icicle",
                    Description = "Combine water and cold magic to rocket propel jetison a high speed lance from the nether.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Causes 8% (+0.08% * SP) of target's health in Frost Damage and slows the target by 50% for 2 actions.",
                    TravelTime = DateTimeOffset.Parse("2s")
                },
                new Skill
                {
                    Id = 1101,
                    Title = "Icicle Shards",
                    Description = "Icicles shatter on impact, causing Frost Damage to nearby enemies.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Mastery,
                    Prerequisites = "Icicle, level 8",
                    Effect = "Causes 33% additional SP Frost Damage to the target and 2 nearby enemies.",
                    LevelRequired = 8,
                    SkillId = 135
                },
                new Skill
                {
                    Id = 1102,
                    Title = "Icicle Mastery (Rank 3)",
                    Description = "Combine water and cold magic to rocket propel jetison a high speed lance from the nether.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Mastery,
                    Prerequisites = "",
                    Effect = "Causes 8% (+0.08% * SP) of target's health in Frost Damage and slows the target by 50% for 2 actions.",
                    LevelRequired = 12,
                    SkillId = 135
                },

                new Skill
                {
                    Id = 1103,
                    Title = "Lava Burst",
                    Description = "Join rock and flame in slam crushing projectiles.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Causes 12% (+0.12% * SP) of target's health in Heat Damage and increases future attacks by 3% - max 3 stacks."
                },
                new Skill
                {
                    Id = 1104,
                    Title = "Lightning Bolt",
                    Description = "Near instantaneous energy wracking the core of your being.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Causes 3% (+0.05% * SP) of target's health in Ethereal Damage.  20% chance to Stun."
                },
                new Skill
                {
                    Id = 1105,
                    Title = "Restoration",
                    Description = "Uses life energy to restore ally health.",
                    Dimension = Dimension.DMR,
                    Style = SkillStyle.Spellcast,
                    Prerequisites = "",
                    Effect = "Heals 6% (+0.06% * SP) of target's health with life energy."
                }
            };

            return skills;
        }
    }
}
