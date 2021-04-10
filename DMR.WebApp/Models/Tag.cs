using DMR.WebApp.Areas.Game.Data;
using DMR.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMR.WebApp.Models
{
    public class Tag : Asset
    {
        public bool IsActive { get; set; }
        public string Group { get; set; } // Entity model name
    }

    #region FluentAPI
    class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.HasIndex(t => t.Title).IsUnique();

            builder.HasData(TagData.Seed());
        }
    }
    #endregion
}
