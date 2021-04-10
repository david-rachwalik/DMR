using DMR.WebApp.Areas.Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Forum.Data
{
    public static class ForumAssetData
    {
        public static ForumAsset[] Seed()
        {
            // https://www.pathofexile.com/forum
            // https://www.pathofexile.com/forum/view-forum/dev-manifesto
            // I like the idea of /about/manifesto/ as its own page
            // Other philosophy changes will be in Announcements

            ForumAsset[] forumAssets = new ForumAsset[]
            {
                new ForumAsset()
                {
                    Id = 1,
                    Title = "Announcements",
                    Description = "All the latest news and status updates",
                    Group = ForumGroup.News
                },
                new ForumAsset()
                {
                    Id = 2,
                    Title = "Patch Notes",
                    Description = "Patch notes about game engine updates",
                    Group = ForumGroup.News
                },

                new ForumAsset()
                {
                    Id = 3,
                    Title = "General Discussion",
                    Description = "Discussions regarding the game",
                    Group = ForumGroup.Community
                },
                new ForumAsset()
                {
                    Id = 4,
                    Title = "Off Topic",
                    Description = "For topics unrelated to the game",
                    Group = ForumGroup.Community
                },
                new ForumAsset()
                {
                    Id = 5,
                    Title = "Gameplay Help & Discussion",
                    Description = "Conversations about gameplay (non-feedback)",
                    Group = ForumGroup.Community
                },
                new ForumAsset()
                {
                    Id = 6,
                    Title = "Community Challenges",
                    Description = "Ideas for wacky character builds & impossible feats",
                    Group = ForumGroup.Community
                },
                new ForumAsset()
                {
                    Id = 7,
                    Title = "Community Showcase",
                    Description = "Post your character milestones & fan content",
                    Group = ForumGroup.Community
                },

                new ForumAsset()
                {
                    Id = 8,
                    Title = "Suggestions",
                    Description = "General feedback about the game engine",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 9,
                    Title = "Design Feedback",
                    Description = "Discussions about the Art, Animations, Layout, & Options",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 10,
                    Title = "Gameplay Feedback",
                    Description = "Discussions about the gameplay",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 11,
                    Title = "Lore Feedback",
                    Description = "Discussions about game lore (history, characters, & world)",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 12,
                    Title = "Item Feedback",
                    Description = "Discussions about the loot (armor, weapons, trinkets, etc.)",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 13,
                    Title = "Skill Feedback",
                    Description = "Discussions about the skills and effects",
                    Group = ForumGroup.Feedback
                },
                new ForumAsset()
                {
                    Id = 14,
                    Title = "Bug Reports",
                    Description = "Please post one thread per issue and check for similar posts first",
                    Group = ForumGroup.Feedback
                }
            };

            return forumAssets;
        }
    }
}
