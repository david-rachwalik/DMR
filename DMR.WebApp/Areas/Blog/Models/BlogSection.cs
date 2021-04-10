using DMR.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Blog.Models
{
    public class BlogSection : Asset
    {
    }


    public static class BlogSectionData
    {
        public static BlogSection[] Seed()
        {
            BlogSection[] blogSections = new BlogSection[]
            {
                new BlogSection
                {
                    Id = 1,
                    Title = "Videogame",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 2,
                    Title = "Anime",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 3,
                    Title = "Fantasy",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 4,
                    Title = "Movies",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 5,
                    Title = "Music",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 6,
                    Title = "Writing",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 7,
                    Title = "Superheroes",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 8,
                    Title = "Programming",
                    Description = ""
                },
                new BlogSection
                {
                    Id = 9,
                    Title = "SelfDevelopment",
                    Description = ""
                }
            };

            return blogSections;
        }
    }
}
