using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Areas.Game.Models.Templates
{
    public class StoryTemplate : GameAsset
    {
        public IEnumerable<Moment> Moments { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }

    #region FluentAPI
    class StoryTemplateConfiguration : IEntityTypeConfiguration<StoryTemplate>
    {
        public void Configure(EntityTypeBuilder<StoryTemplate> builder)
        {
            builder.ToTable("StoryTemplate");

            //builder.HasData(StoryTemplateData.Seed());
        }
    }
    #endregion
}
